using System;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;
using Zadaca_03.Modeli;
using System.Drawing;

namespace Zadaca_03
{
    public partial class Manipulacija_podataka : Form
    {
        // Definirajte događaj koji će se aktivirati nakon pohrane podataka
        public event EventHandler PodaciPohranjeni;
        public event EventHandler PodaciPromijenjeni;

       
        private string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";

        public Manipulacija_podataka()
        {
            InitializeComponent();
            PopuniGrid();
            InitializeComponent();

            // Postavite pozadinu forme
            this.BackColor = Color.LightBlue; // Postavite željenu boju

            // Omogućite resizable mogućnost
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Centrirajte formu na ekranu
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void PopuniGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Zdravstveni_podaci"; // Postavite svoj upit za dohvaćanje podataka

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
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
            try
            {
                // Spremanje promjena na formi u bazu podataka
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    ZdravstveniPodaci podaci = new ZdravstveniPodaci
                    {
                        OsobneBiljeske = row.Cells["osobnebilješkeDataGridViewTextBoxColumn"].Value.ToString(),
                        Termin = Convert.ToDateTime(row.Cells["terminDataGridViewTextBoxColumn"].Value)
                    };

                    if (string.IsNullOrWhiteSpace(podaci.OsobneBiljeske)) // Ako su osobne bilješke prazne, obriši ih iz baze
                    {
                        int ID_podataka = Convert.ToInt32(row.Cells["ID_podataka"].Value);
                        ZdravstveniPodaciRepozitorij.ZdravstveniPodaciRepozitorij.DeleteOsobneBiljeske(ID_podataka);
                    }
                    else if (podaci.Termin != null) // Ako postoji termin, ažuriraj ga u bazi
                    {
                        ZdravstveniPodaciRepozitorij.ZdravstveniPodaciRepozitorij.UpdateTermini(podaci);
                    }
                    else // Inače, umetni nove podatke u bazu
                    {
                        ZdravstveniPodaciRepozitorij.ZdravstveniPodaciRepozitorij.InsertOsobneBiljeske(podaci);
                    }
                }

                // Obavijesti korisnika o uspješnoj pohrani
                MessageBox.Show("Promjene su uspješno pohranjene.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Zatvori trenutnu formu
                this.Close();
            }
            catch (Exception ex)
            {
                // Uhvati eventualne greške prilikom pohrane podataka
                MessageBox.Show("Došlo je do greške prilikom pohrane podataka: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Manipulacija_podataka_Load(object sender, EventArgs e)
        {

        }
    }
}
