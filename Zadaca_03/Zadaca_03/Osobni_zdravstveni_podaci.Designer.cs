﻿namespace Zadaca_03
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
            this.Zdravstveni_podaci = new System.Windows.Forms.DataGridView();
            this.zdravstvenipodaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_msokser22_DBDataSet = new Zadaca_03.PI2324_msokser22_DBDataSet();
            this.Obriši = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Promjeni = new System.Windows.Forms.Button();
            this.Pretraga = new System.Windows.Forms.ComboBox();
            this.zdravstveni_podaciTableAdapter = new Zadaca_03.PI2324_msokser22_DBDataSetTableAdapters.Zdravstveni_podaciTableAdapter();
            this.Vrati = new System.Windows.Forms.Button();
            this.Spremi = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opissimtomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informacijeoalergijiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomeneliječnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagnozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planliječenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobnebilješkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Zdravstveni_podaci.RowHeadersWidth = 51;
            this.Zdravstveni_podaci.RowTemplate.Height = 24;
            this.Zdravstveni_podaci.Size = new System.Drawing.Size(1287, 318);
            this.Zdravstveni_podaci.TabIndex = 0;
            this.Zdravstveni_podaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(1140, 379);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(75, 23);
            this.Spremi.TabIndex = 6;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.Spremi_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 88;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Opis_simtoma";
            this.dataGridViewTextBoxColumn2.HeaderText = "Opis_simtoma";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 122;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rezultati_krvne_pretrage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rezultati_krvne_pretrage";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 185;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Informacije_o_alergiji";
            this.dataGridViewTextBoxColumn4.HeaderText = "Informacije_o_alergiji";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 163;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Popis_prepisanih_lijekova";
            this.dataGridViewTextBoxColumn5.HeaderText = "Popis_prepisanih_lijekova";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 195;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Napomene_liječnika";
            this.dataGridViewTextBoxColumn6.HeaderText = "Napomene_liječnika";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Dijagnoza";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dijagnoza";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Plan_liječenja";
            this.dataGridViewTextBoxColumn8.HeaderText = "Plan_liječenja";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Osobne_bilješke";
            this.dataGridViewTextBoxColumn9.HeaderText = "Osobne_bilješke";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 138;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Termin";
            this.dataGridViewTextBoxColumn10.HeaderText = "Termin";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 78;
            // 
            // opissimtomaDataGridViewTextBoxColumn
            // 
            this.opissimtomaDataGridViewTextBoxColumn.DataPropertyName = "Opis_simtoma";
            this.opissimtomaDataGridViewTextBoxColumn.HeaderText = "Opis simtoma";
            this.opissimtomaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opissimtomaDataGridViewTextBoxColumn.Name = "opissimtomaDataGridViewTextBoxColumn";
            this.opissimtomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.opissimtomaDataGridViewTextBoxColumn.Width = 118;
            // 
            // rezultatikrvnepretrageDataGridViewTextBoxColumn
            // 
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.DataPropertyName = "Rezultati_krvne_pretrage";
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.HeaderText = "Rezultati krvne pretrage";
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.Name = "rezultatikrvnepretrageDataGridViewTextBoxColumn";
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezultatikrvnepretrageDataGridViewTextBoxColumn.Width = 177;
            // 
            // informacijeoalergijiDataGridViewTextBoxColumn
            // 
            this.informacijeoalergijiDataGridViewTextBoxColumn.DataPropertyName = "Informacije_o_alergiji";
            this.informacijeoalergijiDataGridViewTextBoxColumn.HeaderText = "Informacije o alergiji";
            this.informacijeoalergijiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.informacijeoalergijiDataGridViewTextBoxColumn.Name = "informacijeoalergijiDataGridViewTextBoxColumn";
            this.informacijeoalergijiDataGridViewTextBoxColumn.ReadOnly = true;
            this.informacijeoalergijiDataGridViewTextBoxColumn.Width = 155;
            // 
            // popisprepisanihlijekovaDataGridViewTextBoxColumn
            // 
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.DataPropertyName = "Popis_prepisanih_lijekova";
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.HeaderText = "Popis prepisanih lijekova";
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.Name = "popisprepisanihlijekovaDataGridViewTextBoxColumn";
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.ReadOnly = true;
            this.popisprepisanihlijekovaDataGridViewTextBoxColumn.Width = 187;
            // 
            // napomeneliječnikaDataGridViewTextBoxColumn
            // 
            this.napomeneliječnikaDataGridViewTextBoxColumn.DataPropertyName = "Napomene_liječnika";
            this.napomeneliječnikaDataGridViewTextBoxColumn.HeaderText = "Napomene liječnika";
            this.napomeneliječnikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.napomeneliječnikaDataGridViewTextBoxColumn.Name = "napomeneliječnikaDataGridViewTextBoxColumn";
            this.napomeneliječnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomeneliječnikaDataGridViewTextBoxColumn.Width = 156;
            // 
            // dijagnozaDataGridViewTextBoxColumn
            // 
            this.dijagnozaDataGridViewTextBoxColumn.DataPropertyName = "Dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.HeaderText = "Dijagnoza";
            this.dijagnozaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dijagnozaDataGridViewTextBoxColumn.Name = "dijagnozaDataGridViewTextBoxColumn";
            this.dijagnozaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dijagnozaDataGridViewTextBoxColumn.Width = 97;
            // 
            // planliječenjaDataGridViewTextBoxColumn
            // 
            this.planliječenjaDataGridViewTextBoxColumn.DataPropertyName = "Plan_liječenja";
            this.planliječenjaDataGridViewTextBoxColumn.HeaderText = "Plan liječenja";
            this.planliječenjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planliječenjaDataGridViewTextBoxColumn.Name = "planliječenjaDataGridViewTextBoxColumn";
            this.planliječenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.planliječenjaDataGridViewTextBoxColumn.Width = 116;
            // 
            // osobnebilješkeDataGridViewTextBoxColumn
            // 
            this.osobnebilješkeDataGridViewTextBoxColumn.DataPropertyName = "Osobne_bilješke";
            this.osobnebilješkeDataGridViewTextBoxColumn.HeaderText = "Osobne bilješke";
            this.osobnebilješkeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.osobnebilješkeDataGridViewTextBoxColumn.Name = "osobnebilješkeDataGridViewTextBoxColumn";
            this.osobnebilješkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.osobnebilješkeDataGridViewTextBoxColumn.Width = 134;
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "Termin";
            this.terminDataGridViewTextBoxColumn.HeaderText = "Termin";
            this.terminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminDataGridViewTextBoxColumn.Name = "terminDataGridViewTextBoxColumn";
            this.terminDataGridViewTextBoxColumn.ReadOnly = true;
            this.terminDataGridViewTextBoxColumn.Width = 78;
            // 
            // Osobni_zdravstveni_podaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1372, 651);
            this.Controls.Add(this.Spremi);
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
        private System.Windows.Forms.Button Vrati;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn opissimtomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatikrvnepretrageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informacijeoalergijiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popisprepisanihlijekovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomeneliječnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagnozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planliječenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobnebilješkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
    }
}