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
            buttonUpdate.Enabled = false;
        }
        private async void Reset()
        {
            try
            {
                DataTable dataTable =await Common.GetDataTable("SpUnits");
                dataGridViewUnits.DataSource =  dataTable;
                if (dataGridViewUnits.Columns.Contains("Id"))
                    dataGridViewUnits.Columns["Id"].Visible = false;

                dataGridViewUnits.ClearSelection();
                ClearSelection();
                textBoxSearch.Text = "";
                UpdateUnitCount(dataTable.Rows.Count);
                //UpdateUnitCount(await Common.GetDataTable("SpUnits")?.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty)
                {
                    var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                    var Action = StoredProcedure.CreateParameter("@Action", "Save", "string");
                    StoredProcedure.GetExecuteNonQuery("SpUnits", Name, Action);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty)
                {
                    var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                    var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
                    var Action = StoredProcedure.CreateParameter("@Action", "Update", "string");
                    StoredProcedure.GetExecuteNonQuery("SpUnits", Name, Action, id);

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

        private void dataGridViewUnits_SelectionChanged(object sender, EventArgs e)
        {
            //SelectCurrentRow();
        }

        private void dataGridViewUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void ClearSelection()
        {
            Getid = string.Empty;
            textBoxSearch.Text = "";
            textBoxName.Clear();
            buttonUpdate.Enabled = false;
            buttonSave.Enabled = true;
            dataGridViewUnits.ClearSelection();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
            textBoxName.Focus();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewUnits.DataSource is not DataTable dataTable)
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

        private void UpdateUnitCount(int count)
        {
            labelCount.Text = count == 1 ? "1 UNIT" : $"{count} UNITS";
        }

        
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUnits.CurrentRow == null)
                {
                    return;
                }

                dataGridViewUnits.CurrentRow.Selected = true;
                dataGridViewUnits.CurrentRow.Selected = true;
                Getid = dataGridViewUnits.CurrentRow.Cells[0].Value.ToString();
                textBoxName.Text = dataGridViewUnits.CurrentRow.Cells[2].Value.ToString();
                //SelectCurrentRow();
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
                    //SelectCurrentRow();
                    Getid = dataGridViewUnits.CurrentRow.Cells[0].Value.ToString();
                    if (Getid != null)
                    {
                        var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                        var Action = StoredProcedure.CreateParameter("@Action", "Delete", "string");
                        StoredProcedure.GetExecuteNonQuery("SpUnits", Action, id);

                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        //private void SelectCurrentRow()
        //{
        //if (dataGridViewUnits.CurrentRow?.DataBoundItem is not DataRowView row)
        //{
        //    return;
        //}

        //DataColumnCollection columns = row.Row.Table.Columns;
        //DataColumn? idColumn = columns.Cast<DataColumn>().FirstOrDefault(column =>
        //    string.Equals(column.ColumnName, "Id", StringComparison.OrdinalIgnoreCase) ||
        //    string.Equals(column.ColumnName, "UnitId", StringComparison.OrdinalIgnoreCase));
        //DataColumn? nameColumn = columns.Contains("Name")
        //    ? columns["Name"]
        //    : columns.Cast<DataColumn>().FirstOrDefault(column =>
        //        column.DataType == typeof(string) &&
        //        column.ColumnName.IndexOf("name", StringComparison.OrdinalIgnoreCase) >= 0);

        //if (idColumn != null && row[idColumn.ColumnName] != DBNull.Value)
        //{
        //    selectedUnitId = Convert.ToInt32(row[idColumn.ColumnName]);
        //    Getid = row[idColumn.ColumnName].ToString() ?? string.Empty;
        //}

        //if (nameColumn != null)
        //{
        //    textBoxName.Text = Convert.ToString(row[nameColumn.ColumnName]) ?? string.Empty;
        //}

        //buttonSave.Enabled = false;
        //buttonUpdate.Enabled = selectedUnitId.HasValue;
        //}
        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }
        #endregion
    }
}
