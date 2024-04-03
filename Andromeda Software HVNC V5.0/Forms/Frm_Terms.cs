using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Frm_Terms : Form
    {
        public Frm_Terms()
        {
            InitializeComponent();
        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Frm_Darshboard frm_Darshboard = new Frm_Darshboard();
            this.Hide();
            frm_Darshboard.ShowDialog();
        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
