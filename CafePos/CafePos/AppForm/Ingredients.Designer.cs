namespace CafePos.AppForm
{
    partial class Ingredients
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
            panelGrid = new Panel();
            labelUnits = new Label();
            textBoxSearch = new TextBox();
            dataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label1 = new Label();
            Update = new Button();
            Save = new Button();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(labelUnits);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Location = new Point(24, 170);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1518, 643);
            panelGrid.TabIndex = 2;
            panelGrid.Paint += panelGrid_Paint;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUnits.ForeColor = Color.FromArgb(31, 41, 55);
            labelUnits.Location = new Point(18, 18);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(177, 28);
            labelUnits.TabIndex = 0;
            labelUnits.Text = "INGREDIENT LIST";
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
            textBoxSearch.PlaceholderText = "Search ingredients...";
            textBoxSearch.Size = new Size(205, 30);
            textBoxSearch.TabIndex = 2;
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
            dataGridView.ContextMenuStrip = contextMenuStrip1;
            dataGridView.Location = new Point(18, 58);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1477, 560);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, refreshToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 76);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(127, 24);
            editToolStripMenuItem.Text = " Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(127, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(127, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Update);
            groupBox1.Controls.Add(Save);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 41, 55);
            groupBox1.Location = new Point(24, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(18, 24, 18, 18);
            groupBox1.Size = new Size(1518, 140);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "INGREDIENT DETAILS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(959, 58);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 30);
            dateTimePicker1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(959, 28);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 19;
            label7.Text = "Expiry";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(713, 28);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 18;
            label6.Text = "To Unit";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(713, 58);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 31);
            comboBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(478, 58);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 30);
            textBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(478, 28);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 16;
            label5.Text = "Unit Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(243, 28);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 14;
            label4.Text = "From Unit";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 58);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 31);
            comboBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(18, 58);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 30);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 6;
            label1.Text = "Ingredient Name";
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(37, 99, 235);
            Update.FlatAppearance.BorderSize = 0;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Update.ForeColor = Color.White;
            Update.Location = new Point(1355, 48);
            Update.Margin = new Padding(3, 4, 3, 4);
            Update.Name = "Update";
            Update.Size = new Size(130, 38);
            Update.TabIndex = 1;
            Update.Text = "UPDATE";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(22, 163, 74);
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(1216, 48);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(130, 38);
            Save.TabIndex = 5;
            Save.Text = "SAVE";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Ingredients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(panelGrid);
            Name = "Ingredients";
            Size = new Size(1566, 823);
            Load += Ingredients_Load;
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrid;
        private Label labelUnits;
        private TextBox textBoxSearch;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label1;
        private Button Update;
        private Button Save;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}
