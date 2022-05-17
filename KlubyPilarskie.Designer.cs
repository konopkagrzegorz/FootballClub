namespace FootballClub
{
    partial class KlubyPilarskie
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
            this.CountryDeleteButton = new System.Windows.Forms.Button();
            this.CountryUpdateButton = new System.Windows.Forms.Button();
            this.ClubCountryTextBox = new System.Windows.Forms.TextBox();
            this.nationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.football_clubsDataSet = new FootbalClub.football_clubsDataSet();
            this.CountryLabelName = new System.Windows.Forms.Label();
            this.ClubNameTextBox = new System.Windows.Forms.TextBox();
            this.clubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountyClubNameLabel = new System.Windows.Forms.Label();
            this.ClubBirthTextBox = new System.Windows.Forms.TextBox();
            this.CountryBirthLabel = new System.Windows.Forms.Label();
            this.ClubCeoTextBox = new System.Windows.Forms.TextBox();
            this.ClubCeoNameLabel = new System.Windows.Forms.Label();
            this.ClubsDataGridView = new System.Windows.Forms.DataGridView();
            this.clubidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clubnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubcreationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubceonameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubsTableAdapter = new FootbalClub.football_clubsDataSetTableAdapters.ClubsTableAdapter();
            this.nationsTableAdapter = new FootbalClub.football_clubsDataSetTableAdapters.NationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_clubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryDeleteButton
            // 
            this.CountryDeleteButton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryDeleteButton.Location = new System.Drawing.Point(807, 383);
            this.CountryDeleteButton.Name = "CountryDeleteButton";
            this.CountryDeleteButton.Size = new System.Drawing.Size(125, 55);
            this.CountryDeleteButton.TabIndex = 8;
            this.CountryDeleteButton.Text = "Usuń";
            this.CountryDeleteButton.UseVisualStyleBackColor = true;
            this.CountryDeleteButton.Click += new System.EventHandler(this.CountryDeleteButton_Click);
            // 
            // CountryUpdateButton
            // 
            this.CountryUpdateButton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryUpdateButton.Location = new System.Drawing.Point(602, 382);
            this.CountryUpdateButton.Name = "CountryUpdateButton";
            this.CountryUpdateButton.Size = new System.Drawing.Size(145, 55);
            this.CountryUpdateButton.TabIndex = 7;
            this.CountryUpdateButton.Text = "Zaktualizuj";
            this.CountryUpdateButton.UseVisualStyleBackColor = true;
            this.CountryUpdateButton.Click += new System.EventHandler(this.CountryUpdateButton_Click);
            // 
            // ClubCountryTextBox
            // 
            this.ClubCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.ClubCountryTextBox.Location = new System.Drawing.Point(775, 18);
            this.ClubCountryTextBox.Name = "ClubCountryTextBox";
            this.ClubCountryTextBox.Size = new System.Drawing.Size(157, 20);
            this.ClubCountryTextBox.TabIndex = 10;
            // 
            // nationsBindingSource
            // 
            this.nationsBindingSource.DataMember = "Nations";
            this.nationsBindingSource.DataSource = this.football_clubsDataSet;
            // 
            // football_clubsDataSet
            // 
            this.football_clubsDataSet.DataSetName = "football_clubsDataSet";
            this.football_clubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CountryLabelName
            // 
            this.CountryLabelName.AutoSize = true;
            this.CountryLabelName.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryLabelName.Location = new System.Drawing.Point(566, 12);
            this.CountryLabelName.Name = "CountryLabelName";
            this.CountryLabelName.Size = new System.Drawing.Size(181, 25);
            this.CountryLabelName.TabIndex = 9;
            this.CountryLabelName.Text = "Nazwa kraju: ";
            // 
            // ClubNameTextBox
            // 
            this.ClubNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubsBindingSource, "club_name", true));
            this.ClubNameTextBox.Location = new System.Drawing.Point(775, 64);
            this.ClubNameTextBox.Name = "ClubNameTextBox";
            this.ClubNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.ClubNameTextBox.TabIndex = 12;
            // 
            // clubsBindingSource
            // 
            this.clubsBindingSource.DataMember = "Clubs";
            this.clubsBindingSource.DataSource = this.football_clubsDataSet;
            // 
            // CountyClubNameLabel
            // 
            this.CountyClubNameLabel.AutoSize = true;
            this.CountyClubNameLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountyClubNameLabel.Location = new System.Drawing.Point(566, 58);
            this.CountyClubNameLabel.Name = "CountyClubNameLabel";
            this.CountyClubNameLabel.Size = new System.Drawing.Size(168, 25);
            this.CountyClubNameLabel.TabIndex = 11;
            this.CountyClubNameLabel.Text = "Nazwa klubu:";
            // 
            // ClubBirthTextBox
            // 
            this.ClubBirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubsBindingSource, "club_creation_date", true));
            this.ClubBirthTextBox.Location = new System.Drawing.Point(775, 110);
            this.ClubBirthTextBox.Name = "ClubBirthTextBox";
            this.ClubBirthTextBox.Size = new System.Drawing.Size(157, 20);
            this.ClubBirthTextBox.TabIndex = 14;
            // 
            // CountryBirthLabel
            // 
            this.CountryBirthLabel.AutoSize = true;
            this.CountryBirthLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryBirthLabel.Location = new System.Drawing.Point(566, 104);
            this.CountryBirthLabel.Name = "CountryBirthLabel";
            this.CountryBirthLabel.Size = new System.Drawing.Size(220, 25);
            this.CountryBirthLabel.TabIndex = 13;
            this.CountryBirthLabel.Text = "Data utworzenia:";
            // 
            // ClubCeoTextBox
            // 
            this.ClubCeoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clubsBindingSource, "club_ceo_name", true));
            this.ClubCeoTextBox.Location = new System.Drawing.Point(775, 158);
            this.ClubCeoTextBox.Name = "ClubCeoTextBox";
            this.ClubCeoTextBox.Size = new System.Drawing.Size(157, 20);
            this.ClubCeoTextBox.TabIndex = 16;
            // 
            // ClubCeoNameLabel
            // 
            this.ClubCeoNameLabel.AutoSize = true;
            this.ClubCeoNameLabel.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClubCeoNameLabel.Location = new System.Drawing.Point(566, 152);
            this.ClubCeoNameLabel.Name = "ClubCeoNameLabel";
            this.ClubCeoNameLabel.Size = new System.Drawing.Size(103, 25);
            this.ClubCeoNameLabel.TabIndex = 15;
            this.ClubCeoNameLabel.Text = "Prezes:";
            // 
            // ClubsDataGridView
            // 
            this.ClubsDataGridView.AutoGenerateColumns = false;
            this.ClubsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClubsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubidDataGridViewTextBoxColumn,
            this.nationidDataGridViewTextBoxColumn,
            this.clubnameDataGridViewTextBoxColumn,
            this.clubcreationdateDataGridViewTextBoxColumn,
            this.clubceonameDataGridViewTextBoxColumn});
            this.ClubsDataGridView.DataSource = this.clubsBindingSource;
            this.ClubsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ClubsDataGridView.Name = "ClubsDataGridView";
            this.ClubsDataGridView.Size = new System.Drawing.Size(537, 425);
            this.ClubsDataGridView.TabIndex = 0;
            // 
            // clubidDataGridViewTextBoxColumn
            // 
            this.clubidDataGridViewTextBoxColumn.DataPropertyName = "club_id";
            this.clubidDataGridViewTextBoxColumn.HeaderText = "club_id";
            this.clubidDataGridViewTextBoxColumn.Name = "clubidDataGridViewTextBoxColumn";
            this.clubidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationidDataGridViewTextBoxColumn
            // 
            this.nationidDataGridViewTextBoxColumn.DataPropertyName = "nation_id";
            this.nationidDataGridViewTextBoxColumn.DataSource = this.nationsBindingSource;
            this.nationidDataGridViewTextBoxColumn.DisplayMember = "nation_name";
            this.nationidDataGridViewTextBoxColumn.HeaderText = "Kraj";
            this.nationidDataGridViewTextBoxColumn.Name = "nationidDataGridViewTextBoxColumn";
            this.nationidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nationidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nationidDataGridViewTextBoxColumn.ValueMember = "nation_id";
            this.nationidDataGridViewTextBoxColumn.Width = 120;
            // 
            // clubnameDataGridViewTextBoxColumn
            // 
            this.clubnameDataGridViewTextBoxColumn.DataPropertyName = "club_name";
            this.clubnameDataGridViewTextBoxColumn.HeaderText = "Nazwa klubu";
            this.clubnameDataGridViewTextBoxColumn.Name = "clubnameDataGridViewTextBoxColumn";
            this.clubnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // clubcreationdateDataGridViewTextBoxColumn
            // 
            this.clubcreationdateDataGridViewTextBoxColumn.DataPropertyName = "club_creation_date";
            this.clubcreationdateDataGridViewTextBoxColumn.HeaderText = "Data utworzenia";
            this.clubcreationdateDataGridViewTextBoxColumn.Name = "clubcreationdateDataGridViewTextBoxColumn";
            // 
            // clubceonameDataGridViewTextBoxColumn
            // 
            this.clubceonameDataGridViewTextBoxColumn.DataPropertyName = "club_ceo_name";
            this.clubceonameDataGridViewTextBoxColumn.HeaderText = "Prezes";
            this.clubceonameDataGridViewTextBoxColumn.Name = "clubceonameDataGridViewTextBoxColumn";
            this.clubceonameDataGridViewTextBoxColumn.Width = 120;
            // 
            // clubsTableAdapter
            // 
            this.clubsTableAdapter.ClearBeforeFill = true;
            // 
            // nationsTableAdapter
            // 
            this.nationsTableAdapter.ClearBeforeFill = true;
            // 
            // KlubyPilarskie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 451);
            this.Controls.Add(this.ClubCeoTextBox);
            this.Controls.Add(this.ClubCeoNameLabel);
            this.Controls.Add(this.ClubBirthTextBox);
            this.Controls.Add(this.CountryBirthLabel);
            this.Controls.Add(this.ClubNameTextBox);
            this.Controls.Add(this.CountyClubNameLabel);
            this.Controls.Add(this.ClubCountryTextBox);
            this.Controls.Add(this.CountryLabelName);
            this.Controls.Add(this.CountryDeleteButton);
            this.Controls.Add(this.CountryUpdateButton);
            this.Controls.Add(this.ClubsDataGridView);
            this.Name = "KlubyPilarskie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KlubyPilarskie";
            this.Load += new System.EventHandler(this.KlubyPilarskie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_clubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CountryDeleteButton;
        private System.Windows.Forms.Button CountryUpdateButton;
        private System.Windows.Forms.TextBox ClubCountryTextBox;
        private System.Windows.Forms.Label CountryLabelName;
        private System.Windows.Forms.TextBox ClubNameTextBox;
        private System.Windows.Forms.Label CountyClubNameLabel;
        private System.Windows.Forms.TextBox ClubBirthTextBox;
        private System.Windows.Forms.Label CountryBirthLabel;
        private System.Windows.Forms.TextBox ClubCeoTextBox;
        private System.Windows.Forms.Label ClubCeoNameLabel;
        private System.Windows.Forms.DataGridView ClubsDataGridView;
        private FootbalClub.football_clubsDataSet football_clubsDataSet;
        private System.Windows.Forms.BindingSource clubsBindingSource;
        private FootbalClub.football_clubsDataSetTableAdapters.ClubsTableAdapter clubsTableAdapter;
        private System.Windows.Forms.BindingSource nationsBindingSource;
        private FootbalClub.football_clubsDataSetTableAdapters.NationsTableAdapter nationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubcreationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubceonameDataGridViewTextBoxColumn;
    }
}