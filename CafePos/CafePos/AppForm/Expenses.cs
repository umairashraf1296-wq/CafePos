using CafePos.Models;
using System.Data;
namespace CafePos.AppForm
{
    public partial class Expenses : UserControl
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridView);
            Reset();
            this.buttonSave.Text = "Save";
            buttonClear.Text = "Refresh";
        }

        private async void Reset()
        {
            try
            {
                DataTable dataTable = await Common.GetDataTable("SpExpenses");
                dataGridView.DataSource = dataTable;
                this.buttonSave.Enabled = true;
                buttonUpdate.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dataGridViewUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
