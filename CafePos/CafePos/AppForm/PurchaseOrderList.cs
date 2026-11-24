using CafePos.Models;
using System.Data;

namespace CafePos.AppForm
{
    public partial class PurchaseOrderList : UserControl
    {
        public PurchaseOrderList()
        {
            InitializeComponent();
        }

        private void PurchaseOrderList_Load(object sender, EventArgs e)
        {
            labellist.Text = "Purchase Order List";

            Reset();
            Common.ConfigureGrid(dataGridView);
            Common.dateTimePicker(dateTimePicker1);
            Common.dateTimePicker(dateTimePicker2);
            buttonSave.Text = "Search";
        }
        private async void Reset()
        {
            try
            {
                DataTable dt = await Common.GetDataTable("SpPurchaseOrderList");
                dataGridView.DataSource = dt;

                int sum = 0;
                for (int i = 0; i < dataGridView.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                }

                label4.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var toDate = dateTimePicker2.Value.AddDays(+1).ToString("yyyy-MM-dd");
                var From = StoredProcedure.CreateParameter("@From", dateTimePicker1.Text, "datetime");
                var To = StoredProcedure.CreateParameter("@To", toDate, "datetime");
                var Action = StoredProcedure.CreateParameter("@Action", "FromTo", "string");
                DataTable dt = await StoredProcedure.GetDataTable("SpPurchaseOrderList", From, To, Action);
                dataGridView.DataSource = dt;

                int sum = 0;
                for (int i = 0; i < dataGridView.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView.Rows[i].Cells[2].Value);
                }

                label4.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #region No Need 

        //private void buttonSave_Click(object sender, EventArgs e)
        //{
        //}
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
