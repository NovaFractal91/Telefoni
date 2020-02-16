using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefoni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSifraProizvoda.Text == "")
            {
                MessageBox.Show("Niste izabrali proizvod!");
                return;
            }

            if (txtProizvodjac.Text == "")
            {
                MessageBox.Show("Unesite ime proizvodjaca.");
                return;
            }

            if(txtModel.Text == "")
            {
                MessageBox.Show("Unesite ime modela.");
                return;
            }

            smartTelefoniTableAdapter.IzmeniProizvod(
               txtProizvodjac.Text, txtModel.Text, dtpDatumIzdavanja.Value, txtSifraProizvoda.Text);

            smartTelefoniTableAdapter.Fill(smartTelefoniDataSet.SmartTelefoni);

            MessageBox.Show("Proizvod je uspesno izmenjen.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartTelefoniDataSet.SmartTelefoni' table. You can move, or remove it, as needed.
            this.smartTelefoniTableAdapter.Fill(this.smartTelefoniDataSet.SmartTelefoni);

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            SmartTelefoniDataSet.SmartTelefoniDataTable tabelaTelefoni = smartTelefoniDataSet.SmartTelefoni;
 
            
                if(txtSifraProizvoda.Text != "")
                {
                    tabelaTelefoni = smartTelefoniTableAdapter.PretraziPoSifri(txtSifraProizvoda.Text);
                }
            
            
            {
                tabelaTelefoni = smartTelefoniTableAdapter.PretragaTelefona(txtSifraProizvoda.Text, txtProizvodjac.Text, txtModel.Text);

            }
            gridTelefoni.DataSource = tabelaTelefoni;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtSifraProizvoda.Text == "")
            {
                MessageBox.Show("Unesite sifru proizvoda.");
                return;
            }

            if (txtProizvodjac.Text == "")
            {
                MessageBox.Show("Unesite ime proizvodjaca.");
                return;
            }

            if (txtModel.Text == "")
            {
                MessageBox.Show("Unesite model telefona.");
                return;
            }

            if(smartTelefoniTableAdapter.VratiTelefon(txtSifraProizvoda.Text)==1)
            {
                MessageBox.Show("Vec postoji proizvod sa tom sifrom koju ste uneli!");
                return;
            }

            smartTelefoniTableAdapter.UbaciTelefon(txtSifraProizvoda.Text, txtProizvodjac.Text, txtModel.Text, dtpDatumIzdavanja.Value);

            smartTelefoniTableAdapter.Fill(smartTelefoniDataSet.SmartTelefoni);

            txtSifraProizvoda.Text = "";
            txtProizvodjac.Text = "";
            txtModel.Text = "";
            dtpDatumIzdavanja.Value = DateTime.Now;
            MessageBox.Show("Telefon je uspesno dodat.");
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (txtSifraProizvoda.Text == "" || txtProizvodjac.Text=="" || txtModel.Text=="")
            {
                MessageBox.Show("Izaberite proizvod");
                return;
           
            }
            {
                DialogResult dlg =
                    MessageBox.Show("Da li ste sigurni da obriste telefon iz baze?", "Brisanje telefona", MessageBoxButtons.YesNo);

                if (dlg == DialogResult.No)
                {
                    return;
                }

                string SifraProizvoda = Convert.ToString(gridTelefoni.SelectedRows[0].Cells[0].Value);

                smartTelefoniTableAdapter.IzbrisiTelefon(SifraProizvoda);
                smartTelefoniTableAdapter.Fill(smartTelefoniDataSet.SmartTelefoni);

                MessageBox.Show("telefon je uspesno obrisan.");
            }


        }
    
        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            string SifraProizvoda = Convert.ToString(
                gridTelefoni.SelectedRows[0].Cells[0].Value);

            SmartTelefoniDataSet.SmartTelefoniDataTable tabelaTelefoni =
               smartTelefoniTableAdapter.PretraziPoSifri(SifraProizvoda);

            txtSifraProizvoda.Text = tabelaTelefoni[0]["Sifra proizvoda"].ToString();
            txtProizvodjac.Text = tabelaTelefoni[0]["Proizvodjac"].ToString();
            txtModel.Text = tabelaTelefoni[0]["Model"].ToString();
            dtpDatumIzdavanja.Value = Convert.ToDateTime(
                tabelaTelefoni[0]["Datum izdavanja"]);
        }
    }
}
