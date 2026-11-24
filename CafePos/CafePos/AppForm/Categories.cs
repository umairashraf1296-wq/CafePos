using System.Data;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class Categories : UserControl
    {
        private string Getid { get; set; } = string.Empty;
        public string SpName { get; set; }
        public Categories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            SpName = "SpCategories";
            Common.ConfigureGrid(dataGridView);
            Reset();
            Common.SetButtonName(buttonSave, buttonUpdate, buttonClear);
        }
        private async void Reset()
        {
            try
            {
                DataTable dataTable = await Common.GetDataTable(SpName);
                dataGridView.DataSource = dataTable;

                if (dataGridView.Columns.Contains("Id"))
                    dataGridView.Columns["Id"].Visible = false;

                textBoxName.Text = "";
                textBoxSearch.Text = "";
                Getid = "";
                buttonSave.Enabled = true;
                buttonUpdate.Enabled = false;
                UpdateUnitCount(dataTable.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUnitCount(int count)
        {
            labelCount.Text = count == 1 ? "1 Category" : $"{count} Categories";
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetExecuteNonQuery("Save");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GetExecuteNonQuery("Update");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                    return;

                dataGridView.CurrentRow.Selected = true;
                dataGridView.CurrentRow.Selected = true;
                Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
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
                Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
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
            
                if (_Action == "Save" && textBoxName.Text != string.Empty)
                    StoredProcedure.GetExecuteNonQuery(SpName, Action, Name);
                
                if (Getid != null )
                {            
                    if (_Action == "Update" && textBoxName.Text != string.Empty)
                        StoredProcedure.GetExecuteNonQuery(SpName, Action, id, Name);
                    else if (_Action == "Delete")
                        StoredProcedure.GetExecuteNonQuery(SpName, Action, id);
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable)
                return;

            string searchText = textBoxSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(searchText))
                dataTable.DefaultView.RowFilter = string.Empty;

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

            UpdateUnitCount(dataTable.DefaultView.Count);
        }

        #region
        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panelContent_Paint_2(object sender, PaintEventArgs e)
        {
        }
        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
        }
        #endregion
    }
}