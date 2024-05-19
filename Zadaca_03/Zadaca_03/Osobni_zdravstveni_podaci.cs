using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_03
{
    public partial class Osobni_zdravstveni_podaci : Form
    {
        public static IEnumerable<DataGridViewColumn> Columns { get; private set; }

        public Osobni_zdravstveni_podaci()
        {
            InitializeComponent();
        }

        private DataGridViewCell zadnjeObrisanaCelija = null;
        private string zadnjeObrisanaVrijednost = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            Zdravstveni_podaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
           
            this.zdravstveni_podaciTableAdapter.Fill(this.pI2324_msokser22_DBDataSet.Zdravstveni_podaci);
            Pretraga.Items.AddRange(new string[] { "Pretraga", 
        "Opis simtoma", "Rezultati krvne pretrage", "Informacije o alergiji",
        "Popis prepisanih lijekova", "Napomene liječnika", "Dijagnoza",
        "Plan liječenja", "Osobne bilješke", "Termin"
    });
            // Event handler za gumb Obriši
            Obriši.Click += Obriši_Click;

           

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
                        // Prikaži sve stupce i vrati ih na prvobitni redoslijed
                        foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                        {
                            stupac.Visible = true;
                        }
                        MessageBox.Show("Prikazani su svi stupci.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DataGridViewColumn odabraniStupac = null;
                        foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                        {
                            if (stupac.HeaderText == odabraniNazivStupca || stupac.DataPropertyName == odabraniNazivStupca)
                            {
                                odabraniStupac = stupac;
                                break;
                            }
                        }

                        if (odabraniStupac != null)
                        {
                            // Prvo postavi redoslijed odabranog stupca na 0 (prvi stupac)
                            odabraniStupac.DisplayIndex = 0;

                            // Sakrij sve ostale stupce
                            foreach (DataGridViewColumn stupac in Zdravstveni_podaci.Columns)
                            {
                                stupac.Visible = (stupac == odabraniStupac);
                            }

                            // Osiguraj da je odabrani stupac vidljiv
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
            Manipulacija_podataka manipulacijaPodatakaForma = new Manipulacija_podataka();
            manipulacijaPodatakaForma.Show();

        }

        private void Promjeni_Click(object sender, EventArgs e)
        {
            Manipulacija_podataka manipulacijaPodatakaForma = new Manipulacija_podataka();
            manipulacijaPodatakaForma.Show();
        }


        private int zadnjiObrisaniRedIndex = -1;
        private string zadnjeObrisanoPolje = null;




        private void Obriši_Click(object sender, EventArgs e)
        {
            if (Zdravstveni_podaci.CurrentCell != null)
            {
                var trenutnaCelija = Zdravstveni_podaci.CurrentCell;

                if (trenutnaCelija.OwningColumn.HeaderText == "Osobne bilješke")
                {
                    // Spremi identifikator reda i sadržaj ćelije za brisanje
                    zadnjiObrisaniRedIndex = trenutnaCelija.RowIndex;
                    zadnjeObrisanoPolje = trenutnaCelija.Value?.ToString();

                    // Obrisi podatke iz ćelije
                    trenutnaCelija.Value = null;
                }
                else
                {
                    MessageBox.Show("Možete brisati samo podatke u stupcima 'Osobne bilješke'.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void Spremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (zadnjiObrisaniRedIndex != -1 && zadnjeObrisanoPolje != null)
                {
                    int idRedaZaBrisanje = (int)Zdravstveni_podaci.Rows[zadnjiObrisaniRedIndex].Cells["ID"].Value;

                    using (var conn = new SqlConnection("connection_string"))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Zdravstveni_podaci WHERE ID = @ID";

                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", idRedaZaBrisanje);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Ovdje možete ukloniti redak iz DataSource-a ako je primjenjivo
                    Zdravstveni_podaci.Rows.RemoveAt(zadnjiObrisaniRedIndex);

                    zadnjiObrisaniRedIndex = -1;
                    zadnjeObrisanoPolje = null;

                    MessageBox.Show("Promjena uspješno pohranjena.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nema promjena za spremanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Došlo je do greške prilikom spremanja promjena: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do nepredviđene greške prilikom spremanja promjena: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
