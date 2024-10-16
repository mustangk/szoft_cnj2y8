using Adatbázis_feladat.Data;
using Adatbázis_feladat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbázis_feladat
{
    public partial class RendelesForm : Form
    {
        private RendelesDbContext _context;
        public RendelesForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void RendelesForm_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
            LoadTermekek();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
            LoadTermekek();
        }

        private void LoadUgyfelek()
        {
            var q = from x in _context.Ugyfel
                    where x.Nev.Contains(textBox1.Text) || x.Email.Contains(textBox1.Text)
                    orderby x.Nev
                    select x;

            ugyfelBindingSource.DataSource = q.ToList();

            ugyfelBindingSource.ResetCurrentItem();
        }

        private void LoadTermekek()
        {
            var q = from x in _context.Termek
                    orderby x.Nev
                    select x;

            termekBindingSource.DataSource = q.ToList();

            termekBindingSource.ResetCurrentItem();
        }

        private void LoadCimek()
        {
            var q = from x in _context.Cim
                    select new CimEgybenDTO
                    {
                        CimId = x.CimId,
                        CimEgyben = $"{x.Iranyitoszam}-{x.Varos}, {x.Orszag}: {x.Utca} {x.Hazszam}"
                    };

            cimEgybenDTOBindingSource.DataSource = q.ToList();
            cimEgybenDTOBindingSource.ResetCurrentItem();
        }

        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            dataGridView1.DataSource = null;

            var rendelesek = from x in _context.Rendeles where x.UgyfelId == listBox1.SelectedValue as int? select x;
            rendelesBindingSource.DataSource = rendelesek.ToList();

            listBox2.DataSource = rendelesBindingSource;

            if (listBox2.Items.Count > 0)
            {
                listBox2.SelectedIndex = 0;
            }

            rendelesBindingSource.ResetCurrentItem();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
            LoadCimek();
        }

        private void LoadRendelesTetel()
        {
            if (rendelesBindingSource.Current == null) return;

            var q = from rt in _context.RendelesTetel
                    where rt.RendelesId == ((Rendeles)rendelesBindingSource.Current).RendelesId
                    select new RendelesTetelDTO
                    {
                        TetelId = rt.TetelId,
                        TermekNev = rt.Termek.Nev,
                        Mennyiseg = rt.Mennyiseg,
                        EgysegAr = rt.EgysegAr,
                        Afa = rt.Afa,
                        NettoAr = rt.NettoAr,
                        BruttoAr = rt.BruttoAr
                    };

            dataGridView1.DataSource = q.ToList();
            // UpdateVegosszeg(); ez egyelőre maradjon kommentelve, később implementáljuk
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetel();
            label9.Text = $"A rendelés teljes értéke: {((Rendeles)rendelesBindingSource.Current).Vegosszeg} Ft";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            // Ha van beállítva az ügyfélhez alapértelmezett lakcím, akkor azt adja vissza, egyéb esetben a címek közül a legelsőt.
            var cim = ((Ugyfel)ugyfelBindingSource.Current).Lakcim ?? _context.Cim.FirstOrDefault();

            if (cim == null)
            {
                MessageBox.Show("Nincs cím megadva.");
                return;
            }

            var ujRendeles = new Rendeles()
            {
                UgyfelId = ((Ugyfel)ugyfelBindingSource.Current).UgyfelId,
                SzallitasiCimId = cim.CimId,
                RendelesDatum = DateTime.Now,
                Kedvezmeny = 0,
                Vegosszeg = 0,
                Statusz = "Feldolgozás alatt"
            };

            _context.Rendeles.Add(ujRendeles);
            Mentés();

            label9.Text = $"A rendelés teljes értéke: {ujRendeles.Vegosszeg} Ft";

            LoadRendelesek();

            listBox2.SelectedItem = ujRendeles;
        }

        private void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private const decimal AFA = .27m;

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiség!");
                return;
            }

            if (rendelesBindingSource.Current == null || termekBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva rendelés vagy termék!");
                return;
            }

            var kivalasztottTermek = (Termek)termekBindingSource.Current;

            decimal bruttoAr = kivalasztottTermek.AktualisAr * (1 + AFA);

            var ujTetel = new RendelesTetel
            {
                RendelesId = ((Rendeles)rendelesBindingSource.Current).RendelesId,
                TermekId = kivalasztottTermek.TermekId,
                Mennyiseg = mennyiseg,
                EgysegAr = kivalasztottTermek.AktualisAr,
                Afa = AFA,
                NettoAr = kivalasztottTermek.AktualisAr * mennyiseg,
                BruttoAr = bruttoAr
            };

            _context.RendelesTetel.Add(ujTetel);
            Mentés();

            LoadRendelesTetel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztva tétel!");
                return;
            }

            var selectedTetel = dataGridView1.SelectedRows[0].DataBoundItem as RendelesTetelDTO;

            var tetel = (from rt in _context.RendelesTetel
                         where rt.TetelId == selectedTetel!.TetelId
                         select rt).FirstOrDefault();

            if (tetel != null)
            {
                _context.RendelesTetel.Remove(tetel);
                Mentés();

                LoadRendelesTetel();
            }
        }

        private void UpdateVegosszeg()
        {
            if (rendelesBindingSource.Current == null) return;

            var kivalasztottRendeles = (Rendeles)rendelesBindingSource.Current;

            var vegosszeg = _context.RendelesTetel
                .Where(rt => rt.RendelesId == kivalasztottRendeles.RendelesId)
                .Sum(rt => rt.Mennyiseg * rt.BruttoAr);

            kivalasztottRendeles.Vegosszeg = vegosszeg * (1 - kivalasztottRendeles.Kedvezmeny/100);

            Mentés();

            rendelesBindingSource.ResetBindings(false);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UpdateVegosszeg();
        }
    }
}
