using CafePos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace CafePos.AppForm
{
    public partial class SupplierLedger : Form
    {
        SqlConnection con = new SqlConnection(GlobalConnectionString.ConnectionString());
        public SupplierLedger()
        {
            InitializeComponent();
            Common.ConfigureGrid(dataGridViewSaleSummery);
        }

        private void SupplierLedger_Load(object sender, EventArgs e)
        {
           Common.fillComboBox("Vendor", comboBox1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select Particular,floor(Debit) as Debit,Credit,floor(RemainingBalance) as [Remaining Balance] ,Date from dbo.[PurchaseLedger] Where VendorId = '" + comboBox1.SelectedValue + "'", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridViewSaleSummery.DataSource = dt1;

                long suplyId = Convert.ToInt64(comboBox1.SelectedValue);
                SqlDataAdapter Orderda = new SqlDataAdapter("Select VendorBalance.Balance from Vendor Inner join VendorBalance On VendorBalance.VendorId = Vendor.Id where VendorBalance.VendorId = '" + suplyId + "'", con);
                DataTable Orderdt = new DataTable();
                Orderda.Fill(Orderdt);
                string Balance = Orderdt.Rows[0][0].ToString();
                textBox1.Text = Balance;
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter("Select Date,Particular,Debit,Credit,RemainingBalance from dbo.[PurchaseLedger] Where VendorId = '" + comboBox1.SelectedValue + "'", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridViewSaleSummery.DataSource = dt1;

                long suplyId = Convert.ToInt64(comboBox1.SelectedValue);
                SqlDataAdapter Orderda = new SqlDataAdapter("Select VendorBalance.Balance from Vendor Inner join VendorBalance On VendorBalance.VendorId = Vendor.Id where VendorBalance.VendorId = '" + suplyId + "'", con);
                DataTable Orderdt = new DataTable();
                Orderda.Fill(Orderdt);
                string Balance = Orderdt.Rows[0][0].ToString();
                textBox1.Text = Balance;
            }
            catch (Exception)
            {

            }
        }
    }
}
