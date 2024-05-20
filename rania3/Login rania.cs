using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rania3
{
    public partial class Login_rania : Form
    {
        public Login_rania()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {
                new Dashboard().Show();
                this.Hide();
            }
           else if (textBox1.Text == "User" && textBox2.Text == "456")
            {
               new Dashboard_siswa().Show();
                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_siswa form = new Dashboard_siswa();
            form.Show();
        }
    }
}
