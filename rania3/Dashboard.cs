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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master_Data master_Data = new Master_Data();
            master_Data.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jadwal_Pelajaran jadwal_Pelajaran = new Jadwal_Pelajaran(); 
            jadwal_Pelajaran.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anggota anggota = new Anggota();
            anggota.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_Data_Angsuran list_Data_Angsuran = new List_Data_Angsuran();
            list_Data_Angsuran.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_rania form = new Login_rania();
            form.ShowDialog();
        }
    }
}
