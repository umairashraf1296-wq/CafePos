namespace CafePos.AppForm
{
    partial class Invoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            listView1 = new ListView();
            dataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            checkBox2 = new CheckBox();
            textBoxdisper = new TextBox();
            label17 = new Label();
            checkBox1 = new CheckBox();
            label11 = new Label();
            button16 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label9 = new Label();
            button13 = new Button();
            label2 = new Label();
            label1 = new Label();
            price = new TextBox();
            Quality = new TextBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(820, 303);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeight = 42;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Location = new Point(829, 3);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(734, 303);
            dataGridView.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(textBoxdisper);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(price);
            panel1.Controls.Add(Quality);
            panel1.Location = new Point(3, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 494);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(256, 278);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 106;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(177, 278);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 105;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 278);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 104;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 278);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 103;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(664, 222);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(39, 24);
            checkBox2.TabIndex = 100;
            checkBox2.Text = "2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxdisper
            // 
            textBoxdisper.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxdisper.Location = new Point(570, 159);
            textBoxdisper.Margin = new Padding(3, 4, 3, 4);
            textBoxdisper.Name = "textBoxdisper";
            textBoxdisper.Size = new Size(111, 30);
            textBoxdisper.TabIndex = 102;
            textBoxdisper.Text = "0";
            textBoxdisper.TextAlign = HorizontalAlignment.Center;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(457, 159);
            label17.Name = "label17";
            label17.Size = new Size(80, 26);
            label17.TabIndex = 101;
            label17.Text = "Dis (%)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(616, 222);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(39, 24);
            checkBox1.TabIndex = 99;
            checkBox1.Text = "1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(433, 222);
            label11.Name = "label11";
            label11.Size = new Size(152, 28);
            label11.TabIndex = 98;
            label11.Text = "Invoice Prints :";
            // 
            // button16
            // 
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Microsoft Sans Serif", 12F);
            button16.Location = new Point(272, 97);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new Size(112, 33);
            button16.TabIndex = 97;
            button16.Text = "NEW";
            button16.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(94, 97);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(162, 33);
            comboBox3.TabIndex = 96;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 11.25F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Dining", "Delivery", "Takeaway" });
            comboBox2.Location = new Point(142, 222);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(283, 32);
            comboBox2.TabIndex = 95;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(3, 222);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 94;
            label10.Text = "Order Type :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 11.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 159);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 32);
            comboBox1.TabIndex = 93;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(3, 159);
            label12.Name = "label12";
            label12.Size = new Size(117, 28);
            label12.TabIndex = 92;
            label12.Text = "Served by :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(0, 97);
            label9.Name = "label9";
            label9.Size = new Size(88, 28);
            label9.TabIndex = 91;
            label9.Text = "Table # :";
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Microsoft Sans Serif", 12F);
            button13.Location = new Point(496, 48);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(73, 33);
            button13.TabIndex = 90;
            button13.Text = "ADD";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(306, 15);
            label2.Name = "label2";
            label2.Size = new Size(47, 26);
            label2.TabIndex = 89;
            label2.Text = "Qty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(1, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 88;
            label1.Text = "Price (₨)";
            // 
            // price
            // 
            price.Font = new Font("Microsoft Sans Serif", 14.25F);
            price.Location = new Point(1, 48);
            price.Margin = new Padding(3, 4, 3, 4);
            price.Name = "price";
            price.Size = new Size(303, 34);
            price.TabIndex = 87;
            price.TextAlign = HorizontalAlignment.Center;
            // 
            // Quality
            // 
            Quality.Font = new Font("Microsoft Sans Serif", 14.25F);
            Quality.Location = new Point(312, 48);
            Quality.Margin = new Padding(3, 4, 3, 4);
            Quality.Name = "Quality";
            Quality.Size = new Size(178, 34);
            Quality.TabIndex = 86;
            Quality.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView2.Location = new Point(829, 313);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 32;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(734, 507);
            dataGridView2.TabIndex = 46;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 330;
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Delete";
            Column5.Image = (Image)resources.GetObject("Column5.Image");
            Column5.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.ToolTipText = "Delete";
            Column5.Width = 105;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(listView1);
            Name = "Invoice";
            Size = new Size(1566, 823);
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private DataGridView dataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private Button button13;
        private Label label2;
        private Label label1;
        private TextBox price;
        private TextBox Quality;
        private CheckBox checkBox2;
        private TextBox textBoxdisper;
        private Label label17;
        private CheckBox checkBox1;
        private Label label11;
        private Button button16;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label10;
        private ComboBox comboBox1;
        private Label label12;
        private Label label9;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
