using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnoneplayer_Click(object sender, EventArgs e)
        {
            Frm_OnePlayer frm = new Frm_OnePlayer();
            frm.Show();
            this.Hide();
        }

        private void btn2player_Click(object sender, EventArgs e)
        {
            Frm2Player frm = new Frm2Player();
            frm.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
