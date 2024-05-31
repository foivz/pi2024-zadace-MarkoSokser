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
using ZdravstveniPodaciRepozitorij;


namespace Zadaca_03
{
    public partial class Osobni_zdravstveni_podaci : Form
    {
        private readonly string[] dijagnoze = { "Akutni faringitis", "Kronicni umor", "Gastrenteritis" };
        private readonly string[] lijekovi = { "Amoksicilin", "Paracetamol", "Omeprazol" };
        public Osobni_zdravstveni_podaci()
        {
            InitializeComponent();

     
            this.BackColor = Color.LightBlue; 

            
            this.FormBorderStyle = FormBorderStyle.Sizable;

            
            this.StartPosition = FormStartPosition.CenterScreen;

            SetFormIcon();

            buttonPretraga.Click += ButtonPretraga_Click;
            this.Load += Form1_Load;
            Zdravstveni_podaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void SetFormIcon()
        {
            try
            {
                
                this.Icon = Properties.Resources.Logo; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom postavljanja ikone: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.zdravstveni_podaciTableAdapter2.Fill(this.pI2324_msokser22_DBDataSet2.Zdravstveni_podaci);

            
            Zdravstveni_podaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

           
            Pretraga.Items.AddRange(new string[] {
                "Pretraga", "Opis simtoma", "Rezultati krvne pretrage", "Informacije o alergiji",
                "Popis prepisanih lijekova", "Napomene liječnika", "Dijagnoza",
                "Plan liječenja", "Osobne bilješke", "Termin"
            });

            
            Obriši.Click += Obriši_Click;
            SetPlaceholder(textBoxPretraga, "Unesite neki od propisan lijekova ili dijagnozu");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                        // Prikazujemo sve stupce osim Column1
                        foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                        {
                            stupac.Visible = (stupac.Name != "Column1");
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
                            odabraniStupac.DisplayIndex = 0;
                            foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                            {
                                stupac.Visible = (stupac == odabraniStupac);
                            }
                            odabraniStupac.Visible = true;
                        }
                        
                    }
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
            manipulacijaForma.PodaciPohranjeni += ManipulacijaForma_PodaciPohranjeni;
            manipulacijaForma.FormClosed += ManipulacijaForma_FormClosed;
            manipulacijaForma.Show();
        }

        private void Promjeni_Click(object sender, EventArgs e)
        {
            Manipulacija_podataka manipulacijaPodatakaForma = new Manipulacija_podataka();
            manipulacijaPodatakaForma.PodaciPohranjeni += ManipulacijaForma_PodaciPohranjeni;
            manipulacijaPodatakaForma.FormClosed += ManipulacijaForma_FormClosed;
            manipulacijaPodatakaForma.Show();
        }

        private void Obriši_Click(object sender, EventArgs e)
        {
            if (Zdravstveni_podaci.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = Zdravstveni_podaci.SelectedCells[0];

               
                if (selectedCell.OwningColumn.Name == "osobnebilješkeDataGridViewTextBoxColumn")
                {
                  
                    int selectedRowIndex = selectedCell.RowIndex;
                    int ID_podataka = Convert.ToInt32(Zdravstveni_podaci.Rows[selectedRowIndex].Cells["Column1"].Value);

                   
                    string deleteQuery = "UPDATE Zdravstveni_podaci SET Osobne_bilješke = NULL WHERE ID_podataka = @ID_podataka";

                    
                    string connectionString = "Server=31.147.206.65;Database=PI2324_msokser22_DB;User Id=PI2324_msokser22_User;Password=$khO:dz&;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            
                            command.Parameters.AddWithValue("@ID_podataka", ID_podataka);

                            try
                            {
                                
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                
                                if (rowsAffected > 0)
                                {
                                    
                                    selectedCell.Value = DBNull.Value;

                                    MessageBox.Show("Podatak uspješno obrisan.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Došlo je do greške prilikom ažuriranja podataka u bazi: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Možete obrisati samo podatke iz stupca 'Osobne bilješke'.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
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

        private void UcitajPodatke()
        {
            this.zdravstveni_podaciTableAdapter2.Fill(this.pI2324_msokser22_DBDataSet2.Zdravstveni_podaci);
        }


        private void ManipulacijaForma_PodaciPohranjeni(object sender, EventArgs e)
        {
            ((Manipulacija_podataka)sender).PodaciAzurirani += PodaciAzuriraniHandler;
        }

        private void ManipulacijaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            UcitajPodatke();
            ((Manipulacija_podataka)sender).PodaciAzurirani += PodaciAzuriraniHandler;
        }

        private void PodaciAzuriraniHandler(object sender, EventArgs e)
        {
            
            UcitajPodatke();
        }

        private void textBoxPretraga_TextChanged(object sender, EventArgs e)
        {

        }


        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }

            textBox.GotFocus += (sender, e) => RemovePlaceholder(textBox, placeholderText);
            textBox.LostFocus += (sender, e) => ShowPlaceholder(textBox, placeholderText);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void ShowPlaceholder(TextBox textBox, string placeholderText)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        }

    }

}

    
    

