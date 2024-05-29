using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_03
{
    public partial class Osobni_zdravstveni_podaci : Form
    {
        private readonly string[] dijagnoze = { "Akutni faringitis", "Kronicni umor", "Gastrenteritis" };
        private readonly string[] lijekovi = { "Amoksicilin", "Paracetamol", "Omeprazol" };
        public Osobni_zdravstveni_podaci()
        {
            InitializeComponent();

            // Postavite pozadinu forme
            this.BackColor = Color.LightBlue; // Postavite željenu boju

            // Omogućite resizable mogućnost
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Centrirajte formu na ekranu
            this.StartPosition = FormStartPosition.CenterScreen;

            // Postavite ikonu forme
            SetFormIcon();

            buttonPretraga.Click += ButtonPretraga_Click;

        }

        public void SetFormIcon()
        {
            try
            {
                // Postavljanje ikone forme iz resursa
                this.Icon = Properties.Resources.Logo; // Pretpostavka da je vaša ikona nazvana "Logo"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom postavljanja ikone: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CenterDataGridViewCells()
        {
            foreach (DataGridViewColumn column in Zdravstveni_podaci.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private DataGridViewCell zadnjeObrisanaCelija = null;
        private string zadnjeObrisanaVrijednost = null;
        private int zadnjiObrisaniRedIndex = -1;
        private string zadnjeObrisanoPolje = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puni DataGridView kontrolu podacima iz baze
            this.zdravstveni_podaciTableAdapter2.Fill(this.pI2324_msokser22_DBDataSet2.Zdravstveni_podaci);

            // Postavlja automatsko prilagođavanje visine redova prema sadržaju ćelija
            Zdravstveni_podaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Dodaje stavke u ComboBox za pretragu
            Pretraga.Items.AddRange(new string[] {
                "Pretraga", "Opis simtoma", "Rezultati krvne pretrage", "Informacije o alergiji",
                "Popis prepisanih lijekova", "Napomene liječnika", "Dijagnoza",
                "Plan liječenja", "Osobne bilješke", "Termin"
            });

            // Event handler za gumb Obriši
            Obriši.Click += Obriši_Click;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ako nema posebne logike za klik na ćeliju, možete ukloniti ovaj metod.
        }

        


        private void Pretraga_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Pretraga.SelectedItem != null)
                {
                    string odabraniNazivStupca = Pretraga.SelectedItem.ToString();

                    if (odabraniNazivStupca == "Pretraga")
                    {
                        // Prikaži sve stupce i vrati ih na prvobitni redoslijed
                        foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                        {
                            stupac.Visible = true;
                        }
                        MessageBox.Show("Prikazani su svi stupci.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DataGridViewColumn odabraniStupac = Zdravstveni_podaci.Columns
                            .Cast<DataGridViewColumn>()
                            .FirstOrDefault(stupac => stupac.HeaderText == odabraniNazivStupca || stupac.DataPropertyName == odabraniNazivStupca);

                        if (odabraniStupac != null)
                        {
                            // Postavi redoslijed odabranog stupca na 0 i sakrij sve ostale stupce
                            odabraniStupac.DisplayIndex = 0;
                            foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                            {
                                stupac.Visible = (stupac == odabraniStupac);
                            }
                            odabraniStupac.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Odabrani stupac ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Molimo odaberite stupac za pretragu.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            Manipulacija_podataka manipulacijaForma = new Manipulacija_podataka();
            manipulacijaForma.Show();
        }

        private void Promjeni_Click(object sender, EventArgs e)
        {
            Manipulacija_podataka manipulacijaPodatakaForma = new Manipulacija_podataka();
            manipulacijaPodatakaForma.Show();
        }

        private void Obriši_Click(object sender, EventArgs e)
        {
            // Implementacija logike za brisanje
        }

        private void Spremi_Click(object sender, EventArgs e)
        {
            // Implementacija logike za spremanje
        }


        private void ButtonPretraga_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxPretraga.Text;
            string query;

            if (dijagnoze.Contains(searchTerm))
            {
                query = "SELECT * FROM Zdravstveni_podaci WHERE Dijagnoza LIKE @searchTerm";
            }
            else if (lijekovi.Contains(searchTerm))
            {
                query = "SELECT * FROM Zdravstveni_podaci WHERE Popis_prepisanih_lijekova LIKE @searchTerm";
            }
            else
            {
                // Ako pretraženi pojam nije ni dijagnoza ni lijek, vrati sve podatke
                query = "SELECT * FROM Zdravstveni_podaci";
            }

            string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                Zdravstveni_podaci.DataSource = table;
            }
        }




    }

}

    
    

