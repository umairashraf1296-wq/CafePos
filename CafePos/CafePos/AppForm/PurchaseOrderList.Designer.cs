namespace CafePos.AppForm
{
    partial class PurchaseOrderList
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
            panelGrid = new Panel();
            labellist = new Label();
            labelCount = new Label();
            textBoxSearch = new TextBox();
            buttonPrint = new Button();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            buttonSave = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new TextBox();
            label5 = new Label();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(labellist);
            panelGrid.Controls.Add(labelCount);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Controls.Add(buttonPrint);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Location = new Point(24, 129);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1518, 617);
            panelGrid.TabIndex = 2;
            panelGrid.Paint += panelGrid_Paint;
            // 
            // labellist
            // 
            labellist.AutoSize = true;
            labellist.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labellist.ForeColor = Color.FromArgb(31, 41, 55);
            labellist.Location = new Point(18, 18);
            labellist.Name = "labellist";
            labellist.Size = new Size(119, 28);
            labellist.TabIndex = 0;
            labellist.Text = "STOCK LIST";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.ForeColor = Color.FromArgb(107, 114, 128);
            labelCount.Location = new Point(2355, 16);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(165, 24);
            labelCount.TabIndex = 1;
            labelCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.ForeColor = Color.FromArgb(17, 24, 39);
            textBoxSearch.Location = new Point(1310, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search stock...";
            textBoxSearch.Size = new Size(205, 30);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPrint.BackColor = Color.FromArgb(37, 99, 235);
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            buttonPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(1210, 16);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(100, 30);
            buttonPrint.TabIndex = 4;
            buttonPrint.Text = "PRINT";
            buttonPrint.UseVisualStyleBackColor = false;
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
            dataGridView.Location = new Point(18, 80);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1479, 487);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 88);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint_1;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 163, 74);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(543, 38);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "ADD UNIT";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(321, 43);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(191, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(84, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(31, 41, 55);
            label3.Location = new Point(281, 43);
            label3.Name = "label3";
            label3.Size = new Size(34, 28);
            label3.TabIndex = 3;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(31, 41, 55);
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 2;
            label2.Text = "From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(18, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1211, 38);
            label4.Margin = new Padding(3, 4, 3, 4);
            label4.Name = "label4";
            label4.ReadOnly = true;
            label4.Size = new Size(301, 32);
            label4.TabIndex = 72;
            label4.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1049, 38);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 71;
            label5.Text = "Total Amount :-";
            // 
            // PurchaseOrderList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelGrid);
            Name = "PurchaseOrderList";
            Size = new Size(1566, 823);
            Load += PurchaseOrderList_Load;
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrid;
        private Label labellist;
        private Label labelCount;
        private TextBox textBoxSearch;
        private Button buttonPrint;
        private DataGridView dataGridView;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Button buttonSave;
        private TextBox label4;
        private Label label5;
    }
}
