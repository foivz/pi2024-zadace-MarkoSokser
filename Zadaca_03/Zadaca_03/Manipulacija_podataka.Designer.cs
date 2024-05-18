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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Promjeni = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.pI2324_msokser22_DBDataSet = new Zadaca_03.PI2324_msokser22_DBDataSet();
            this.pI2324msokser22DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zdravstvenipodaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zdravstveni_podaciTableAdapter = new Zadaca_03.PI2324_msokser22_DBDataSetTableAdapters.Zdravstveni_podaciTableAdapter();
            this.osobnebilješkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_msokser22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324msokser22DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravstvenipodaciBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(96, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Promjeni
            // 
            this.Promjeni.Location = new System.Drawing.Point(96, 388);
            this.Promjeni.Name = "Promjeni";
            this.Promjeni.Size = new System.Drawing.Size(75, 23);
            this.Promjeni.TabIndex = 1;
            this.Promjeni.Text = "Promijeni";
            this.Promjeni.UseVisualStyleBackColor = true;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(931, 388);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 2;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            // 
            // pI2324_msokser22_DBDataSet
            // 
            this.pI2324_msokser22_DBDataSet.DataSetName = "PI2324_msokser22_DBDataSet";
            this.pI2324_msokser22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pI2324msokser22DBDataSetBindingSource
            // 
            this.pI2324msokser22DBDataSetBindingSource.DataSource = this.pI2324_msokser22_DBDataSet;
            this.pI2324msokser22DBDataSetBindingSource.Position = 0;
            // 
            // zdravstvenipodaciBindingSource
            // 
            this.zdravstvenipodaciBindingSource.DataMember = "Zdravstveni_podaci";
            this.zdravstvenipodaciBindingSource.DataSource = this.pI2324_msokser22_DBDataSet;
            // 
            // zdravstveni_podaciTableAdapter
            // 
            this.zdravstveni_podaciTableAdapter.ClearBeforeFill = true;
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
            this.terminDataGridViewTextBoxColumn.Width = 78;
            // 
            // Manipulacija_podataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Promjeni);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manipulacija_podataka";
            this.Text = "Promjena podataka";
            this.Load += new System.EventHandler(this.Manipulacija_podataka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_msokser22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324msokser22DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravstvenipodaciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Promjeni;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.BindingSource pI2324msokser22DBDataSetBindingSource;
        private PI2324_msokser22_DBDataSet pI2324_msokser22_DBDataSet;
        private System.Windows.Forms.BindingSource zdravstvenipodaciBindingSource;
        private PI2324_msokser22_DBDataSetTableAdapters.Zdravstveni_podaciTableAdapter zdravstveni_podaciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobnebilješkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
    }
}