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
    public partial class List_Data_Angsuran : Form
    {
        public List_Data_Angsuran()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kategori_Angsuran form = new Kategori_Angsuran();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form = new Dashboard();
            form.ShowDialog();
        }
    }
}
