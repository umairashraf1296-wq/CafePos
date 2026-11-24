
namespace CafePos.AppForm
{
    partial class SupplierLedger
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierLedger));
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            dataGridViewSaleSummery = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaleSummery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(343, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(225, 37);
            label1.TabIndex = 2;
            label1.Text = "Vendor Accounts";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(12, 57);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(173, 28);
            label8.TabIndex = 67;
            label8.Text = "Supplier / Vendor";
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(12, 91);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(848, 37);
            comboBox1.TabIndex = 66;
            // 
            // dataGridViewSaleSummery
            // 
            dataGridViewSaleSummery.AllowUserToAddRows = false;
            dataGridViewSaleSummery.AllowUserToDeleteRows = false;
            dataGridViewSaleSummery.AllowUserToResizeColumns = false;
            dataGridViewSaleSummery.AllowUserToResizeRows = false;
            dataGridViewSaleSummery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSaleSummery.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewSaleSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaleSummery.Location = new System.Drawing.Point(14, 137);
            dataGridViewSaleSummery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewSaleSummery.Name = "dataGridViewSaleSummery";
            dataGridViewSaleSummery.RowHeadersWidth = 51;
            dataGridViewSaleSummery.RowTemplate.Height = 30;
            dataGridViewSaleSummery.RowTemplate.ReadOnly = true;
            dataGridViewSaleSummery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSaleSummery.Size = new System.Drawing.Size(890, 692);
            dataGridViewSaleSummery.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(535, 849);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 28);
            label2.TabIndex = 73;
            label2.Text = "Balance :-";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(643, 849);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(260, 27);
            textBox1.TabIndex = 72;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(866, 89);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(37, 39);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SupplierLedger
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(918, 889);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewSaleSummery);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SupplierLedger";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += SupplierLedger_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaleSummery).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewSaleSummery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}