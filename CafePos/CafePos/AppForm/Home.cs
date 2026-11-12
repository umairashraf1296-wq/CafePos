using CafePosApp.AppForm;
namespace CafePos.AppForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.labelTitle.Text = "";

            // CheckExpiryDate();
        }
        #region
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ConfigurePosShell()
        {
            Text = "Cafe POS";
            BackColor = Color.FromArgb(243, 244, 246);

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.White;
                item.BackColor = Color.FromArgb(31, 41, 55);
            }

            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new PosMenuColors());
        }

        private void CreateDashboard()
        {
            panel1.Controls.Clear();
            panel1.BackColor = Color.FromArgb(243, 244, 246);

            Label title = new Label
            {
                Text = "Cafe POS Dashboard",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                AutoSize = true,
                Location = new Point(40, 32)
            };

            Label subtitle = new Label
            {
                Text = "Point of Sale workspace",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(107, 114, 128),
                AutoSize = true,
                Location = new Point(43, 78)
            };

            Panel posCard = CreateDashboardCard(
                "POS Terminal",
                "Start a new sale",
                Color.FromArgb(37, 99, 235),
                new Point(40, 125));
            Panel unitsCard = CreateDashboardCard(
                "Units",
                "Manage product units",
                Color.FromArgb(22, 163, 74),
                new Point(360, 125));
            Panel reportsCard = CreateDashboardCard(
                "Reports",
                "View sales summaries",
                Color.FromArgb(124, 58, 237),
                new Point(680, 125));

            posCard.Cursor = Cursors.Default;
            unitsCard.Cursor = Cursors.Hand;
            unitsCard.Click += (_, _) =>
            {
                Units units = new Units();
                addUserControl(units);
            };
            foreach (Control control in unitsCard.Controls)
            {
                control.Cursor = Cursors.Hand;
                control.Click += (_, _) =>
                {
                    Units units = new Units();
                    addUserControl(units);
                };
            }

            panel1.Controls.Add(title);
            panel1.Controls.Add(subtitle);
            panel1.Controls.Add(posCard);
            panel1.Controls.Add(unitsCard);
            panel1.Controls.Add(reportsCard);
        }

        private Panel CreateDashboardCard(string heading, string description, Color accent, Point location)
        {
            Panel card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Location = location,
                Size = new Size(290, 170)
            };

            Panel accentBar = new Panel
            {
                BackColor = accent,
                Dock = DockStyle.Top,
                Height = 8
            };

            Label title = new Label
            {
                Text = heading,
                Font = new Font("Segoe UI", 15F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(22, 32),
                AutoSize = true
            };

            Label text = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(22, 76),
                AutoSize = true
            };

            card.Controls.Add(accentBar);
            card.Controls.Add(title);
            card.Controls.Add(text);
            return card;
        }

        private sealed class PosMenuColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.FromArgb(55, 65, 81);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(55, 65, 81);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(55, 65, 81);
            public override Color MenuItemBorder => Color.FromArgb(55, 65, 81);
            public override Color MenuBorder => Color.FromArgb(75, 85, 99);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(55, 65, 81);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(55, 65, 81);
        }
        private void uNITSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Units";
            Units i = new Units();
            addUserControl(i);
        }
        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Categories";
            Categories i = new Categories();
            addUserControl(i);
        }
        private void iNVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice i = new Invoice();
            addUserControl(i);
        }
        private void iNGREDIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Item Ingredients";
            Ingredients i = new Ingredients();
            addUserControl(i);
        }
        private void UNITSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion
        //SqlConnection con = new SqlConnection(Global.ConnectionString());

        //private void CheckExpiryDate()
        //{
        //    SqlDataAdapter sda = new SqlDataAdapter("Select ExpiryDate,IsExpired from SoftwareConfig", con);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    DateTime expiryDate = Convert.ToDateTime(dt.Rows[0][0]);
        //    bool isExpired = Convert.ToBoolean(dt.Rows[0][1]);
        //    DateTime current = DateTime.Now;

        //    if (isExpired)
        //    {
        //        MessageBox.Show("Your software license is expired please contact to software team", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        Environment.Exit(0);
        //        Application.Exit();
        //    }
        //    if (current.Date > expiryDate.Date)
        //    {
        //        MessageBox.Show("Your software license will expire soon please to contact software team", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        SqlCommand cmd;
        //        cmd = new SqlCommand("Update SoftwareConfig set IsExpired=@isExpired", con);
        //        cmd.Parameters.AddWithValue("@isExpired", true);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ConfigurePosShell();
            CreateDashboard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Invoice pointOfSaleForm = new Invoice();
            //   pointOfSaleForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Items product = new Items();
            //product.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Categories Category = new Categories();
            //Category.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //SalesOrder sf = new SalesOrder();
            //sf.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Your application will close and backup file will save in system..", "Please confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    try
            //    {
            //       // Back up working
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            Application.Exit();
        }



        private void sALESREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SalesOrder sf = new SalesOrder();
            //sf.Show();
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Items (Menu)";
            Items i = new Items();
            addUserControl(i);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }
        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Backup bk = new Backup();
            //bk.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void sALESSUMMERYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SalesSummery ss = new SalesSummery();
            //ss.Show();
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure  to close the application?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Application.Exit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void bACKUPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Backup bp = new Backup();
            //bp.Show();
        }



        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure  to close the application?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Application.Exit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void aBOUTSOFTWAREToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 

        private void wAITERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Waiters w = new Waiters();
            //w.Show();
        }

        private void wAITERSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WaiterSalesSummery wss = new WaiterSalesSummery();
            //wss.Show();
        }

        private void pURCHASEORDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //      PurchaseOrder po = new PurchaseOrder();
            //    po.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //     WaiterSalesSummery wss = new WaiterSalesSummery();
        }

        private void sALESREPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SalesReport sr = new SalesReport();
            //sr.Show();
        }

        private void wAITERSALESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //WaiterSalesSummery wss = new WaiterSalesSummery();
            //wss.Show();
        }

        private void wAITERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Waiters w = new Waiters();
            //w.Show();
        }

        private void eXPENSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Expenses e1 = new Expenses();
            //e1.Show();
        }

        private void iTEMSSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.labelTitle.Text = "Ingredients Stock";
            this.labelSubtitle.Text = "View current ingredient inventory and resolved quantities";
            ItemStock i = new ItemStock();
            addUserControl(i); //its.Show();
        }

        private void sUPPLIERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Supplier s = new Supplier();
            //s.Show();
        }

        private void vENDORBALANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SupplierBalance sb = new SupplierBalance();
            //sb.Show();
        }

        private void vENDORLEDGERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SupplierLedger sl = new SupplierLedger();
            //sl.Show();
        }

        private void pURCHASEORDERLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PurchaseOrderList pol = new PurchaseOrderList();
            //pol.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tables tab = new Tables();
            //tab.Show();
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            //DailyInvoiceReport dir = new DailyInvoiceReport();
            //dir.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
