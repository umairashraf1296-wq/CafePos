namespace CafePos.AppForm
{
    partial class SalesReport
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
            label4 = new TextBox();
            label6 = new Label();
            textSearchBox = new TextBox();
            button1 = new Button();
            labellist = new Label();
            labelCount = new Label();
            textBoxSearch = new TextBox();
            buttonPrint = new Button();
            dataGridView = new DataGridView();
            label1 = new Label();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(label1);
            panelGrid.Controls.Add(label4);
            panelGrid.Controls.Add(label6);
            panelGrid.Controls.Add(textSearchBox);
            panelGrid.Controls.Add(button1);
            panelGrid.Controls.Add(labellist);
            panelGrid.Controls.Add(labelCount);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Controls.Add(buttonPrint);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Location = new Point(15, 14);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1548, 797);
            panelGrid.TabIndex = 3;
            panelGrid.Paint += panelGrid_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(736, 18);
            label4.Margin = new Padding(3, 4, 3, 4);
            label4.Name = "label4";
            label4.ReadOnly = true;
            label4.Size = new Size(299, 32);
            label4.TabIndex = 74;
            label4.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(577, 18);
            label6.Name = "label6";
            label6.Size = new Size(154, 28);
            label6.TabIndex = 73;
            label6.Text = "Total Amount :-";
            // 
            // textSearchBox
            // 
            textSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textSearchBox.BackColor = Color.White;
            textSearchBox.BorderStyle = BorderStyle.FixedSingle;
            textSearchBox.Font = new Font("Segoe UI", 10F);
            textSearchBox.ForeColor = Color.FromArgb(17, 24, 39);
            textSearchBox.Location = new Point(1333, 18);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.PlaceholderText = "Search stock...";
            textSearchBox.Size = new Size(205, 30);
            textSearchBox.TabIndex = 5;
            textSearchBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1233, 18);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 6;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = false;
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
            labelCount.Location = new Point(3701, 16);
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
            textBoxSearch.Location = new Point(2656, 16);
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
            buttonPrint.Location = new Point(2556, 16);
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
            dataGridView.Location = new Point(18, 49);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1509, 677);
            dataGridView.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(107, 114, 128);
            label1.Location = new Point(1062, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 75;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelGrid);
            Name = "SalesReport";
            Size = new Size(1566, 823);
            Load += SalesReport_Load;
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrid;
        private Label labellist;
        private Label labelCount;
        private TextBox textBoxSearch;
        private Button buttonPrint;
        private DataGridView dataGridView;
        private TextBox textSearchBox;
        private Button button1;
        private TextBox label4;
        private Label label6;
        private Label label1;
    }
}
