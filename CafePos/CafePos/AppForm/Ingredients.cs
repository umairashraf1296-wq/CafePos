using CafePos.Models;
using System.Data;

namespace CafePos.AppForm
{
    public partial class Ingredients : UserControl
    {
        public Ingredients()
        {
            InitializeComponent();
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridView);
            label7.Hide();
            dateTimePicker1.Hide();
            Reset();
        }
        private async void Reset()
        {
            try
            {
                 DataTable dataTable = await Common.GetDataTable("SpIngredientsUnit");
                dataGridView.DataSource = dataTable;
 
                if (dataGridView.Columns.Contains("Id"))
                    dataGridView.Columns["Id"].Visible = false;
                
                Common.fillComboBox("Units", comboBox1);
                Common.fillComboBox("Units", comboBox2);
                Update.Enabled = false;
                Save.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != string.Empty && comboBox1.Text != "--Select--" && textBox1.Text != string.Empty)
                {
                    var Name = StoredProcedure.CreateParameter("@Name", textBox2.Text, "string");
                    var Multiplier = StoredProcedure.CreateParameter("@Multiplier", textBox1.Text, "decimal");
                    var ToUnitId = StoredProcedure.CreateParameter("@ToUnitId", comboBox2.SelectedValue.ToString(), "int");
                    var BaseUnitId = StoredProcedure.CreateParameter("@BaseUnitId", comboBox1.SelectedValue.ToString(), "int");
                    var Action = StoredProcedure.CreateParameter("@Action", "Save", "string");
                    var result = StoredProcedure.GetExecuteNonQuery("SpIngredientsUnit", Name, Action, ToUnitId, BaseUnitId, Multiplier);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Enter Ingredients Details", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var id = StoredProcedure.CreateParameter("@id", dataGridView.CurrentRow.Cells[0].Value.ToString(), "int");
                var Name = StoredProcedure.CreateParameter("@Name", textBox2.Text, "string");
                var Multiplier = StoredProcedure.CreateParameter("@Multiplier", textBox1.Text, "decimal");
                var ToUnitId = StoredProcedure.CreateParameter("@ToUnitId", comboBox2.SelectedValue.ToString(), "int");
                var BaseUnitId = StoredProcedure.CreateParameter("@BaseUnitId", comboBox1.SelectedValue.ToString(), "int");
                var Action = StoredProcedure.CreateParameter("@Action", "Update", "string");
                StoredProcedure.GetExecuteNonQuery("SpIngredientsUnit", id, Name, Action, ToUnitId, BaseUnitId, Multiplier);
                Reset();
                //  Display();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.CurrentRow.Selected = true;
                textBox2.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                Update.Enabled = true;
                Save.Enabled = false;
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
                try
                {
                    var DeleteGetid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    if (DeleteGetid != null)
                    {
                        var id = StoredProcedure.CreateParameter("@id", DeleteGetid, "int");
                        var Action = StoredProcedure.CreateParameter("@Action", "Delete", "string");
                        StoredProcedure.GetExecuteNonQuery("SpIngredientsUnit", Action, id);
                        Reset();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
