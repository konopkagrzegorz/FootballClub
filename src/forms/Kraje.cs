using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClub
{
    public partial class Kraje : Form
    {
        public Kraje()
        {
            InitializeComponent();
        }

        private void Kraje_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'football_clubsDataSet.Nations' . Możesz go przenieść lub usunąć.
            this.nationsTableAdapter.Fill(this.football_clubsDataSet.Nations);

        }

        private void CountryUpdateButton_Click(object sender, EventArgs e)
        {
            if (CountryDataGridView.CurrentRow != null)
            {
                nationsTableAdapter.Update(football_clubsDataSet.Nations);
            }
        }

        private void CountryRemoveButton_Click(object sender, EventArgs e)
        {
            if (CountryDataGridView.CurrentRow != null)
            {
                CountryDataGridView.CurrentRow.Selected = true;
                CountryDataGridView.Rows.Remove(CountryDataGridView.SelectedRows[0]);
                nationsTableAdapter.Update(football_clubsDataSet.Nations);
            }
        }
    }
}
