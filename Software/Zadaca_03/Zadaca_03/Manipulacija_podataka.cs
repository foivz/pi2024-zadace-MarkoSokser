using System;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

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
