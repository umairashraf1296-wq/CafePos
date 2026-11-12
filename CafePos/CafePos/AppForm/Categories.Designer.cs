namespace CafePos.AppForm
{
    partial class Categories
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
            panelContent = new Panel();
            panelForm = new Panel();
            labelName = new Label();
            textBoxName = new TextBox();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            panelGrid = new Panel();
            labelUnits = new Label();
            labelCount = new Label();
            textBoxSearch = new TextBox();
            dataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panelContent.SuspendLayout();
            panelForm.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(243, 244, 246);
            panelContent.Controls.Add(panelForm);
            panelContent.Controls.Add(panelGrid);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.Size = new Size(1566, 823);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint_1;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(labelName);
            panelForm.Controls.Add(textBoxName);
            panelForm.Controls.Add(buttonSave);
            panelForm.Controls.Add(buttonUpdate);
            panelForm.Controls.Add(buttonClear);
            panelForm.Location = new Point(24, 24);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1518, 116);
            panelForm.TabIndex = 0;
            panelForm.Paint += panelForm_Paint;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelName.ForeColor = Color.FromArgb(55, 65, 81);
            labelName.Location = new Point(20, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(152, 23);
            labelName.TabIndex = 0;
            labelName.Text = "CATEGORY NAME";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(20, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(950, 34);
            textBoxName.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 163, 74);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(990, 42);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 38);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "ADD UNIT";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
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
            buttonUpdate.Location = new Point(1130, 42);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(130, 38);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClear.BackColor = Color.FromArgb(229, 231, 235);
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonClear.ForeColor = Color.FromArgb(55, 65, 81);
            buttonClear.Location = new Point(1270, 42);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(130, 38);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(labelUnits);
            panelGrid.Controls.Add(labelCount);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Location = new Point(24, 154);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1518, 643);
            panelGrid.TabIndex = 1;
            panelGrid.Paint += panelGrid_Paint;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUnits.ForeColor = Color.FromArgb(31, 41, 55);
            labelUnits.Location = new Point(18, 18);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(159, 28);
            labelUnits.TabIndex = 0;
            labelUnits.Text = "CATEGORY LIST";
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.ForeColor = Color.FromArgb(107, 114, 128);
            labelCount.Location = new Point(1120, 20);
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
            textBoxSearch.Location = new Point(1290, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(205, 30);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
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
            dataGridView.Size = new Size(1477, 566);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick_1;
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
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(panelContent);
            Name = "Categories";
            Size = new Size(1566, 823);
            Load += Categories_Load;
            panelContent.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContent;
        private Panel panelForm;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonClear;
        private Panel panelGrid;
        private Label labelUnits;
        private Label labelCount;
        private TextBox textBoxSearch;
        private DataGridView dataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}  