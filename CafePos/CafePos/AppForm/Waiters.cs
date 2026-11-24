using CafePos.Models;
using System.ComponentModel;
using System.Data;

namespace CafePos.AppForm
{
    public partial class Waiters : UserControl
    {
        public string Getid { get; set; }
        private string SpName { get; set; }
        public Waiters()
        {
            InitializeComponent();
        }

        private void Waiters_Load(object sender, EventArgs e)
        {
            SpName = "SPWaiter";
            buttonSave.Text = "Save";
            Common.ConfigureGrid(dataGridView);
            Reset();
        }

        private async void Reset()
        {
            try
            {
                DataTable dataTable = await Common.GetDataTable(SpName);
                dataGridView.DataSource = dataTable;

                if (dataGridView.Columns.Contains("Id"))
                    dataGridView.Columns["Id"].Visible = false;

                PhoneNumbertext.Text = "";
                textBoxName.Text = "";
                textBoxSearch.Text = "";
                buttonSave.Enabled = true;
                buttonUpdate.Enabled = false;
                UpdateCount(dataTable.Rows.Count);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCount(int count)
        {
            labelCount.Text = count == 1 ? "1 WAITER" : $"{count} WAITERS";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty && PhoneNumbertext.Text != string.Empty)
                    GetExecuteNonQuery("Save");
                else
                    MessageBox.Show("Please Enter waiter Name Or Phone Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.CurrentRow.Selected = true;
                Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();

                textBoxName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                PhoneNumbertext.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                buttonSave.Enabled = false;
                buttonUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                goto End;
            }
        End:;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure  to update this recore?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (Getid != null)
                    {
                        if (textBoxName.Text != string.Empty && PhoneNumbertext.Text != string.Empty)
                            GetExecuteNonQuery("Update");
                        else
                            MessageBox.Show("Please enter missing text", "Warning");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GetExecuteNonQuery(string _Action)
        {
            var id = StoredProcedure.CreateParameter("@Id", Getid, "int");
            var Name = StoredProcedure.CreateParameter("@Name", textBoxName.Text, "string");
            var Contact = StoredProcedure.CreateParameter("@Contact", PhoneNumbertext.Text, "string");
            var Action = StoredProcedure.CreateParameter("@Action", _Action, "string");
            StoredProcedure.GetExecuteNonQuery(SpName, id, Name, Contact, Action);
            Reset();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this recore?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Getid = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    if (Getid != null)
                        GetExecuteNonQuery("Delete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            if (dataGridView.DataSource is not DataTable dataTable)
            {
                return;
            }

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Reset();
            textBoxName.Focus();
        }

        #region No Need 
        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion
    }
}
