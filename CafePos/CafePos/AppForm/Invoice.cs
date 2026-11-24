using System.Data;
using CafePos.Models;
using Microsoft.Data.SqlClient;

namespace CafePos.AppForm
{
    public partial class Invoice : UserControl
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            GetButtonDynamically();
            Common.ConfigureGrid(dataGridView);
            Common.ConfigureGrid(dataGridView2);
            Reset();
        }

        private void Reset()
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetButtonDynamically()
        {
            try
            {
                int x = 0;
                int y = 0;
                var Count = 1;
                SqlConnection conn = new SqlConnection(GlobalConnectionString.ConnectionString());
                conn.Open();
                using (conn)
                {
                    SqlCommand cmd = new SqlCommand("select Name from Categories order by Name ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Button mybutton = new Button();
                        mybutton.Location = new Point(x, y);
                        x += 152;
                        if (Count % 5 == 0)
                        {
                            x = 0;
                            y += 60;
                        }
                        mybutton.Height = 55;
                        mybutton.Width = 145;
                        mybutton.FlatStyle = FlatStyle.Popup;

                        mybutton.BackColor = Color.OrangeRed;
                        mybutton.ForeColor = Color.White;

                        mybutton.Text = reader["Name"].ToString();
                        mybutton.Name = reader["Name"].ToString();
                        mybutton.Font = new Font("Arial Narrow", 12);
                        mybutton.Font = new Font(mybutton.Font, FontStyle.Bold);

                        Controls.Add(mybutton);
                        this.listView1.Controls.Add(mybutton);
                        Count++;
                        mybutton.Click += new EventHandler(mybutton_Click);

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void mybutton_Click(object sender, EventArgs e)
        {
            try
            {
                string str = sender.ToString();
                string GetName = str.Remove(0, 35);
                var BtnName = StoredProcedure.CreateParameter("@Name", GetName, "string");
                var Action = StoredProcedure.CreateParameter("@Action", "SearchByName", "string");
                DataTable dataTable = await StoredProcedure.GetDataTable("SpItem", BtnName, Action);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show(sender.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                //if (price.Text != string.Empty && Quality.Text != string.Empty && label4.Text != "label4" && label4.Text != string.Empty)
            //    {
            //        SaleOrderDetail items = new SaleOrderDetail(label4.Text, Convert.ToDecimal(price.Text),
            //Convert.ToDecimal(Quality.Text), Convert.ToDecimal(Total.Text));
            //        int n = dataGridView2.Rows.Add();
            //        dataGridView2.Rows[n].Cells[0].Value = items.Name;
            //        dataGridView2.Rows[n].Cells[1].Value = items.Price;
            //        dataGridView2.Rows[n].Cells[2].Value = items.Quality;
            //        dataGridView2.Rows[n].Cells[3].Value = items.Total;

                    //        decimal ta = Convert.ToDecimal(TotalAmount.Text);
                    //        decimal tt = Convert.ToDecimal(Total.Text);
                    //        decimal totalSum = ta + tt;
                    //        TotalAmount.Text = totalSum.ToString();
                    //        NetAmount.Text = TotalAmount.Text;
                    //        Reset();

                    //      }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            // Reset();
            // fillComboBox();
            //this.TotalAmount.Text = "0";
            //this.NetAmount.Text = "0";
            textBoxdisper.Text = "0";
            comboBox3.Enabled = true;
            button16.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
      //      this.Close();
        }
    }
    public class SaleOrderDetail
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
        public decimal Quality { get; set; }
        public decimal Total { get; set; }

        public SaleOrderDetail(string Name, decimal Price, decimal Quality, decimal Total)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quality = Quality;
            this.Total = Total;
        }
    }
}

