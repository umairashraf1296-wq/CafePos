using System.Data;
using CafePos.Models;

namespace CafePos.AppForm
{
    public partial class Supplier : UserControl
    {
        private string Getid { get; set; }
        public Supplier()
        {
            InitializeComponent();
            Getid = "";
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Common.ConfigureGrid(dataGridView);
            Reset();
            Common.SetButtonName(buttonSave, buttonUpdate, buttonClear);
        }

        private async void Reset()
        {
            dataGridView.ClearSelection();
            Getid = string.Empty;
            textBoxSearch.Text = "";
            textBoxName.Text = "";
            PhoneNumbertext.Text = "";
            buttonUpdate.Enabled = false;
            buttonSave.Enabled = true;

            DataTable dataTable = await Common.GetDataTable("SPVendor");
            dataGridView.DataSource = dataTable;

            if (dataGridView.Columns.Contains("Id"))
                dataGridView.Columns["Id"].Visible = false;
            UpdateCount(dataTable.Rows.Count);

        }
        private void GetExecuteNonQuery(string _Action)
        {
            try
            {
                var Name = StoredProcedure.CreateParameter("@name", textBoxName.Text, "string");
                var Contact = StoredProcedure.CreateParameter("@contact", PhoneNumbertext.Text, "string");
                var id = StoredProcedure.CreateParameter("@id", Getid, "int");
                var Action = StoredProcedure.CreateParameter("@Action", _Action, "string");

                if (_Action == "Save")
                    StoredProcedure.GetExecuteNonQuery("SPVendor", Name, Contact, Action);
                else if (_Action == "Update")
                    StoredProcedure.GetExecuteNonQuery("SPVendor", id, Name, Contact, Action);
                else if (_Action == "Delete")
                    StoredProcedure.GetExecuteNonQuery("SPVendor", Action, id);

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
                GetExecuteNonQuery("Save");
            else
                MessageBox.Show("Enter supplier Name", "Warning");
        }
        private void UpdateCount(int count)
        {
            labelCount.Text = count == 1 ? "1 SUPPLIER" : $"{count} SUPPLIERES";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.CurrentRow.Selected = true;
            Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            PhoneNumbertext.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure  to update this recore?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Getid != null && textBoxName.Text != string.Empty)
                    GetExecuteNonQuery("Update");
                else
                    MessageBox.Show("Please enter name or phone number", "Warning");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this recore?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (Getid != null)
                    GetExecuteNonQuery("Delete");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is not DataTable dataTable)
                return;

            string searchText = textBoxSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(searchText))
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string[] nameColumns = dataTable.Columns.Cast<DataColumn>()
                    .Where(column => column.DataType == typeof(string))
                    .Select(column => column.ColumnName)
                    .ToArray();

                dataTable.DefaultView.RowFilter = nameColumns.Length == 0
                    ? string.Empty
                    : string.Join(" OR ", nameColumns.Select(column =>
                        $"CONVERT([{column}], 'System.String') LIKE '%{searchText}%'"));
            }

            UpdateCount(dataTable.DefaultView.Count);
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}