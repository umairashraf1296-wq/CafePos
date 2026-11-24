using System.Data;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class Units : UserControl
    {
        public string Getid { get; set; } = string.Empty;
        public Units()
        {
            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridViewUnits);
            Reset();
            Common.SetButtonName(buttonSave , buttonUpdate, buttonClear);
            buttonUpdate.Enabled = false;
        }
        private async void Reset()
        {
            dataGridViewUnits.ClearSelection();
            Getid = string.Empty;
            textBoxSearch.Text = "";
            textBoxName.Text = "";
            buttonUpdate.Enabled = false;
            buttonSave.Enabled = true;

            DataTable dataTable = await Common.GetDataTable("SpUnits");
            dataGridViewUnits.DataSource = dataTable;

            if (dataGridViewUnits.Columns.Contains("Id"))
                dataGridViewUnits.Columns["Id"].Visible = false;

            UpdateCount(dataTable.Rows.Count);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                GetExecuteNonQuery("Save");
            else
                MessageBox.Show("Enter Item Name", "Warning", MessageBoxButtons.OK);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                GetExecuteNonQuery("Update");
            else
                MessageBox.Show("Enter Item Name", "Warning", MessageBoxButtons.OK);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewUnits.DataSource is not DataTable dataTable)
                return;

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

        private void UpdateCount(int count)
        {
            labelCount.Text = count == 1 ? "1 UNIT" : $"{count} UNITS";
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUnits.CurrentRow == null)
                    return;

                dataGridViewUnits.CurrentRow.Selected = true;
                dataGridViewUnits.CurrentRow.Selected = true;
                Getid = dataGridViewUnits.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewUnits.CurrentRow.Cells[2].Value.ToString();
                buttonSave.Enabled = false;
                buttonUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this unit?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Getid = "";
                Getid = dataGridViewUnits.CurrentRow.Cells[0].Value.ToString();
                if (Getid != null)
                    GetExecuteNonQuery("Delete");
            }
        }

        private void GetExecuteNonQuery(string _Action)
        {
            try
            {
                var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                var Action = StoredProcedure.CreateParameter("@Action", _Action, "string");
                if (_Action == "Save")
                    StoredProcedure.GetExecuteNonQuery("SpUnits", Action, Name);
                else if (_Action == "Update")
                    StoredProcedure.GetExecuteNonQuery("SpUnits", Action, id, Name);
                else StoredProcedure.GetExecuteNonQuery("SpUnits", Action, id);

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dataGridViewUnits_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void dataGridViewUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        #endregion

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
