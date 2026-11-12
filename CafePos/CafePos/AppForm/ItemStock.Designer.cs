using System.Windows.Forms;

namespace CafePos.AppForm
{
    partial class ItemStock
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
            labelCount = new Label();
            textBoxSearch = new TextBox();
            dataGridView = new DataGridView();
            labelUnits = new Label();
            buttonPrint = new Button();
            panelGrid = new Panel();
            panelContent = new Panel();
            labelSubtitle = new Label();
            labelTitle = new Label();
            panelHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelGrid.SuspendLayout();
            panelContent.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.ForeColor = Color.FromArgb(107, 114, 128);
            labelCount.Location = new Point(1040, 20);
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
            dataGridView.Location = new Point(18, 58);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 38;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1477, 488);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUnits.ForeColor = Color.FromArgb(31, 41, 55);
            labelUnits.Location = new Point(18, 18);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(119, 28);
            labelUnits.TabIndex = 0;
            labelUnits.Text = "STOCK LIST";
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
            buttonPrint.Click += buttonPrint_Click;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(labelUnits);
            panelGrid.Controls.Add(labelCount);
            panelGrid.Controls.Add(textBoxSearch);
            panelGrid.Controls.Add(buttonPrint);
            panelGrid.Controls.Add(dataGridView);
            panelGrid.Location = new Point(24, 24);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1518, 565);
            panelGrid.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(243, 244, 246);
            panelContent.Controls.Add(panelGrid);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 78);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.Size = new Size(1566, 745);
            panelContent.TabIndex = 3;
            panelContent.Paint += panelContent_Paint;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 9F);
            labelSubtitle.ForeColor = Color.FromArgb(209, 213, 219);
            labelSubtitle.Location = new Point(29, 48);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(386, 20);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "View current ingredient inventory and resolved quantities";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(26, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(265, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Ingredients Stock";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(31, 41, 55);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(labelSubtitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1566, 78);
            panelHeader.TabIndex = 4;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // ItemStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "ItemStock";
            Size = new Size(1566, 823);
            Load += ItemStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            panelContent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCount;
        private TextBox textBoxSearch;
        private DataGridView dataGridView;
        private Label labelUnits;
        private Button buttonPrint;
        private Panel panelGrid;
        private Panel panelContent;
        private Label labelSubtitle;
        private Label labelTitle;
        private Panel panelHeader;
    }
}
