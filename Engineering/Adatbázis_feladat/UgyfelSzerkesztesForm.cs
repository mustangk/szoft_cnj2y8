using Adatbázis_feladat.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Adatbázis_feladat
{
    public partial class UgyfelSzerkesztesForm : Form
    {
        public Ugyfel SzerkesztettÜgyfél { get; set; }
        public UgyfelSzerkesztesForm(Ugyfel ugyfel = null)
        {
            InitializeComponent();
            SzerkesztettÜgyfél = ugyfel ?? new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettÜgyfél;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Kérjük javítsa a hibás mezőket!");
                return;
            }


            ugyfelBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxNev = new Regex(@"^[\p{L} .'-]+$");

            if (!rgxNev.IsMatch(textBox1.Text))
            {
                errorProvider.SetError(textBox1, "A név nem megfelelő formátumú.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);

            if (!rgxEmail.IsMatch(textBox2.Text))
            {
                errorProvider.SetError(textBox2, "Az email nem megfelelő formátumú.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxTelefonszam = new Regex(@"^\+36(?:20|30|31|50|70)(\d{7})$");

            if (!rgxTelefonszam.IsMatch(textBox3.Text))
            {
                errorProvider.SetError(textBox3, "A telefonszám nem megfelelő formátumú.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider.SetError(textBox3, "");
            }
        }
    }
}
