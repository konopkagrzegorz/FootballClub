using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootbalClub
{
    public partial class Kraje : Form
    {
        public Kraje()
        {
            InitializeComponent();
        }

        private void Kraje_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'footbal_clubsDataSet.Nations' . Możesz go przenieść lub usunąć.
            this.nationsTableAdapter.Fill(this.footbal_clubsDataSet.Nations);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'footbal_clubsDataSet.Nations' . Możesz go przenieść lub usunąć.
            this.nationsTableAdapter.Fill(this.footbal_clubsDataSet.Nations);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nationsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
