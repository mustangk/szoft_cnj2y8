using Adatbázis_feladat.Data;
using Adatbázis_feladat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adatbázis_feladat
{
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext context;

        private List<string> _expandedPaths = new List<string>();
        public TermekKategoriaForm()
        {
            InitializeComponent();
            context = new RendelesDbContext();
            LoadKategoriak();

        }

        private void LoadKategoriak()
        {
            treeViewKategoriak.Nodes.Clear();
            var kategoriak = (from k in context.TermekKategoria select k).ToList();
            var fokategoriak = from k in kategoriak where k.SzuloKategoriaId == null select k;
            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }

        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszesKategoria)
        {
            var node = new TreeNode(kategoria.Nev)
            {
                Tag = kategoria
            };
            var alkategoriak = from k in osszesKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;
            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszesKategoria));
            }
            return node;
        }


        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                textBoxNev.Text = selectedKategoria.Nev;
                textBoxLeiras.Text = selectedKategoria.Leiras;
                treeViewKategoriak.ContextMenuStrip = contextMenuStripKategoria;
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (!(treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)) { return; }
            if (string.IsNullOrWhiteSpace(textBoxNev.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedKategoria.Nev = textBoxNev.Text;
            selectedKategoria.Leiras = textBoxLeiras.Text;
            try
            {
                context.SaveChanges();
                LoadKategoriak();
                textBoxNev.Clear();
                textBoxLeiras.Clear();
                MessageBox.Show("A változtatások sikeresen mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void átnevezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                treeViewKategoriak.SelectedNode.BeginEdit();
            }
        }

        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null && string.IsNullOrEmpty(e.Label))
            {
                MessageBox.Show("Válassz ki egy elemet!");
                return;
            }

            TermekKategoria átvevezettKategoria = (TermekKategoria)e.Node.Tag;
            átvevezettKategoria.Nev = e.Label;
            context.SaveChanges();
        }

        private void újFőkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria újtk = new();
            újtk.Nev = "Add meg a ketegória nevét!";
            újtk.SzuloKategoriaId = null;
            context.TermekKategoria.Add(újtk);
            context.SaveChanges();

            TreeNode újtn = new(újtk.Nev);
            újtn.Tag = újtk;
            treeViewKategoriak.Nodes.Add(újtn);
            treeViewKategoriak.SelectedNode = újtn;
            újtn.BeginEdit();
        }

        private void újAlkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode == null)
            {
                MessageBox.Show("Válassz ki egy elemet!");
                return;
            }

            TermekKategoria kategoria = new TermekKategoria();
            kategoria.Nev = "Add meg a ketegória nevét!";
            kategoria.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).SzuloKategoriaId;
            context.TermekKategoria.Add(kategoria);
            context.SaveChanges();

            TreeNode újtn = new(kategoria.Nev);
            újtn.Tag = kategoria;
            treeViewKategoriak.SelectedNode.Nodes.Add(újtn);
            treeViewKategoriak.SelectedNode = újtn;
            újtn.BeginEdit();
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKategoriak();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode == null)
            {
                MessageBox.Show("Válassz ki egy elemet!");
                return;
            }
            
            foreach (var item in context.Termek)
                {
                if (item.Kategoria == treeViewKategoriak.SelectedNode.Tag)
                {
                    MessageBox.Show("Már vannak ebben a kategóriában termékek!");
                    return;
                }
                }

            if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
            {
                var confirmResult = MessageBox.Show("Biztosan ki akarod törölni ezt az elemet?",
                                     "Törlés",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    TermekKategoria kategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                    context.TermekKategoria.Remove(kategoria);
                    context.SaveChanges();

                    treeViewKategoriak.Nodes.Remove(treeViewKategoriak.SelectedNode);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nem törölhető kategória!");
            }
        }

        private void treeViewKategoriak_MouseDown(object sender, MouseEventArgs e)
        {
            // Step 1: Check if the right mouse button is clicked
            if (e.Button == MouseButtons.Right)
            {
                // Step 2: Get the node at the mouse position
                TreeNode clickedNode = treeViewKategoriak.GetNodeAt(e.X, e.Y);

                if (clickedNode != null)
                {
                    // Step 3: Select the node under the cursor
                    treeViewKategoriak.SelectedNode = clickedNode;

                    // Step 4: Show the context menu at the mouse position
                    contextMenuStripKategoria.Show(treeViewKategoriak, e.Location);
                }
            }
        }
    }
}
