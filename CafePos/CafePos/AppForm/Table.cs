using CafePos.Models;
using System.Data;

namespace CafePos.AppForm
{
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }
        public string GetId { get; set; }
        private void Table_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridView1);
            Reset();
            Common.SetButtonName(buttonSave , buttonUpdate, buttonClear);
        }
        private async void Reset()
        {
            try
            {
                DataTable dataTable = await Common.GetDataTable("SpTables");
                dataGridView1.DataSource = dataTable;

                if (dataGridView1.Columns.Contains("Id"))
                    dataGridView1.Columns["Id"].Visible = false;

                dataGridView1.ClearSelection();

                buttonUpdate.Enabled = false;
                buttonSave.Enabled = true;

                ClearSelection();
                textBoxSearch.Text = "";
                UpdateCount(dataTable.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                GetExecuteNonQuery("Save");
            else
                MessageBox.Show("Enter Table Name", "Warning", MessageBoxButtons.OK);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
        private void ClearSelection()
        {
            textBoxSearch.Text = "";
            textBoxName.Clear();
            buttonUpdate.Enabled = false;
            buttonSave.Enabled = true;
            dataGridView1.ClearSelection();
        }
        private void UpdateCount(int count)
        {
            labelCount.Text = count == 1 ? "1 UNIT" : $"{count} UNITS";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is not DataTable dataTable)
            {
                return;
            }

            string searchText = textBoxSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(searchText))
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string[] nameColumns = dataTable.Columns.Cast<DataColumn>()
                    .Where(column => column.DataType == typeof(string))
                    .Select(column => column.ColumnName)
                    .ToArray();

                dataTable.DefaultView.RowFilter = nameColumns.Length == 0
                    ? string.Empty
                    : string.Join(" OR ", nameColumns.Select(column =>
                        $"CONVERT([{column}], 'System.String') LIKE '%{searchText}%'"));
            }

            UpdateCount(dataTable.DefaultView.Count);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure  to update this recore?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBoxName.Text != string.Empty)

                    GetExecuteNonQuery("Update");
                else
                    MessageBox.Show("Please enter table name");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dataGridView1.CurrentRow.Selected = true;
                textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                buttonSave.Enabled = false;
                buttonUpdate.Enabled = true;
            }
            catch (Exception)
            {
                goto End;
            }
        End:;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this recore?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GetId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (GetId != null)
                    GetExecuteNonQuery("Delete");
            }
        }

        private void GetExecuteNonQuery(string _Action)
        {
            try
            {
                var id = StoredProcedure.CreateParameter("@Id", GetId, "int");
                var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                var Action = StoredProcedure.CreateParameter("@Action", _Action, "string");
                switch (_Action)
                {
                    case "Save":
                        StoredProcedure.GetExecuteNonQuery("SpTables", Action, Name);
                        break;
                    case "Update":
                        StoredProcedure.GetExecuteNonQuery("SpTables", id, Action, Name);
                        break;
                    default:
                        StoredProcedure.GetExecuteNonQuery("SpTables", id);
                        break;
                }
                Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please select a record to " + _Action, "Warning" + ex.Message);
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
