namespace FootballClub
{
    partial class Kraje
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
            this.CountryUpdateButton = new System.Windows.Forms.Button();
            this.CountryLabelName = new System.Windows.Forms.Label();
            this.CountryNameTextBox = new System.Windows.Forms.TextBox();
            this.CountryRemoveButton = new System.Windows.Forms.Button();
            this.CountryDataGridView = new System.Windows.Forms.DataGridView();
            this.football_clubsDataSet = new FootballClub.football_clubsDataSet();
            this.nationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationsTableAdapter = new FootballClub.football_clubsDataSetTableAdapters.NationsTableAdapter();
            this.dataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CountryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_clubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryUpdateButton
            // 
            this.CountryUpdateButton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryUpdateButton.Location = new System.Drawing.Point(471, 383);
            this.CountryUpdateButton.Name = "CountryUpdateButton";
            this.CountryUpdateButton.Size = new System.Drawing.Size(145, 55);
            this.CountryUpdateButton.TabIndex = 2;
            this.CountryUpdateButton.Text = "Zaktualizuj";
            this.CountryUpdateButton.UseVisualStyleBackColor = true;
            this.CountryUpdateButton.Click += new System.EventHandler(this.CountryUpdateButton_Click);
            // 
            // CountryLabelName
            // 
            this.CountryLabelName.AutoSize = true;
            this.CountryLabelName.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryLabelName.Location = new System.Drawing.Point(466, 12);
            this.CountryLabelName.Name = "CountryLabelName";
            this.CountryLabelName.Size = new System.Drawing.Size(181, 25);
            this.CountryLabelName.TabIndex = 3;
            this.CountryLabelName.Text = "Nazwa kraju: ";
            // 
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.CountryNameTextBox.Location = new System.Drawing.Point(662, 18);
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.CountryNameTextBox.TabIndex = 4;
            // 
            // CountryRemoveButton
            // 
            this.CountryRemoveButton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryRemoveButton.Location = new System.Drawing.Point(662, 382);
            this.CountryRemoveButton.Name = "CountryRemoveButton";
            this.CountryRemoveButton.Size = new System.Drawing.Size(125, 55);
            this.CountryRemoveButton.TabIndex = 5;
            this.CountryRemoveButton.Text = "Usuń";
            this.CountryRemoveButton.UseVisualStyleBackColor = true;
            this.CountryRemoveButton.Click += new System.EventHandler(this.CountryRemoveButton_Click);
            // 
            // CountryDataGridView
            // 
            this.CountryDataGridView.AutoGenerateColumns = false;
            this.CountryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn,
            this.nationnameDataGridViewTextBoxColumn});
            this.CountryDataGridView.DataSource = this.nationsBindingSource;
            this.CountryDataGridView.Location = new System.Drawing.Point(12, 12);
            this.CountryDataGridView.Name = "CountryDataGridView";
            this.CountryDataGridView.Size = new System.Drawing.Size(445, 425);
            this.CountryDataGridView.TabIndex = 6;
            // 
            // football_clubsDataSet
            // 
            this.football_clubsDataSet.DataSetName = "football_clubsDataSet";
            this.football_clubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nationsBindingSource
            // 
            this.nationsBindingSource.DataMember = "Nations";
            this.nationsBindingSource.DataSource = this.football_clubsDataSet;
            // 
            // nationsTableAdapter
            // 
            this.nationsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn
            // 
            this.dataGridViewTextBoxColumn.DataPropertyName = "nation_id";
            this.dataGridViewTextBoxColumn.HeaderText = "nation_id";
            this.dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn.ReadOnly = true;
            this.dataGridViewTextBoxColumn.Visible = false;
            // 
            // nationnameDataGridViewTextBoxColumn
            // 
            this.nationnameDataGridViewTextBoxColumn.DataPropertyName = "nation_name";
            this.nationnameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nationnameDataGridViewTextBoxColumn.Name = "nationnameDataGridViewTextBoxColumn";
            this.nationnameDataGridViewTextBoxColumn.Width = 380;
            // 
            // Kraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.CountryDataGridView);
            this.Controls.Add(this.CountryRemoveButton);
            this.Controls.Add(this.CountryNameTextBox);
            this.Controls.Add(this.CountryLabelName);
            this.Controls.Add(this.CountryUpdateButton);
            this.Name = "Kraje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kraje";
            this.Load += new System.EventHandler(this.Kraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_clubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CountryUpdateButton;
        private System.Windows.Forms.Label CountryLabelName;
        private System.Windows.Forms.TextBox CountryNameTextBox;
        private System.Windows.Forms.Button CountryRemoveButton;
        private System.Windows.Forms.DataGridView CountryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationidDataGridViewTextBoxColumn;
        private FootballClub.football_clubsDataSet football_clubsDataSet;
        private System.Windows.Forms.BindingSource nationsBindingSource;
        private FootballClub.football_clubsDataSetTableAdapters.NationsTableAdapter nationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationnameDataGridViewTextBoxColumn;
    }
}