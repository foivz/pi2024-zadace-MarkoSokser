using System;
using System.Windows.Forms;
using Zadaca_03.Repozitori;
using System.Data.SqlClient;

namespace Zadaca_03
{
    public partial class Manipulacija_podataka : Form
    {
        // Definirajte događaj koji će se aktivirati nakon pohrane podataka
        public event EventHandler PodaciPohranjeni;
        public event EventHandler PodaciPromijenjeni;

        public Manipulacija_podataka()
        {
            InitializeComponent();
        }


        private void Manipulacija_podataka_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var zdravstveniPodaci = ZdravstveniPodaciRepozitorij.GetAllZdravstveniPodaci();
            dataGridView1.DataSource = zdravstveniPodaci;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "osobnebilješkeDataGridViewTextBoxColumn")
                {
                    dataGridView1.BeginEdit(true);
                }
            }
        }

        private void Promjeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("terminDataGridViewTextBoxColumn"))
            {
                int colIndex = dataGridView1.Columns["terminDataGridViewTextBoxColumn"].Index;
                dataGridView1.Columns.RemoveAt(colIndex);

                CalendarColumn calendarColumn = new CalendarColumn
                {
                    Name = "terminDataGridViewTextBoxColumn",
                    HeaderText = "Termin",
                    DataPropertyName = "Termin" // Ako koristite DataBinding
                };
                dataGridView1.Columns.Insert(colIndex, calendarColumn);

                dataGridView1.Columns["terminDataGridViewTextBoxColumn"].ReadOnly = false;
                MessageBox.Show("Uređivanje stupca je aktivno", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pohrani_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["osobnebilješkeDataGridViewTextBoxColumn"].IsInEditMode || row.Cells["terminDataGridViewTextBoxColumn"].IsInEditMode)
                {
                    int id;
                    bool isNewRecord = row.Cells["ID_podataka"].Value == null || !int.TryParse(row.Cells["ID_podataka"].Value.ToString(), out id);

                    string noveBiljeske = row.Cells["osobnebilješkeDataGridViewTextBoxColumn"].Value?.ToString();
                    DateTime? noviTermin = row.Cells["terminDataGridViewTextBoxColumn"].Value as DateTime?;

                    if (isNewRecord)
                    {
                        // Insert new record
                        ZdravstveniPodaciRepozitorij.InsertOsobneBiljeskeITermin(noveBiljeske, noviTermin);
                    }
                    else
                    {
                        // Update existing record
                        ZdravstveniPodaciRepozitorij.UpdateOsobneBiljeske(id, noveBiljeske, noviTermin);
                    }
                }
            }

            MessageBox.Show("Promjene su pohranjene.");

            // Aktivirajte događaj nakon pohrane podataka
            PodaciPohranjeni?.Invoke(this, EventArgs.Empty);
            PodaciPromijenjeni?.Invoke(this, EventArgs.Empty);

        }



       
        
        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                dataGridView1.BeginEdit(true); // Omogućite uređivanje odabrane ćelije
                selectedRow.Cells["osobnebilješkeDataGridViewTextBoxColumn"].Selected = true;
            }
        }
    }
}
