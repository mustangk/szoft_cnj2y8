namespace Adatbázis_feladat
{
    partial class TermekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            textBoxNev = new TextBox();
            textBoxLeiras = new TextBox();
            buttonMentes = new Button();
            label1 = new Label();
            label2 = new Label();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóriaToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            xMLFájlMentéseToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.LabelEdit = true;
            treeViewKategoriak.Location = new Point(12, 26);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(343, 324);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterLabelEdit += treeViewKategoriak_AfterLabelEdit;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            treeViewKategoriak.MouseDown += treeViewKategoriak_MouseDown;
            // 
            // textBoxNev
            // 
            textBoxNev.Location = new Point(464, 37);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(303, 23);
            textBoxNev.TabIndex = 1;
            // 
            // textBoxLeiras
            // 
            textBoxLeiras.Location = new Point(464, 92);
            textBoxLeiras.Multiline = true;
            textBoxLeiras.Name = "textBoxLeiras";
            textBoxLeiras.Size = new Size(303, 200);
            textBoxLeiras.TabIndex = 2;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(692, 327);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(75, 23);
            buttonMentes.TabIndex = 3;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 40);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 190);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Leírás:";
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { átnevezésToolStripMenuItem, újFőkategóriaToolStripMenuItem, újAlkategóriaToolStripMenuItem, törlésToolStripMenuItem, frissítésToolStripMenuItem, xMLFájlMentéseToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStrip1";
            contextMenuStripKategoria.Size = new Size(181, 158);
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(148, 22);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            átnevezésToolStripMenuItem.Click += átnevezésToolStripMenuItem_Click;
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            újFőkategóriaToolStripMenuItem.Click += újFőkategóriaToolStripMenuItem_Click;
            // 
            // újAlkategóriaToolStripMenuItem
            // 
            újAlkategóriaToolStripMenuItem.Name = "újAlkategóriaToolStripMenuItem";
            újAlkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újAlkategóriaToolStripMenuItem.Text = "Új alkategória";
            újAlkategóriaToolStripMenuItem.Click += újAlkategóriaToolStripMenuItem_Click;
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(148, 22);
            törlésToolStripMenuItem.Text = "Törlés";
            törlésToolStripMenuItem.Click += törlésToolStripMenuItem_Click;
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(148, 22);
            frissítésToolStripMenuItem.Text = "Frissítés";
            frissítésToolStripMenuItem.Click += frissítésToolStripMenuItem_Click;
            // 
            // xMLFájlMentéseToolStripMenuItem
            // 
            xMLFájlMentéseToolStripMenuItem.Name = "xMLFájlMentéseToolStripMenuItem";
            xMLFájlMentéseToolStripMenuItem.Size = new Size(180, 22);
            xMLFájlMentéseToolStripMenuItem.Text = "XML fájl mentése";
            xMLFájlMentéseToolStripMenuItem.Click += xMLFájlMentéseToolStripMenuItem_Click;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonMentes);
            Controls.Add(textBoxLeiras);
            Controls.Add(textBoxNev);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox textBoxNev;
        private TextBox textBoxLeiras;
        private Button buttonMentes;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóriaToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
        private ToolStripMenuItem xMLFájlMentéseToolStripMenuItem;
    }
}