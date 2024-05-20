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
    public partial class Data_Paket_Bimbel : Form
    {
        public Data_Paket_Bimbel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master_Data form = new Master_Data();
            form.Show();
        }
    }
}
