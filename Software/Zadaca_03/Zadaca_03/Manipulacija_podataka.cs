using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Zadaca_03.Modeli;

namespace Zadaca_03
{
    public partial class Manipulacija_podataka : Form
    {
        public event EventHandler PodaciPohranjeni;
        public event EventHandler PodaciAzurirani;



        private string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";

        public Manipulacija_podataka()
        {
            InitializeComponent();
            PopuniGrid();
            this.BackColor = Color.LightBlue;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PopuniGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Zdravstveni_podaci";
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
                    DataPropertyName = "Termin"
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int ID_podataka = Convert.ToInt32(row.Cells["Column1"].Value);
                    DateTime? termin = row.Cells["terminDataGridViewTextBoxColumn"].Value as DateTime?;

                    if (termin.HasValue)
                    {
                        ZdravstveniPodaciRepozitorij.ZdravstveniPodaciRepozitorij.UpdateTermini(ID_podataka, termin.Value);
                    }
                }

                MessageBox.Show("Promjene su uspješno pohranjene.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PodaciPohranjeni?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom pohrane podataka: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedCells.Count > 0)
            {
                
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                
                string osobneBiljeske = dataGridView1.Rows[rowIndex].Cells["osobnebilješkeDataGridViewTextBoxColumn"].Value.ToString();

                
                if (string.IsNullOrEmpty(osobneBiljeske))
                {
                  
                    string unosTeksta = Unos.Text;

                   
                    dataGridView1.Rows[rowIndex].Cells["osobnebilješkeDataGridViewTextBoxColumn"].Value = unosTeksta;

                    
                    if (!string.IsNullOrEmpty(unosTeksta))
                    {
                       
                        int ID_podataka = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Column1"].Value);

                       
                        string query = $"UPDATE Zdravstveni_podaci SET Osobne_bilješke = '{unosTeksta}' WHERE ID_podataka = {ID_podataka}";

                        
                        try
                        {
                            DB.OpenConnection();
                            DB.ExecuteCommand(query);
                            DB.CloseConnection();
                            MessageBox.Show("Tekst je uspješno dodan u bazu podataka.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            PodaciAzurirani?.Invoke(this, EventArgs.Empty);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Došlo je do greške prilikom unosa podataka u bazu: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nije moguće dodati tekst jer ćelija već sadrži podatke.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nije odabran red za unos podataka.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void Unos_TextChanged(object sender, EventArgs e)
        {

        }
        private void Manipulacija_podataka_Load(object sender, EventArgs e)
        {
        }

    }
}
