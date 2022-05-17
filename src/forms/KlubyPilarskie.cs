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
    public partial class KlubyPilarskie : Form
    {
        public KlubyPilarskie()
        {
            InitializeComponent();
        }

        private void KlubyPilarskie_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'football_clubsDataSet.Nations' . Możesz go przenieść lub usunąć.
            this.nationsTableAdapter.Fill(this.football_clubsDataSet.Nations);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'football_clubsDataSet.Clubs' . Możesz go przenieść lub usunąć.
            this.clubsTableAdapter.Fill(this.football_clubsDataSet.Clubs);

        }

        private void CountryDeleteButton_Click(object sender, EventArgs e)
        {
            if (ClubsDataGridView.CurrentRow != null)
            {
                ClubsDataGridView.CurrentRow.Selected = true;
                ClubsDataGridView.Rows.Remove(ClubsDataGridView.SelectedRows[0]);
                clubsTableAdapter.Update(football_clubsDataSet.Clubs);
            }
        }

        private void CountryUpdateButton_Click(object sender, EventArgs e)
        {
            if (ClubsDataGridView.CurrentRow != null)
            {
                clubsTableAdapter.Update(football_clubsDataSet.Clubs);
            }
        }
    }
}
