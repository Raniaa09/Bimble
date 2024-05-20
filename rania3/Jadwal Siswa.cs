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
    public partial class Jadwal_Siswa : Form
    {
        public Jadwal_Siswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard_siswa form = new Dashboard_siswa();
            form.ShowDialog();
        }
    }
}
