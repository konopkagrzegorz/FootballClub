using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClub
{
    public partial class Pilkarze : Form
    {
        public Pilkarze()
        {
            InitializeComponent();
        }

        private void Pilkarze_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'football_clubsDataSet.Nations' . Możesz go przenieść lub usunąć.
            this.nationsTableAdapter.Fill(this.football_clubsDataSet.Nations);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'football_clubsDataSet.Clubs' . Możesz go przenieść lub usunąć.
            this.clubsTableAdapter.Fill(this.football_clubsDataSet.Clubs);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'football_clubsDataSet.Players' . Możesz go przenieść lub usunąć.
            this.playersTableAdapter.Fill(this.football_clubsDataSet.Players);
        }

        private void PlayerReadImageButton_Click(object sender, EventArgs e)
        {
            var filter = new OpenFileDialog { Filter = "Image Files(*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif" };
            var filepath = "";
            if (filter.ShowDialog() == DialogResult.OK)
                filepath = filter.FileName;
            var id = PlayersDataGridView.CurrentRow.Cells[0].Value.ToString();
            DataRow dr = football_clubsDataSet.Players.Select("player_id=" + id).FirstOrDefault();
            if (filepath != null)
                dr["player_image"] = ImageToByte(filepath);
        }


        public static byte[] ImageToByte(string filePath)
        {
            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(stream);
            var photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return photo;
        }

        private void PlayerUpdateButton_Click(object sender, EventArgs e)
        {
            if (PlayersDataGridView.CurrentRow != null)
            {
                playersTableAdapter.Update(football_clubsDataSet.Players);
            }
        }

        private void PlayerDeleteButton_Click(object sender, EventArgs e)
        {
            if (PlayersDataGridView.CurrentRow != null)
            {
                PlayersDataGridView.CurrentRow.Selected = true;
                PlayersDataGridView.Rows.Remove(PlayersDataGridView.SelectedRows[0]);
                playersTableAdapter.Update(football_clubsDataSet.Players);
            }
        }
    }
}
