using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClub
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KlubyPilarskie Kluby = new KlubyPilarskie();
            Kluby.MdiParent = this;
            Kluby.Show();
        }

        private void krajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kraje Kraje = new Kraje();
            Kraje.MdiParent = this;
            Kraje.Show();
        }

        private void piłkarzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pilkarze Pilkarze = new Pilkarze();
            Pilkarze.MdiParent = this;
            Pilkarze.Show();
        }
    }
}
