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
    public partial class Dashboard_siswa : Form
    {
        public Dashboard_siswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Angsuran_Siswa form = new Angsuran_Siswa();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jadwal_Siswa form = new Jadwal_Siswa();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this .Hide();
            Login_rania form = new Login_rania();
            form.ShowDialog();
        }
    }
}
