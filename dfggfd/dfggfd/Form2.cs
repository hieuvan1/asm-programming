using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dfggfd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool CheckCredentials(string email, string password)
        {
            string validEmail = "vantrunghieu";
            string validPassword = "123";
            return email == validEmail && password == validPassword;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool Check(string email, string password)
        {
            if (email == this.textBox1.Text && password == this.textBox2.Text)
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string enteredEmail = textBox1.Text.Trim();
                string enteredPassword = textBox2.Text;

                if (!CheckCredentials(enteredEmail, enteredPassword))
                {
                    MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
