namespace Zadaca_03
{
    partial class Manipulacija_podataka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manipulacija_podataka));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.osobnebilješkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdravstvenipodaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_msokser22_DBDataSet = new Zadaca_03.PI2324_msokser22_DBDataSet2();
            this.Promjeni = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.pI2324msokser22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zdravstveni_podaciTableAdapter = new Zadaca_03.PI2324_msokser22_DBDataSet2TableAdapters.Zdravstveni_podaciTableAdapter();
            this.Odustani = new System.Windows.Forms.Button();
            this.Pohrani = new System.Windows.Forms.Button();
            this.pI2324msokser22DBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravstvenipodaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_msokser22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324msokser22DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324msokser22DBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.osobnebilješkeDataGridViewTextBoxColumn,
            this.terminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zdravstvenipodaciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(258, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(504, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // osobnebilješkeDataGridViewTextBoxColumn
            // 
            this.osobnebilješkeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.osobnebilješkeDataGridViewTextBoxColumn.DataPropertyName = "Osobne_bilješke";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.osobnebilješkeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.osobnebilješkeDataGridViewTextBoxColumn.HeaderText = "Osobne bilješke";
            this.osobnebilješkeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.osobnebilješkeDataGridViewTextBoxColumn.Name = "osobnebilješkeDataGridViewTextBoxColumn";
            this.osobnebilješkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.osobnebilješkeDataGridViewTextBoxColumn.Width = 123;
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "Termin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.terminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.terminDataGridViewTextBoxColumn.HeaderText = "Termin";
            this.terminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminDataGridViewTextBoxColumn.Name = "terminDataGridViewTextBoxColumn";
            this.terminDataGridViewTextBoxColumn.ReadOnly = true;
            this.terminDataGridViewTextBoxColumn.Width = 78;
            // 
            // zdravstvenipodaciBindingSource
            // 
            this.zdravstvenipodaciBindingSource.DataMember = "Zdravstveni_podaci";
            this.zdravstvenipodaciBindingSource.DataSource = this.pI2324_msokser22_DBDataSet;
            // 
            // pI2324_msokser22_DBDataSet
            // 
            this.pI2324_msokser22_DBDataSet.DataSetName = "PI2324_msokser22_DBDataSet";
            this.pI2324_msokser22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Promjeni
            // 
            this.Promjeni.Location = new System.Drawing.Point(252, 258);
            this.Promjeni.Name = "Promjeni";
            this.Promjeni.Size = new System.Drawing.Size(75, 23);
            this.Promjeni.TabIndex = 1;
            this.Promjeni.Text = "Promijeni";
            this.Promjeni.UseVisualStyleBackColor = true;
            this.Promjeni.Click += new System.EventHandler(this.Promjeni_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(354, 258);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 2;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // pI2324msokser22DBDataSetBindingSource
            // 
            this.pI2324msokser22DBDataSetBindingSource.DataSource = this.pI2324_msokser22_DBDataSet;
            this.pI2324msokser22DBDataSetBindingSource.Position = 0;
            // 
            // zdravstveni_podaciTableAdapter
            // 
            this.zdravstveni_podaciTableAdapter.ClearBeforeFill = true;
            // 
            // Odustani
            // 
            this.Odustani.Location = new System.Drawing.Point(687, 258);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(75, 23);
            this.Odustani.TabIndex = 4;
            this.Odustani.Text = "Odustani ";
            this.Odustani.UseVisualStyleBackColor = true;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // Pohrani
            // 
            this.Pohrani.Location = new System.Drawing.Point(510, 258);
            this.Pohrani.Name = "Pohrani";
            this.Pohrani.Size = new System.Drawing.Size(135, 23);
            this.Pohrani.TabIndex = 5;
            this.Pohrani.Text = "Pohrani promjene";
            this.Pohrani.UseVisualStyleBackColor = true;
            this.Pohrani.Click += new System.EventHandler(this.Pohrani_Click);
            // 
            // pI2324msokser22DBDataSetBindingSource1
            // 
            this.pI2324msokser22DBDataSetBindingSource1.DataSource = this.pI2324_msokser22_DBDataSet;
            this.pI2324msokser22DBDataSetBindingSource1.Position = 0;
            // 
            // Manipulacija_podataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.Pohrani);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Promjeni);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manipulacija_podataka";
            this.Text = "Promjena podataka";
            this.Load += new System.EventHandler(this.Manipulacija_podataka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravstvenipodaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_msokser22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324msokser22DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324msokser22DBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Promjeni;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.BindingSource pI2324msokser22DBDataSetBindingSource;
        private PI2324_msokser22_DBDataSet2 pI2324_msokser22_DBDataSet;
        private System.Windows.Forms.BindingSource zdravstvenipodaciBindingSource;
        private PI2324_msokser22_DBDataSet2TableAdapters.Zdravstveni_podaciTableAdapter zdravstveni_podaciTableAdapter;
        private System.Windows.Forms.Button Odustani;
        private System.Windows.Forms.Button Pohrani;
        private System.Windows.Forms.BindingSource pI2324msokser22DBDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobnebilješkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
    }
}