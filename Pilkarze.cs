﻿using System;
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
    public partial class Pilkarze : Form
    {
        public Pilkarze()
        {
            InitializeComponent();
        }

        private void Pilkarze_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'footbal_clubsDataSet.Nations' . Możesz go przenieść lub usunąć.
            this.nationsTableAdapter.Fill(this.footbal_clubsDataSet.Nations);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'footbal_clubsDataSet.Clubs' . Możesz go przenieść lub usunąć.
            this.clubsTableAdapter.Fill(this.footbal_clubsDataSet.Clubs);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'footbal_clubsDataSet.Players' . Możesz go przenieść lub usunąć.
            this.playersTableAdapter.Fill(this.footbal_clubsDataSet.Players);

        }
    }
}
