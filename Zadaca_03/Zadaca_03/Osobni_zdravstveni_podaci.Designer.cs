namespace Zadaca_03
{
    partial class Osobni_zdravstveni_podaci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Zdravstveni_podaci = new System.Windows.Forms.DataGridView();
            this.opissimtomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informacijeoalergijiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomeneliječnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagnozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planliječenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobnebilješkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdravstvenipodaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_msokser22_DBDataSet = new Zadaca_03.PI2324_msokser22_DBDataSet();
            this.Obriši = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Promjeni = new System.Windows.Forms.Button();
            this.Pretraga = new System.Windows.Forms.ComboBox();
            this.zdravstveni_podaciTableAdapter = new Zadaca_03.PI2324_msokser22_DBDataSetTableAdapters.Zdravstveni_podaciTableAdapter();
            this.Vrati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Zdravstveni_podaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravstvenipodaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_msokser22_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Zdravstveni_podaci
            // 
            this.Zdravstveni_podaci.AllowDrop = true;
            this.Zdravstveni_podaci.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Zdravstveni_podaci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Zdravstveni_podaci.AutoGenerateColumns = false;
            this.Zdravstveni_podaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Zdravstveni_podaci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Zdravstveni_podaci.ColumnHeadersHeight = 29;
            this.Zdravstveni_podaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opissimtomaDataGridViewTextBoxColumn,
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn,
            this.informacijeoalergijiDataGridViewTextBoxColumn,
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn,
            this.napomeneliječnikaDataGridViewTextBoxColumn,
            this.dijagnozaDataGridViewTextBoxColumn,
            this.planliječenjaDataGridViewTextBoxColumn,
            this.osobnebilješkeDataGridViewTextBoxColumn,
            this.terminDataGridViewTextBoxColumn});
            this.Zdravstveni_podaci.DataSource = this.zdravstvenipodaciBindingSource;
            this.Zdravstveni_podaci.Location = new System.Drawing.Point(28, 55);
            this.Zdravstveni_podaci.Name = "Zdravstveni_podaci";
            this.Zdravstveni_podaci.ReadOnly = true;
            this.Zdravstveni_podaci.RowHeadersWidth = 51;
            this.Zdravstveni_podaci.RowTemplate.Height = 24;
            this.Zdravstveni_podaci.Size = new System.Drawing.Size(1287, 318);
            this.Zdravstveni_podaci.TabIndex = 0;
            this.Zdravstveni_podaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // opissimtomaDataGridViewTextBoxColumn
            // 
            this.opissimtomaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opissimtomaDataGridViewTextBoxColumn.DataPropertyName = "Opis_simtoma";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.opissimtomaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.opissimtomaDataGridViewTextBoxColumn.HeaderText = "Opis simtoma";
            this.opissimtomaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opissimtomaDataGridViewTextBoxColumn.Name = "opissimtomaDataGridViewTextBoxColumn";
            this.opissimtomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.opissimtomaDataGridViewTextBoxColumn.Width = 118;
            // 
            // rezultatikrvnepretrageDataGridViewTextBoxColumn
            // 
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.DataPropertyName = "Rezultati_krvne_pretrage";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.HeaderText = "Rezultati krvne pretrage";
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.Name = "rezultatikrvnepretrageDataGridViewTextBoxColumn";
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.Width = 177;
            // 
            // informacijeoalergijiDataGridViewTextBoxColumn
            // 
            this.informacijeoalergijiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.informacijeoalergijiDataGridViewTextBoxColumn.DataPropertyName = "Informacije_o_alergiji";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.informacijeoalergijiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.informacijeoalergijiDataGridViewTextBoxColumn.HeaderText = "Informacije o alergiji";
            this.informacijeoalergijiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.informacijeoalergijiDataGridViewTextBoxColumn.Name = "informacijeoalergijiDataGridViewTextBoxColumn";
            this.informacijeoalergijiDataGridViewTextBoxColumn.ReadOnly = true;
            this.informacijeoalergijiDataGridViewTextBoxColumn.Width = 155;
            // 
            // popisprepisanihlijekovaDataGridViewTextBoxColumn
            // 
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.DataPropertyName = "Popis_prepisanih_lijekova";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.HeaderText = "Popis prepisanih lijekova";
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.Name = "popisprepisanihlijekovaDataGridViewTextBoxColumn";
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.ReadOnly = true;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.Width = 187;
            // 
            // napomeneliječnikaDataGridViewTextBoxColumn
            // 
            this.napomeneliječnikaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.napomeneliječnikaDataGridViewTextBoxColumn.DataPropertyName = "Napomene_liječnika";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.napomeneliječnikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.napomeneliječnikaDataGridViewTextBoxColumn.HeaderText = "Napomene liječnika";
            this.napomeneliječnikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.napomeneliječnikaDataGridViewTextBoxColumn.Name = "napomeneliječnikaDataGridViewTextBoxColumn";
            this.napomeneliječnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomeneliječnikaDataGridViewTextBoxColumn.Width = 156;
            // 
            // dijagnozaDataGridViewTextBoxColumn
            // 
            this.dijagnozaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dijagnozaDataGridViewTextBoxColumn.DataPropertyName = "Dijagnoza";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dijagnozaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.dijagnozaDataGridViewTextBoxColumn.HeaderText = "Dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dijagnozaDataGridViewTextBoxColumn.Name = "dijagnozaDataGridViewTextBoxColumn";
            this.dijagnozaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dijagnozaDataGridViewTextBoxColumn.Width = 97;
            // 
            // planliječenjaDataGridViewTextBoxColumn
            // 
            this.planliječenjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.planliječenjaDataGridViewTextBoxColumn.DataPropertyName = "Plan_liječenja";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.planliječenjaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.planliječenjaDataGridViewTextBoxColumn.HeaderText = "Plan liječenja";
            this.planliječenjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planliječenjaDataGridViewTextBoxColumn.Name = "planliječenjaDataGridViewTextBoxColumn";
            this.planliječenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.planliječenjaDataGridViewTextBoxColumn.Width = 116;
            // 
            // osobnebilješkeDataGridViewTextBoxColumn
            // 
            this.osobnebilješkeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.osobnebilješkeDataGridViewTextBoxColumn.DataPropertyName = "Osobne_bilješke";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.osobnebilješkeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.osobnebilješkeDataGridViewTextBoxColumn.HeaderText = "Osobne bilješke";
            this.osobnebilješkeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.osobnebilješkeDataGridViewTextBoxColumn.Name = "osobnebilješkeDataGridViewTextBoxColumn";
            this.osobnebilješkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.osobnebilješkeDataGridViewTextBoxColumn.Width = 134;
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "Termin";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.terminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
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
            // Obriši
            // 
            this.Obriši.Location = new System.Drawing.Point(1240, 379);
            this.Obriši.Name = "Obriši";
            this.Obriši.Size = new System.Drawing.Size(75, 23);
            this.Obriši.TabIndex = 2;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseVisualStyleBackColor = true;
            this.Obriši.Click += new System.EventHandler(this.Obriši_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(848, 378);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 3;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Promjeni
            // 
            this.Promjeni.Location = new System.Drawing.Point(948, 379);
            this.Promjeni.Name = "Promjeni";
            this.Promjeni.Size = new System.Drawing.Size(75, 23);
            this.Promjeni.TabIndex = 4;
            this.Promjeni.Text = "Promjeni";
            this.Promjeni.UseVisualStyleBackColor = true;
            this.Promjeni.Click += new System.EventHandler(this.Promjeni_Click);
            // 
            // Pretraga
            // 
            this.Pretraga.FormattingEnabled = true;
            this.Pretraga.Location = new System.Drawing.Point(28, 378);
            this.Pretraga.Name = "Pretraga";
            this.Pretraga.Size = new System.Drawing.Size(241, 24);
            this.Pretraga.TabIndex = 5;
            this.Pretraga.Text = "Pretraži";
            this.Pretraga.SelectedIndexChanged += new System.EventHandler(this.Pretraga_SelectedIndexChanged);
            // 
            // zdravstveni_podaciTableAdapter
            // 
            this.zdravstveni_podaciTableAdapter.ClearBeforeFill = true;
            // 
            // Vrati
            // 
            this.Vrati.Location = new System.Drawing.Point(0, 0);
            this.Vrati.Name = "Vrati";
            this.Vrati.Size = new System.Drawing.Size(75, 23);
            this.Vrati.TabIndex = 0;
            // 
            // Osobni_zdravstveni_podaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1372, 651);
            this.Controls.Add(this.Pretraga);
            this.Controls.Add(this.Promjeni);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Obriši);
            this.Controls.Add(this.Zdravstveni_podaci);
            this.Name = "Osobni_zdravstveni_podaci";
            this.Text = "Osobni zdravstveni podaci";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zdravstveni_podaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdravstvenipodaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_msokser22_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Zdravstveni_podaci;
        private PI2324_msokser22_DBDataSet pI2324_msokser22_DBDataSet;
        private System.Windows.Forms.BindingSource zdravstvenipodaciBindingSource;
        private PI2324_msokser22_DBDataSetTableAdapters.Zdravstveni_podaciTableAdapter zdravstveni_podaciTableAdapter;
        private System.Windows.Forms.Button Obriši;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Promjeni;
        private System.Windows.Forms.ComboBox Pretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn opissimtomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatikrvnepretrageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informacijeoalergijiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popisprepisanihlijekovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomeneliječnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagnozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planliječenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobnebilješkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Vrati;
    }
}