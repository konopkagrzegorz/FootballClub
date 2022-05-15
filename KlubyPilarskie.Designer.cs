namespace FootbalClub
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
            this.footbal_clubsDataSet = new FootbalClub.footbal_clubsDataSet();
            this.clubsTableAdapter = new FootbalClub.footbal_clubsDataSetTableAdapters.ClubsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new FootbalClub.footbal_clubsDataSetTableAdapters.PlayersTableAdapter();
            this.nationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationsTableAdapter = new FootbalClub.footbal_clubsDataSetTableAdapters.NationsTableAdapter();
            this.nationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clubidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clubnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubcreationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubceonameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CountryLabelName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footbal_clubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // footbal_clubsDataSet
            // 
            this.footbal_clubsDataSet.DataSetName = "footbal_clubsDataSet";
            this.footbal_clubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubsTableAdapter
            // 
            this.clubsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubidDataGridViewTextBoxColumn,
            this.nationidDataGridViewTextBoxColumn,
            this.clubnameDataGridViewTextBoxColumn,
            this.clubcreationdateDataGridViewTextBoxColumn,
            this.clubceonameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clubsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // clubsBindingSource
            // 
            this.clubsBindingSource.DataMember = "Clubs";
            this.clubsBindingSource.DataSource = this.footbal_clubsDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // nationsBindingSource
            // 
            this.nationsBindingSource.DataMember = "Nations";
            this.nationsBindingSource.DataSource = this.footbal_clubsDataSet;
            // 
            // nationsTableAdapter
            // 
            this.nationsTableAdapter.ClearBeforeFill = true;
            // 
            // nationsBindingSource1
            // 
            this.nationsBindingSource1.DataMember = "Nations";
            this.nationsBindingSource1.DataSource = this.footbal_clubsDataSet;
            // 
            // clubidDataGridViewTextBoxColumn
            // 
            this.clubidDataGridViewTextBoxColumn.DataPropertyName = "club_id";
            this.clubidDataGridViewTextBoxColumn.HeaderText = "club_id";
            this.clubidDataGridViewTextBoxColumn.Name = "clubidDataGridViewTextBoxColumn";
            this.clubidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clubidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationidDataGridViewTextBoxColumn
            // 
            this.nationidDataGridViewTextBoxColumn.DataPropertyName = "nation_id";
            this.nationidDataGridViewTextBoxColumn.DataSource = this.nationsBindingSource1;
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
            this.clubnameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.clubnameDataGridViewTextBoxColumn.Name = "clubnameDataGridViewTextBoxColumn";
            this.clubnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // clubcreationdateDataGridViewTextBoxColumn
            // 
            this.clubcreationdateDataGridViewTextBoxColumn.DataPropertyName = "club_creation_date";
            this.clubcreationdateDataGridViewTextBoxColumn.HeaderText = "Data utworzenia";
            this.clubcreationdateDataGridViewTextBoxColumn.Name = "clubcreationdateDataGridViewTextBoxColumn";
            this.clubcreationdateDataGridViewTextBoxColumn.Width = 80;
            // 
            // clubceonameDataGridViewTextBoxColumn
            // 
            this.clubceonameDataGridViewTextBoxColumn.DataPropertyName = "club_ceo_name";
            this.clubceonameDataGridViewTextBoxColumn.HeaderText = "Prezes";
            this.clubceonameDataGridViewTextBoxColumn.Name = "clubceonameDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(714, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(563, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zaktualizuj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(483, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.textBox1.Location = new System.Drawing.Point(674, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 10;
            // 
            // CountryLabelName
            // 
            this.CountryLabelName.AutoSize = true;
            this.CountryLabelName.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CountryLabelName.Location = new System.Drawing.Point(478, 12);
            this.CountryLabelName.Name = "CountryLabelName";
            this.CountryLabelName.Size = new System.Drawing.Size(181, 25);
            this.CountryLabelName.TabIndex = 9;
            this.CountryLabelName.Text = "Nazwa kraju: ";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.textBox2.Location = new System.Drawing.Point(674, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(478, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nazwa kraju: ";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.textBox3.Location = new System.Drawing.Point(674, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(478, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nazwa kraju: ";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.textBox4.Location = new System.Drawing.Point(674, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(478, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nazwa kraju: ";
            // 
            // KlubyPilarskie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CountryLabelName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlubyPilarskie";
            this.Text = "KlubyPilarskie";
            this.Load += new System.EventHandler(this.KlubyPilarskie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footbal_clubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private footbal_clubsDataSet footbal_clubsDataSet;
        private footbal_clubsDataSetTableAdapters.ClubsTableAdapter clubsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clubsBindingSource;
        private footbal_clubsDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource nationsBindingSource;
        private footbal_clubsDataSetTableAdapters.NationsTableAdapter nationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nationsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubcreationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubceonameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CountryLabelName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
    }
}