using Microsoft.Data.SqlClient;
using System.Data;
using CafePos.Models;

namespace CafePosApp.AppForm
{
    public partial class Items : UserControl
    {
        public string id { get; set; }
        List<Ingredient> lst_Ingredient = new List<Ingredient>();

        public Items()
        {
            InitializeComponent();
            textBoxSearch.Hide();
        }
        private void Items_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridView);
            Common.ConfigureGrid(dataGridView2);
            //            this.button1.BackColor = Color.FromArgb(22, 163, 74);
            Reset();
        }

        private async void Reset()
        {
            try
            {
                dataGridView.DataSource = await Common.GetDataTable("SpItem");
                if (dataGridView.Columns.Contains("Id"))
                    dataGridView.Columns["Id"].Visible = false;
                Common.fillComboBox("Categories", comboBox1);
                Common.fillComboBox("Ingredients", comboBox2);
                Common.fillComboBox("Units", comboBox3);
                id = "";
                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_CellContentClick();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "--Select--" && comboBox3.Text != "--Select--" && textBox3.Text != string.Empty)
            {
                var is_Exist = lst_Ingredient.Exists(x => x.Name == comboBox2.Text);
                if (is_Exist == false)
                {
                    Ingredient Ingredientitem = new Ingredient(comboBox2.Text, comboBox3.Text, Convert.ToDecimal(textBox3.Text),
                  Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(comboBox3.SelectedValue.ToString()));

                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = Ingredientitem.Name;
                    dataGridView2.Rows[n].Cells[2].Value = Ingredientitem.Unit;
                    dataGridView2.Rows[n].Cells[1].Value = Ingredientitem.Quantity;
                    Common.fillComboBox("Ingredients", comboBox2);
                    Common.fillComboBox("Units", comboBox3);
                    textBox3.Text = "";
                    lst_Ingredient.Add(Ingredientitem);
                }
                else
                {
                    MessageBox.Show("Ingredient is already added", "Info", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please Select Ingredient, Unit or Quantity", "Info", MessageBoxButtons.OK);
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dGV_CellContentClick();
        }
        private void dGV_CellContentClick()
        {
            try
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                dataGridView.CurrentRow.Selected = true;
                id = dataGridView.CurrentRow.Cells[0].Value.ToString();

                textBox1.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();

                // Get Item Ingredient

                SqlDataAdapter sda = new SqlDataAdapter("Select IngredientId,UntiId,Quantity,Ingredients.Name as [Ingredient Name],Units.Name as [Unit Name] from ItemIngredients Inner Join Ingredients on Ingredients.Id = ItemIngredients.IngredientId Inner Join Units on Units.Id = ItemIngredients.UntiId Where ItemIngredients.ItemId = " + id + "", GlobalConnectionString.Connection());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lst_Ingredient.Clear();
                dataGridView2.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int IngredientId = Convert.ToInt32(dt.Rows[i][0]);
                    int UntiId = Convert.ToInt32(dt.Rows[i][1]);
                    int Quantity = Convert.ToInt32(dt.Rows[i][2]);
                    string IngredientName = Convert.ToString(dt.Rows[i][3]);
                    string UnitName = Convert.ToString(dt.Rows[i][4]);

                    Ingredient Ingredientitem = new Ingredient(IngredientName, UnitName, Convert.ToDecimal(Quantity),
                     Convert.ToInt32(IngredientId), Convert.ToInt32(UntiId));

                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = Ingredientitem.Name;
                    dataGridView2.Rows[n].Cells[2].Value = Ingredientitem.Unit;
                    dataGridView2.Rows[n].Cells[1].Value = Ingredientitem.Quantity;

                    Common.fillComboBox("Ingredients", comboBox2);
                    Common.fillComboBox("Units", comboBox3);
                    textBox3.Text = "";
                    lst_Ingredient.Add(Ingredientitem);
                }

                //Update.Enabled = true;
                //Save.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    lst_Ingredient.RemoveAt(dataGridView2.SelectedRows[0].Index);
                    dataGridView2.Rows.Remove(dataGridView2.Rows[dataGridView2.SelectedRows[0].Index]);
                }
                catch (Exception)
                {

                }
            }
        }
    }
    public class Ingredient
    {
        public string Name { get; set; }
        public int IngredientId { get; set; }
        public string Unit { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public Ingredient(string Name, string Unit, decimal Quantity, int IngredientId, int UnitId)
        {
            this.Name = Name;
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.IngredientId = IngredientId;
            this.UnitId = UnitId;
        }
    }
}