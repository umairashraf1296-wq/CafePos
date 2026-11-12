using System.Data;

namespace CafePos.Models
{
    public static class Common
    {
        public static void ConfigureGrid(DataGridView dataGridView)
        {
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView.ColumnHeadersHeight = 42;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
            dataGridView.GridColor = Color.FromArgb(229, 231, 235);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
        public async static Task<DataTable> GetDataTable(string StoredProcedureName)
        {
            DataTable dataTable = new DataTable();
            try
            {
                var Action = StoredProcedure.CreateParameter("@Action", "List", "string");
                dataTable = await StoredProcedure.GetDataTable(StoredProcedureName, Action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dataTable;
            }
            return dataTable;
        }
        public static async void fillComboBox(string Type, ComboBox ComboBox)
        {
            try
            {
                var Action = StoredProcedure.CreateParameter("@Action", Type, "string");
                DataTable dataTable = await StoredProcedure.GetDataTable("SpFillComboBox", Action);
                DataRow row = dataTable.NewRow();
                row[0] = 0;
                row[1] = "--Select--";
                dataTable.Rows.InsertAt(row, 0);
                ComboBox.DataSource = dataTable;
                ComboBox.DisplayMember = "Name";
                ComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
