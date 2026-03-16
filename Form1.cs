using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crackme_overflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correct_user = "braNdon2";
            string correct_pass = "Leetcoder67";
            if (Usernamebox.Text == correct_user && Passwordbox.Text == correct_pass)
            {
                Form2 success = new Form2();
                success.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
