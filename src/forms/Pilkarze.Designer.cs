namespace FootballClub
{
    partial class Pilkarze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayersDataGridView = new System.Windows.Forms.DataGridView();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.football_clubsDataSet = new FootballClub.football_clubsDataSet();
            this.clubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerSurnameLabel = new System.Windows.Forms.Label();
            this.PlayerBirthLabel = new System.Windows.Forms.Label();
            this.PlayerClubLabel = new System.Windows.Forms.Label();
            this.PlayerCountryLabel = new System.Windows.Forms.Label();
            this.PlayerDeleteButton = new System.Windows.Forms.Button();
            this.PlayerUpdateButton = new System.Windows.Forms.Button();
            this.PlayerImageLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerReadImageButton = new System.Windows.Forms.Button();
            this.PlayerClubComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerCountryComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerBirthNumericDropdown = new System.Windows.Forms.NumericUpDown();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.playersTableAdapter = new FootballClub.football_clubsDataSetTableAdapters.PlayersTableAdapter();
            this.clubsTableAdapter = new FootballClub.football_clubsDataSetTableAdapters.ClubsTableAdapter();
            this.nationsTableAdapter = new FootballClub.football_clubsDataSetTableAdapters.NationsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_clubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBirthNumericDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersDataGridView
            // 
            this.PlayersDataGridView.AutoGenerateColumns = false;
            this.PlayersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.PlayersDataGridView.DataSource = this.playersBindingSource;
            this.PlayersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PlayersDataGridView.MultiSelect = false;
            this.PlayersDataGridView.Name = "PlayersDataGridView";
            this.PlayersDataGridView.Size = new System.Drawing.Size(645, 425);
            this.PlayersDataGridView.TabIndex = 24;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.football_clubsDataSet;
            // 
            // football_clubsDataSet
            // 
            this.football_clubsDataSet.DataSetName = "football_clubsDataSet";
            this.football_clubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubsBindingSource
            // 
            this.clubsBindingSource.DataMember = "Clubs";
            this.clubsBindingSource.DataSource = this.football_clubsDataSet;
            // 
            // nationsBindingSource
            // 
            this.nationsBindingSource.DataMember = "Nations";
            this.nationsBindingSource.DataSource = this.football_clubsDataSet;
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "player_name", true));
            this.PlayerNameTextBox.Location = new System.Drawing.Point(860, 18);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.PlayerNameTextBox.TabIndex = 6;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerNameLabel.Location = new System.Drawing.Point(664, 12);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(77, 25);
            this.PlayerNameLabel.TabIndex = 5;
            this.PlayerNameLabel.Text = "Imię:";
            // 
            // PlayerSurnameTextBox
            // 
            this.PlayerSurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "player_surname", true));
            this.PlayerSurnameTextBox.Location = new System.Drawing.Point(860, 64);
            this.PlayerSurnameTextBox.Name = "PlayerSurnameTextBox";
            this.PlayerSurnameTextBox.Size = new System.Drawing.Size(112, 20);
            this.PlayerSurnameTextBox.TabIndex = 8;
            // 
            // PlayerSurnameLabel
            // 
            this.PlayerSurnameLabel.AutoSize = true;
            this.PlayerSurnameLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerSurnameLabel.Location = new System.Drawing.Point(664, 58);
            this.PlayerSurnameLabel.Name = "PlayerSurnameLabel";
            this.PlayerSurnameLabel.Size = new System.Drawing.Size(129, 25);
            this.PlayerSurnameLabel.TabIndex = 7;
            this.PlayerSurnameLabel.Text = "Nazwisko:";
            // 
            // PlayerBirthLabel
            // 
            this.PlayerBirthLabel.AutoSize = true;
            this.PlayerBirthLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerBirthLabel.Location = new System.Drawing.Point(664, 99);
            this.PlayerBirthLabel.Name = "PlayerBirthLabel";
            this.PlayerBirthLabel.Size = new System.Drawing.Size(194, 25);
            this.PlayerBirthLabel.TabIndex = 9;
            this.PlayerBirthLabel.Text = "Rok urodzenia:";
            // 
            // PlayerClubLabel
            // 
            this.PlayerClubLabel.AutoSize = true;
            this.PlayerClubLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerClubLabel.Location = new System.Drawing.Point(664, 148);
            this.PlayerClubLabel.Name = "PlayerClubLabel";
            this.PlayerClubLabel.Size = new System.Drawing.Size(77, 25);
            this.PlayerClubLabel.TabIndex = 11;
            this.PlayerClubLabel.Text = "Klub:";
            // 
            // PlayerCountryLabel
            // 
            this.PlayerCountryLabel.AutoSize = true;
            this.PlayerCountryLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerCountryLabel.Location = new System.Drawing.Point(664, 192);
            this.PlayerCountryLabel.Name = "PlayerCountryLabel";
            this.PlayerCountryLabel.Size = new System.Drawing.Size(77, 25);
            this.PlayerCountryLabel.TabIndex = 13;
            this.PlayerCountryLabel.Text = "Kraj:";
            // 
            // PlayerDeleteButton
            // 
            this.PlayerDeleteButton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerDeleteButton.Location = new System.Drawing.Point(850, 383);
            this.PlayerDeleteButton.Name = "PlayerDeleteButton";
            this.PlayerDeleteButton.Size = new System.Drawing.Size(125, 55);
            this.PlayerDeleteButton.TabIndex = 17;
            this.PlayerDeleteButton.Text = "Usuń";
            this.PlayerDeleteButton.UseVisualStyleBackColor = true;
            this.PlayerDeleteButton.Click += new System.EventHandler(this.PlayerDeleteButton_Click);
            // 
            // PlayerUpdateButton
            // 
            this.PlayerUpdateButton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerUpdateButton.Location = new System.Drawing.Point(669, 383);
            this.PlayerUpdateButton.Name = "PlayerUpdateButton";
            this.PlayerUpdateButton.Size = new System.Drawing.Size(145, 55);
            this.PlayerUpdateButton.TabIndex = 16;
            this.PlayerUpdateButton.Text = "Zaktualizuj";
            this.PlayerUpdateButton.UseVisualStyleBackColor = true;
            this.PlayerUpdateButton.Click += new System.EventHandler(this.PlayerUpdateButton_Click);
            // 
            // PlayerImageLabel
            // 
            this.PlayerImageLabel.AutoSize = true;
            this.PlayerImageLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerImageLabel.Location = new System.Drawing.Point(664, 242);
            this.PlayerImageLabel.Name = "PlayerImageLabel";
            this.PlayerImageLabel.Size = new System.Drawing.Size(116, 25);
            this.PlayerImageLabel.TabIndex = 18;
            this.PlayerImageLabel.Text = "Zdjęcie:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.playersBindingSource, "player_image", true));
            this.pictureBox1.Location = new System.Drawing.Point(860, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerReadImageButton
            // 
            this.PlayerReadImageButton.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerReadImageButton.Location = new System.Drawing.Point(669, 326);
            this.PlayerReadImageButton.Name = "PlayerReadImageButton";
            this.PlayerReadImageButton.Size = new System.Drawing.Size(94, 29);
            this.PlayerReadImageButton.TabIndex = 20;
            this.PlayerReadImageButton.Text = "Wczytaj";
            this.PlayerReadImageButton.UseVisualStyleBackColor = true;
            this.PlayerReadImageButton.Click += new System.EventHandler(this.PlayerReadImageButton_Click);
            // 
            // PlayerClubComboBox
            // 
            this.PlayerClubComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubsBindingSource, "club_name", true));
            this.PlayerClubComboBox.DisplayMember = "nation_id";
            this.PlayerClubComboBox.FormattingEnabled = true;
            this.PlayerClubComboBox.Location = new System.Drawing.Point(860, 152);
            this.PlayerClubComboBox.Name = "PlayerClubComboBox";
            this.PlayerClubComboBox.Size = new System.Drawing.Size(112, 21);
            this.PlayerClubComboBox.TabIndex = 21;
            this.PlayerClubComboBox.ValueMember = "nation_id";
            // 
            // PlayerCountryComboBox
            // 
            this.PlayerCountryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.PlayerCountryComboBox.DisplayMember = "club_name";
            this.PlayerCountryComboBox.FormattingEnabled = true;
            this.PlayerCountryComboBox.Location = new System.Drawing.Point(860, 198);
            this.PlayerCountryComboBox.Name = "PlayerCountryComboBox";
            this.PlayerCountryComboBox.Size = new System.Drawing.Size(112, 21);
            this.PlayerCountryComboBox.TabIndex = 22;
            this.PlayerCountryComboBox.ValueMember = "club_id";
            // 
            // PlayerBirthNumericDropdown
            // 
            this.PlayerBirthNumericDropdown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playersBindingSource, "player_birthyear", true));
            this.PlayerBirthNumericDropdown.Location = new System.Drawing.Point(860, 103);
            this.PlayerBirthNumericDropdown.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.PlayerBirthNumericDropdown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.PlayerBirthNumericDropdown.Name = "PlayerBirthNumericDropdown";
            this.PlayerBirthNumericDropdown.Size = new System.Drawing.Size(112, 20);
            this.PlayerBirthNumericDropdown.TabIndex = 23;
            this.PlayerBirthNumericDropdown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.Size = new System.Drawing.Size(240, 150);
            this.PlayerDataGridView.TabIndex = 0;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // clubsTableAdapter
            // 
            this.clubsTableAdapter.ClearBeforeFill = true;
            // 
            // nationsTableAdapter
            // 
            this.nationsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "player_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "player_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "player_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "player_surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "player_birthyear";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rok urodzenia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "club_id";
            this.dataGridViewTextBoxColumn5.DataSource = this.clubsBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "club_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Klub";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "club_id";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nation_id";
            this.dataGridViewTextBoxColumn6.DataSource = this.nationsBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "nation_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kraj";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "nation_id";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "player_image";
            this.dataGridViewImageColumn1.HeaderText = "Zdjęcie";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Pilkarze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.Controls.Add(this.PlayerBirthNumericDropdown);
            this.Controls.Add(this.PlayerCountryComboBox);
            this.Controls.Add(this.PlayerClubComboBox);
            this.Controls.Add(this.PlayerReadImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayerImageLabel);
            this.Controls.Add(this.PlayerDeleteButton);
            this.Controls.Add(this.PlayerUpdateButton);
            this.Controls.Add(this.PlayerCountryLabel);
            this.Controls.Add(this.PlayerClubLabel);
            this.Controls.Add(this.PlayerBirthLabel);
            this.Controls.Add(this.PlayerSurnameTextBox);
            this.Controls.Add(this.PlayerSurnameLabel);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.PlayersDataGridView);
            this.Name = "Pilkarze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pilkarze";
            this.Load += new System.EventHandler(this.Pilkarze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_clubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBirthNumericDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayersDataGridView;
        //private football_clubsDataSetTableAdapters.NationsTableAdapter nationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerbirthyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clubidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn playerimageDataGridViewImageColumn;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.TextBox PlayerSurnameTextBox;
        private System.Windows.Forms.Label PlayerSurnameLabel;
        private System.Windows.Forms.Label PlayerBirthLabel;
        private System.Windows.Forms.Label PlayerClubLabel;
        private System.Windows.Forms.Label PlayerCountryLabel;
        private System.Windows.Forms.Button PlayerDeleteButton;
        private System.Windows.Forms.Button PlayerUpdateButton;
        private System.Windows.Forms.Label PlayerImageLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayerReadImageButton;
        private System.Windows.Forms.ComboBox PlayerClubComboBox;
        private System.Windows.Forms.ComboBox PlayerCountryComboBox;
        private System.Windows.Forms.NumericUpDown PlayerBirthNumericDropdown;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private FootballClub.football_clubsDataSet football_clubsDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private FootballClub.football_clubsDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource clubsBindingSource;
        private FootballClub.football_clubsDataSetTableAdapters.ClubsTableAdapter clubsTableAdapter;
        private System.Windows.Forms.BindingSource nationsBindingSource;
        private FootballClub.football_clubsDataSetTableAdapters.NationsTableAdapter nationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}