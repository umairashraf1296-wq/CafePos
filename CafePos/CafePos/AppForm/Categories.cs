using System.Data;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class Categories : UserControl
    {
        public string Getid { get; set; } = string.Empty;
        public Categories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            buttonSave.Text = "Save";
            Common.ConfigureGrid(dataGridView);
            Reset();
        }
        private async void Reset()
        {
            try
            {
                DataTable dataTable = await Common.GetDataTable("SpCategories");
                dataGridView.DataSource = dataTable;
                if (dataGridView.Columns.Contains("Id"))
                {
                    dataGridView.Columns["Id"].Visible = false;
                }


                dataGridView.ClearSelection();
                ClearSelection();
                textBoxSearch.Text = "";
                UpdateUnitCount(dataTable.Rows.Count);
                buttonUpdate.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearSelection()
        {
            Getid = string.Empty;
            textBoxSearch.Text = "";
            textBoxName.Clear();
            buttonUpdate.Enabled = false;
            buttonSave.Enabled = true;
            dataGridView.ClearSelection();
        }
        private void UpdateUnitCount(int count)
        {
            labelCount.Text = count == 1 ? "1 Category" : $"{count} Categories";
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxName.Text != string.Empty)
                {
                    var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                    var Action = StoredProcedure.CreateParameter("@Action", "Save", "string");
                    StoredProcedure.GetExecuteNonQuery("SpCategories", Name, Action);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Enter Item Name", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
            textBoxName.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty)
                {
                    var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                    var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                    var Action = StoredProcedure.CreateParameter("@Action", "Update", "string");
                    StoredProcedure.GetExecuteNonQuery("SpCategories", Name, Action, id);

                    Reset();
                }
                else
                {
                    MessageBox.Show("Enter Item Name", "Warning", MessageBoxButtons.OK);
                }
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
                try
                {
                    Getid = "";
                    Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    if (Getid != null)
                    {
                        var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                        var Action = StoredProcedure.CreateParameter("@Action", "Delete", "string");
                        StoredProcedure.GetExecuteNonQuery("SpCategories", Action, id);
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
 
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable)
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

