namespace CafePosApp.AppForm
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            panelGrid = new Panel();
            labelUnits = new Label();
            labelCount = new Label();
            dataGridView = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            textBoxSearch = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            IngredientName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuStrip2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(labelUnits);
            panelGrid.Controls.Add(labelCount);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Location = new Point(701, 11);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(861, 809);
            panelGrid.TabIndex = 2;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUnits.ForeColor = Color.FromArgb(31, 41, 55);
            labelUnits.Location = new Point(18, 18);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(105, 28);
            labelUnits.TabIndex = 0;
            labelUnits.Text = "ITEM LIST";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.ForeColor = Color.FromArgb(107, 114, 128);
            labelCount.Location = new Point(1779, 20);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(165, 24);
            labelCount.TabIndex = 1;
            labelCount.TextAlign = ContentAlignment.MiddleRight;
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
            dataGridView.ContextMenuStrip = contextMenuStrip2;
            dataGridView.Location = new Point(3, 59);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(853, 745);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(105, 28);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(104, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(1949, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(205, 30);
            textBoxSearch.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(2, 259);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(674, 413);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingredient Details";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(22, 163, 74);
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(407, 159);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(178, 39);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IngredientName, Quantity, Unit, Delete });
            dataGridView2.Location = new Point(10, 211);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(664, 239);
            dataGridView2.TabIndex = 20;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // IngredientName
            // 
            IngredientName.HeaderText = "Name";
            IngredientName.MinimumWidth = 6;
            IngredientName.Name = "IngredientName";
            IngredientName.Width = 225;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 70;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.Width = 130;
            // 
            // Delete
            // 
            Delete.HeaderText = "Remove";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(10, 124);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 18;
            label7.Text = "Quantity";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(183, 117);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 30);
            textBox3.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(10, 170);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 16;
            label6.Text = "Unit";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Microsoft Sans Serif", 11.25F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(183, 163);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(198, 32);
            comboBox3.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 14;
            label3.Text = "Ingredient Name";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 11.25F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(183, 69);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(401, 32);
            comboBox2.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(25, 11);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(674, 227);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(8, 161);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 12;
            label2.Text = "Item Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(8, 105);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 11;
            label4.Text = "Item Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 52);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 10;
            label1.Text = "Item Name";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(175, 157);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 33);
            comboBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(175, 102);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 30);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(175, 49);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 30);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(33, 695);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(178, 39);
            button2.TabIndex = 23;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(233, 695);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(178, 39);
            button3.TabIndex = 24;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panelGrid);
            Name = "Items";
            Size = new Size(1566, 823);
            Load += Items_Load;
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrid;
        private Label labelUnits;
        private Label labelCount;
        private TextBox textBoxSearch;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IngredientName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewImageColumn Delete;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button button2;
        private Button button3;
    }
}
