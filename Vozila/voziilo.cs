using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Vozila
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
            cmbSortiranje.Items.AddRange(new string[] { "Marka", "Model", "GodinaProizvodnje", "Kilometraza" });
            cmbSortiranje.SelectedIndex = 0;
            UcitajIzXML();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Vozilo novoVozilo = new Vozilo
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                    Kilometraza = int.Parse(txtKilometraza.Text)
                };
                vozila.Add(novoVozilo);
                UpdateVozilaList();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Metoda za ažuriranje liste vozila u ListBox kontroli
        private void UpdateVozilaList()
        {
            lstVozila.Items.Clear();
            foreach (var vozilo in vozila)
            {
                lstVozila.Items.Add(vozilo.ToString());
            }
        }

        // Metoda za čišćenje unosa
        private void ClearInputs()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtKilometraza.Clear();
        }

        // Validacija unosa
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
                return false;

            if (!int.TryParse(txtGodinaProizvodnje.Text, out int godina) || godina <= 0)
                return false;

            if (!int.TryParse(txtKilometraza.Text, out int kilometraza) || kilometraza < 0)
                return false;

            return true;
        }

        // Metoda za sortiranje vozila
        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            if (vozila.Count == 0)
            {
                MessageBox.Show("Lista vozila je prazna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kriterij = cmbSortiranje.SelectedItem.ToString();
            bool uzlazno = rbUzlazno.Checked;

            List<Vozilo> sortiranaLista;

            switch (kriterij)
            {
                case "Marka":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.Marka).ToList() : vozila.OrderByDescending(v => v.Marka).ToList();
                    break;

                case "Model":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.Model).ToList() : vozila.OrderByDescending(v => v.Model).ToList();
                    break;

                case "GodinaProizvodnje":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.GodinaProizvodnje).ToList() : vozila.OrderByDescending(v => v.GodinaProizvodnje).ToList();
                    break;

                case "Kilometraza":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.Kilometraza).ToList() : vozila.OrderByDescending(v => v.Kilometraza).ToList();
                    break;

                default:
                    sortiranaLista = vozila;
                    break;
            }
        }

        // Metoda za brisanje vozila
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lstVozila.SelectedIndex >= 0)
            {
                vozila.RemoveAt(lstVozila.SelectedIndex);
                UpdateVozilaList();
            }
            else
            {
                MessageBox.Show("Odaberite vozilo za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Metoda za spremanje liste vozila u XML datoteku
        private void SpremiUXML()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Vozilo>));
                using (FileStream fs = new FileStream("vozila.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, vozila);
                }
                MessageBox.Show("Podaci su uspješno spremljeni u XML datoteku.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom spremanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda za učitavanje liste vozila iz XML datoteke
        private void UcitajIzXML()
        {
            try
            {
                if (File.Exists("vozila.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Vozilo>));
                    using (FileStream fs = new FileStream("vozila.xml", FileMode.Open))
                    {
                        vozila = (List<Vozilo>)serializer.Deserialize(fs);
                    }
                    UpdateVozilaList();
                    MessageBox.Show("Podaci su uspješno učitani iz XML datoteke.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("XML datoteka ne postoji.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremiXML_Click(object sender, EventArgs e)
        {
            SpremiUXML();
        }

        private void btnUcitajXML_Click(object sender, EventArgs e)
        {
            UcitajIzXML();
        }
    }
}
