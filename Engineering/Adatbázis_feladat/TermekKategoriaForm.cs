using Adatbázis_feladat.Data;
using Adatbázis_feladat.Models;
using Microsoft.EntityFrameworkCore;
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

        public void SaveExpandedRows(System.Windows.Forms.TreeView treeView)
        {
            _expandedPaths = GetExpandedNodePaths(treeView.Nodes);
        }

        private List<string> GetExpandedNodePaths(TreeNodeCollection nodes, string parentPath = "")
        {
            var paths = new List<string>();
            foreach (TreeNode node in nodes)
            {
                string currentPath = string.IsNullOrEmpty(parentPath) ? node.Name : $"{parentPath}/{node.Name}";
                if (node.IsExpanded)
                {
                    paths.Add(currentPath);
                }
                paths.AddRange(GetExpandedNodePaths(node.Nodes, currentPath));
            }
            return paths;
        }

        public void LoadExpandedRows(System.Windows.Forms.TreeView treeView)
        {
            ExpandNodes(treeView.Nodes, _expandedPaths);
        }

        private void ExpandNodes(TreeNodeCollection nodes, List<string> expandedPaths, string parentPath = "")
        {
            foreach (TreeNode node in nodes)
            {
                string currentPath = string.IsNullOrEmpty(parentPath) ? node.Name : $"{parentPath}/{node.Name}";

                if (expandedPaths.Contains(currentPath))
                {
                    node.Expand();
                }

                ExpandNodes(node.Nodes, expandedPaths, currentPath);
            }
        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                textBoxNev.Text = selectedKategoria.Nev;
                textBoxLeiras.Text = selectedKategoria.Leiras;
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
                SaveExpandedRows(treeViewKategoriak);
                LoadKategoriak();
                LoadExpandedRows(treeViewKategoriak);
                MessageBox.Show("A változtatások sikeresen mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
