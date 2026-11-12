using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class ItemStock : UserControl
    {
        private readonly PrintDocument printDocument = new();
        private readonly PrintPreviewDialog printPreviewDialog = new();
        private int printRowIndex;

        public ItemStock()
        {
            InitializeComponent();
            panelHeader.Show();
            printDocument.DocumentName = "Ingredients Stock";
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.StartPosition = FormStartPosition.CenterScreen;
            printPreviewDialog.ClientSize = new Size(900, 650);
        }

        private void ItemStock_Load(object sender, EventArgs e)
        {
            labelSubtitle.Visible = true;
            Common.ConfigureGrid(dataGridView);
            Display();
        }

        private async void Display()
        {
            try
            {
                DataTable dataTable = await Common.GetDataTable("SpItemStock");
                dataGridView.DataSource = dataTable;
                UpdateCount(dataTable.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable)
            {
                return;
            }

            string searchText = textBoxSearch.Text.Trim().Replace("'", "''");
            dataTable.DefaultView.RowFilter = string.IsNullOrEmpty(searchText)
                ? string.Empty
                : string.Join(" OR ", dataTable.Columns.Cast<DataColumn>()
                    .Select(column => $"CONVERT([{column.ColumnName}], 'System.String') LIKE '%{searchText}%'"));

            UpdateCount(dataTable.DefaultView.Count);
        }

        private void UpdateCount(int count)
        {
            labelCount.Text = count == 1 ? "1 STOCK ITEM" : $"{count} STOCK ITEMS";
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable ||
                dataTable.DefaultView.Count == 0)
            {
                MessageBox.Show("There are no stock items to print.", "Print Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            printRowIndex = 0;
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            printPreviewDialog.ShowDialog(this.FindForm());
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable || e.Graphics == null)
            {
                e.HasMorePages = false;
                return;
            }

            DataView rows = dataTable.DefaultView;
            float left = e.MarginBounds.Left;
            float top = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;

            using Font titleFont = new("Segoe UI", 16F, FontStyle.Bold);
            using Font subtitleFont = new("Segoe UI", 9F);
            using Font headerFont = new("Segoe UI", 9F, FontStyle.Bold);
            using Font cellFont = new("Segoe UI", 9F);
            using Brush textBrush = new SolidBrush(Color.Black);
            using Brush headerBrush = new SolidBrush(Color.FromArgb(31, 41, 55));
            using Pen gridPen = new(Color.FromArgb(180, 180, 180));

            e.Graphics.DrawString("Ingredients Stock", titleFont, textBrush, left, top);
            e.Graphics.DrawString($"Printed: {DateTime.Now:dd MMM yyyy, hh:mm tt}",
                subtitleFont, textBrush, left, top + 28);
            e.Graphics.DrawString($"{rows.Count} stock item(s)",
                subtitleFont, textBrush, left + width - 150, top + 28);

            float rowTop = top + 58;
            float rowHeight = 34;
            float columnWidth = width / Math.Max(1, dataTable.Columns.Count);

            for (int columnIndex = 0; columnIndex < dataTable.Columns.Count; columnIndex++)
            {
                float columnLeft = left + columnIndex * columnWidth;
                e.Graphics.FillRectangle(headerBrush, columnLeft, rowTop, columnWidth, rowHeight);
                string header = dataTable.Columns[columnIndex].ColumnName;
                RectangleF headerRect = new(columnLeft + 4, rowTop + 7,
                    columnWidth - 8, rowHeight - 8);
                e.Graphics.DrawString(header, headerFont, Brushes.White, headerRect);
            }

            rowTop += rowHeight;

            while (printRowIndex < rows.Count)
            {
                if (rowTop + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                DataRowView row = rows[printRowIndex];
                for (int columnIndex = 0; columnIndex < dataTable.Columns.Count; columnIndex++)
                {
                    float columnLeft = left + columnIndex * columnWidth;
                    RectangleF cellRect = new(columnLeft + 4, rowTop + 7,
                        columnWidth - 8, rowHeight - 8);
                    e.Graphics.DrawString(Convert.ToString(row[columnIndex]) ?? string.Empty,
                        cellFont, textBrush, cellRect);
                    e.Graphics.DrawRectangle(gridPen, columnLeft, rowTop, columnWidth, rowHeight);
                }

                rowTop += rowHeight;
                printRowIndex++;
            }

            e.HasMorePages = false;
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            using LinearGradientBrush brush = new(panelContent.ClientRectangle,
                Color.FromArgb(243, 244, 246),
                Color.FromArgb(229, 231, 235),
                LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, panelContent.ClientRectangle);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            using LinearGradientBrush headerBrush = new(panelHeader.ClientRectangle,
                Color.FromArgb(17, 24, 39),
                Color.FromArgb(31, 41, 55),
                LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(headerBrush, panelHeader.ClientRectangle);

            using Pen accentPen = new(Color.FromArgb(59, 130, 246), 1f);
            e.Graphics.DrawLine(accentPen, 0, panelHeader.Height - 1, panelHeader.Width, panelHeader.Height - 1);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
