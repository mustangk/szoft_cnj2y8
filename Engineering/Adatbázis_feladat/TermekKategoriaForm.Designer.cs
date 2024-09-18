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
            treeViewKategoriak = new TreeView();
            textBoxNev = new TextBox();
            textBoxLeiras = new TextBox();
            buttonMentes = new Button();
            buttonUjTestver = new Button();
            buttonUjGyermek = new Button();
            buttonTorles = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(12, 26);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(343, 324);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
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
            buttonMentes.Location = new Point(599, 327);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(75, 23);
            buttonMentes.TabIndex = 3;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonUjTestver
            // 
            buttonUjTestver.Location = new Point(401, 327);
            buttonUjTestver.Name = "buttonUjTestver";
            buttonUjTestver.Size = new Size(75, 23);
            buttonUjTestver.TabIndex = 4;
            buttonUjTestver.Text = "Új testvér";
            buttonUjTestver.UseVisualStyleBackColor = true;
            // 
            // buttonUjGyermek
            // 
            buttonUjGyermek.Location = new Point(502, 327);
            buttonUjGyermek.Name = "buttonUjGyermek";
            buttonUjGyermek.Size = new Size(75, 23);
            buttonUjGyermek.TabIndex = 5;
            buttonUjGyermek.Text = "Új gyermek";
            buttonUjGyermek.UseVisualStyleBackColor = true;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(692, 327);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(75, 23);
            buttonTorles.TabIndex = 6;
            buttonTorles.Text = "Törlés";
            buttonTorles.UseVisualStyleBackColor = true;
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
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonTorles);
            Controls.Add(buttonUjGyermek);
            Controls.Add(buttonUjTestver);
            Controls.Add(buttonMentes);
            Controls.Add(textBoxLeiras);
            Controls.Add(textBoxNev);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox textBoxNev;
        private TextBox textBoxLeiras;
        private Button buttonMentes;
        private Button buttonUjTestver;
        private Button buttonUjGyermek;
        private Button buttonTorles;
        private Label label1;
        private Label label2;
    }
}