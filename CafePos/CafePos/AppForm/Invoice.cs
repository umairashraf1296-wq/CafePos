using System.Data;
using Microsoft.Data.SqlClient;
using CafePos.Models;

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
    }
}
