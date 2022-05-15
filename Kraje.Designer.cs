namespace FootbalClub
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.footbal_clubsDataSet = new FootbalClub.footbal_clubsDataSet();
            this.nationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationsTableAdapter = new FootbalClub.footbal_clubsDataSetTableAdapters.NationsTableAdapter();
            this.nationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CountryLabelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footbal_clubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nationnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // footbal_clubsDataSet
            // 
            this.footbal_clubsDataSet.DataSetName = "footbal_clubsDataSet";
            this.footbal_clubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // nationnameDataGridViewTextBoxColumn
            // 
            this.nationnameDataGridViewTextBoxColumn.DataPropertyName = "nation_name";
            this.nationnameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nationnameDataGridViewTextBoxColumn.Name = "nationnameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(483, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(563, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zaktualizuj";
            this.button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nationsBindingSource, "nation_name", true));
            this.textBox1.Location = new System.Drawing.Point(662, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(714, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Kraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CountryLabelName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kraje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kraje";
            this.Load += new System.EventHandler(this.Kraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footbal_clubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private footbal_clubsDataSet footbal_clubsDataSet;
        private System.Windows.Forms.BindingSource nationsBindingSource;
        private footbal_clubsDataSetTableAdapters.NationsTableAdapter nationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CountryLabelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}