using System.ComponentModel;
using System.Data;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace dfggfd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnPushData_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txbname.Text = selectedRow.Cells["NameColumn"].Value.ToString();
                textlast.Text = selectedRow.Cells["WaterBillColumn"].Value.ToString();
                txbphone.Text = selectedRow.Cells["PhoneColumn"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var totalBillValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value;

                if (totalBillValue != null)
                {
                    txtbill.Text = totalBillValue.ToString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txbname.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string waterbill = textlast.Text;
            if (string.IsNullOrEmpty(waterbill))
            {
                MessageBox.Show("Please enter your water bill", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phone = txbphone.Text;
            if (!int.TryParse(phone, out _))
            {
                MessageBox.Show("Please enter a valid phone number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            {
                double waterUsage = double.Parse(texthis.Text) - double.Parse(textlast.Text);
                ;

                double totalBill = waterUsage * 5793;

                MessageBox.Show($"Total Bill: {totalBill:C}");
                txtbill.Text = totalBill.ToString("C");
            }

            dataGridView1.Rows.Add(
                txbname.Text,
                textid.Text,
                ccbtype.Text,
                texthis.Text,
                textlast.Text,
                txbphone.Text
            );


            txbname.Clear();
            textlast.Clear();
            txbphone.Clear();
            textid.Clear();
            texthis.Clear();
            ccbtype.SelectedIndex = -1;


            txbname.Focus();

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);

            double consumption = double.Parse(texthis.Text) - double.Parse(textlast.Text);
            double total = 0;
            if (ccbtype.Text == "1. Household customer")
            {
                total = consumption * 5793;
            }
            else if (ccbtype.Text == "2. Administrative agency, public services")
            {
                total = consumption * 9955;
            }
            else if (ccbtype.Text == "3. Production units")
            {
                total = consumption * 11615;
            }
            else
            {
                total = consumption * 22068;
            }
            double vatAndFees = total * 0.1;
            int clmtt;
            newRow.Cells[3].Value = ccbtype.Text;
            newRow.Cells[4].Value = double.Parse(textlast.Text);
            newRow.Cells[5].Value = double.Parse(texthis.Text);
            newRow.Cells[7].Value = total + vatAndFees;

            dataGridView1.Rows.Add(newRow);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void textgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["ColumnName"], ListSortDirection.Ascending);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            SearchData();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

            }
        }

        private void textwaterbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void ccbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Do you want to delete?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please choose data to delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData();

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            SearchData();

        }

        private void SearchData()
        {
            string searchText = txtsearch.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool visible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        visible = true;
                        break;
                    }
                }

                row.Visible = visible;
            }
        }
    }
}

           

