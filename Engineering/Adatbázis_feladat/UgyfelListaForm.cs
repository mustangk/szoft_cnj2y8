using Adatbázis_feladat.Data;
using Adatbázis_feladat.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Adatbázis_feladat
{
    public partial class UgyfelListaForm : Form
    {
        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;
        public UgyfelListaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void UgyfelListaForm_Load(object sender, EventArgs e)
        {
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            ugyfelBindingSource.DataSource = from u in ugyfelBindingList
                                             where u.Nev.ToLower().Contains(filterString) ||
                                    u.Email.ToLower().Contains(filterString) ||
                                    (u.Telefonszam != null && u.Telefonszam.Contains(filterString))
                                             orderby u.UgyfelId
                                             select u;
        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            UgyfelSzerkesztesForm ujUgyfelForm = new UgyfelSzerkesztesForm();
            if (ujUgyfelForm.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingList.Add(ujUgyfelForm.SzerkesztettÜgyfél);
                Mentés();
            }
        }

        void Mentés()
        {
            try
            {
                _context.SaveChanges();
                _context.Ugyfel.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void buttonMódosítás_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            UgyfelSzerkesztesForm ugyfelSzerkesztesForm = new UgyfelSzerkesztesForm(ugyfelBindingSource.Current as Ugyfel);
            if (ugyfelSzerkesztesForm.ShowDialog() == DialogResult.OK)
            {
                Mentés();
            }
            else
            {
                _context.Ugyfel.Load();
            }

        }

        private void buttonTörlés_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Biztosan törölni szeretnéd a kiválasztott ügyfelet?",
                                     "Törlés megerősítése",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ugyfelBindingSource.RemoveCurrent();
                Mentés();
                return;
            }
            else
            {
                return;
            }

        }
    }
}
