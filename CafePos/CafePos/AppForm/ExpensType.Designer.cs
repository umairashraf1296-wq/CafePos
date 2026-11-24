namespace CafePos.AppForm
{
    partial class ExpensType
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
            panelForm = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelName = new Label();
            textBoxName = new TextBox();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            panelGrid = new Panel();
            label1 = new Label();
            textSearchBox = new TextBox();
            labelUnits = new Label();
            labelCount = new Label();
            textBoxSearch = new TextBox();
            dataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panelForm.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(button1);
            panelForm.Controls.Add(button2);
            panelForm.Controls.Add(button3);
            panelForm.Controls.Add(labelName);
            panelForm.Controls.Add(textBoxName);
            panelForm.Controls.Add(buttonSave);
            panelForm.Controls.Add(buttonUpdate);
            panelForm.Controls.Add(buttonClear);
            panelForm.Location = new Point(27, 14);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1518, 116);
            panelForm.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(22, 163, 74);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(817, 40);
            button1.Name = "button1";
            button1.Size = new Size(130, 38);
            button1.TabIndex = 4;
            button1.Text = "ADD UNIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(37, 99, 235);
            button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(957, 40);
            button2.Name = "button2";
            button2.Size = new Size(130, 38);
            button2.TabIndex = 5;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(229, 231, 235);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(55, 65, 81);
            button3.Location = new Point(1097, 40);
            button3.Name = "button3";
            button3.Size = new Size(130, 38);
            button3.TabIndex = 6;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelName.ForeColor = Color.FromArgb(55, 65, 81);
            labelName.Location = new Point(20, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(116, 23);
            labelName.TabIndex = 0;
            labelName.Text = "EXPENS TYPE";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(20, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(750, 34);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 163, 74);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(2306, 42);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 38);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "ADD UNIT";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.FromArgb(37, 99, 235);
            buttonUpdate.Enabled = false;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(2446, 42);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(130, 38);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClear.BackColor = Color.FromArgb(229, 231, 235);
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonClear.ForeColor = Color.FromArgb(55, 65, 81);
            buttonClear.Location = new Point(2586, 42);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(130, 38);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(label1);
            panelGrid.Controls.Add(textSearchBox);
            panelGrid.Controls.Add(labelUnits);
            panelGrid.Controls.Add(labelCount);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Location = new Point(27, 136);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1518, 643);
            panelGrid.TabIndex = 2;
            panelGrid.Paint += panelGrid_Paint_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(107, 114, 128);
            label1.Location = new Point(1123, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textSearchBox
            // 
            textSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textSearchBox.BorderStyle = BorderStyle.FixedSingle;
            textSearchBox.Font = new Font("Segoe UI", 10F);
            textSearchBox.Location = new Point(1293, 16);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(205, 30);
            textSearchBox.TabIndex = 5;
            textSearchBox.TextChanged += textSearchBox_TextChanged;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUnits.ForeColor = Color.FromArgb(31, 41, 55);
            labelUnits.Location = new Point(18, 18);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(129, 28);
            labelUnits.TabIndex = 0;
            labelUnits.Text = "ESPENS LIST";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.ForeColor = Color.FromArgb(107, 114, 128);
            labelCount.Location = new Point(2436, 20);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(165, 24);
            labelCount.TabIndex = 1;
            labelCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(2606, 16);
            textBoxSearch.Name = "textBoxSearch";
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
            dataGridView.Location = new Point(18, 62);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1495, 563);
            dataGridView.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 52);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(122, 24);
            updateToolStripMenuItem.Text = "Edit ";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // ExpensType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelGrid);
            Controls.Add(panelForm);
            Name = "ExpensType";
            Size = new Size(1566, 823);
            Load += ExpensType_Load;
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonClear;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panelGrid;
        private Label labelUnits;
        private Label labelCount;
        private TextBox textBoxSearch;
        private DataGridView dataGridView;
        private Label label1;
        private TextBox textSearchBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
