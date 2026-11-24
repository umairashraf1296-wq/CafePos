using System.Data;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class ExpensType : UserControl
    {
        private string Getid { get; set; } = string.Empty;
        public ExpensType()
        {
            InitializeComponent();
        }

        private void ExpensType_Load(object sender, EventArgs e)
        {
            buttonSave.Hide();
            buttonUpdate.Hide();
            buttonClear.Hide();
            textBoxSearch.Hide();
            labelCount.Hide();
            Common.ConfigureGrid(dataGridView);
            Common.SetButtonName(button1, button2, button3);
            Reset();
        }

        private async void Reset()
        {
            DataTable dataTable = await Common.GetDataTable("SpExpensType");
            dataGridView.DataSource = dataTable;

            button1.Enabled = true;
            button2.Enabled = true;

            if (dataGridView.Columns.Contains("Id"))
                dataGridView.Columns["Id"].Visible = false;

            textBoxName.Text = "";
            textSearchBox.Text = "";
            UpdateCount(dataTable.DefaultView.Count);
        }

        private void UpdateCount(int count)
        {
            label1.Text = count == 1 ? "1 EXPONS TYPE" : $"{count} EXPONS TYPE";
        }


        private void textSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable)
                return;

            string searchText = textSearchBox.Text.Trim().Replace("'", "''");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                GetExecuteNonQuery("Save");
            else
                MessageBox.Show("Enter Expens Type", "Warning", MessageBoxButtons.OK);
        }
        private void GetExecuteNonQuery(string _Action)
        {
            try
            {
                var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                var Action = StoredProcedure.CreateParameter("@Action", _Action, "string");
                if (_Action == "Save")
                    StoredProcedure.GetExecuteNonQuery("SpExpensType", Action, Name);
                else if (_Action == "Update")
                    StoredProcedure.GetExecuteNonQuery("SpExpensType", Action, id, Name);
                else if(_Action== "Delete") StoredProcedure.GetExecuteNonQuery("SpExpensType", Action, id);

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                    return;

                dataGridView.CurrentRow.Selected = true;
                Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                button1.Enabled = false;
                button2.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                GetExecuteNonQuery("Update");
            else
                MessageBox.Show("Enter Item Name", "Warning", MessageBoxButtons.OK);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this unit?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (Getid != null)
                    GetExecuteNonQuery("Delete");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }

        #region No Need Code
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void panelGrid_Paint_1(object sender, PaintEventArgs e)
        {

        }

        #endregion       
    }
}