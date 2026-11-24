using System.Data;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class SalesReport : UserControl
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridView);
            Reset();
            textBoxSearch.Hide();
            labelCount.Hide();
            buttonPrint.Hide();
            this.labellist.Text = "SALES REPORT LIST";
        }
        private async void Reset()
        {
            try
            {
                string query = "Select FORMAT(CreatedOn, 'MMMM-yyyy') As DATE,floor(Sum(NetAmount)) As [TOTAL AMOUNT] from [SalesOrder] Group by FORMAT(CreatedOn, 'MMMM-yyyy') ";
                DataTable dataTable = await StoredProcedure.GetDataTable(query);
                dataGridView.DataSource = dataTable;

                int sum = 0;
                for (int i = 0; i < dataGridView.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value);
                }

                label4.Text = sum.ToString();
                UpdateCount(dataTable.DefaultView.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateCount(int count)
        {
            labelCount.Text = count == 1 ? "" : $"{count} ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            int sum = 0;
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value);
            }

            label4.Text = sum.ToString();
            UpdateCount(dataTable.DefaultView.Count);
        }
    }
}
