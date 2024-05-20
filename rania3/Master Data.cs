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
    public partial class Master_Data : Form
    {
        public Master_Data()
        {
            InitializeComponent();
        }

        private void Master_Data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Admin form = new Data_Admin();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Guru form = new Data_Guru();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Siswa form = new Data_Siswa();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Kelas form = new Data_Kelas(); 
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Paket_Bimbel form = new Data_Paket_Bimbel();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_rania form = new Login_rania();
            form.ShowDialog();
        }
    }
}
