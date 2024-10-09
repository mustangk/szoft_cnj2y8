﻿namespace Adatbázis_feladat
{
    partial class UgyfelListaForm
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            buttonÚj = new Button();
            buttonMódosítás = new Button();
            buttonTörlés = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(794, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, rendelesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(794, 377);
            dataGridView1.TabIndex = 1;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // buttonÚj
            // 
            buttonÚj.Location = new Point(3, 412);
            buttonÚj.Name = "buttonÚj";
            buttonÚj.Size = new Size(147, 36);
            buttonÚj.TabIndex = 2;
            buttonÚj.Text = "Új ügyfél hozzáadása";
            buttonÚj.UseVisualStyleBackColor = true;
            buttonÚj.Click += buttonÚj_Click;
            // 
            // buttonMódosítás
            // 
            buttonMódosítás.Location = new Point(306, 412);
            buttonMódosítás.Name = "buttonMódosítás";
            buttonMódosítás.Size = new Size(147, 36);
            buttonMódosítás.TabIndex = 3;
            buttonMódosítás.Text = "Ügyfél módosítása";
            buttonMódosítás.UseVisualStyleBackColor = true;
            buttonMódosítás.Click += buttonMódosítás_Click;
            // 
            // buttonTörlés
            // 
            buttonTörlés.Location = new Point(641, 412);
            buttonTörlés.Name = "buttonTörlés";
            buttonTörlés.Size = new Size(147, 36);
            buttonTörlés.TabIndex = 4;
            buttonTörlés.Text = "Ügyfél törlése";
            buttonTörlés.UseVisualStyleBackColor = true;
            buttonTörlés.Click += buttonTörlés_Click;
            // 
            // UgyfelListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTörlés);
            Controls.Add(buttonMódosítás);
            Controls.Add(buttonÚj);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "UgyfelListaForm";
            Text = "UgyfelListaForm";
            Load += UgyfelListaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button buttonÚj;
        private Button buttonMódosítás;
        private Button buttonTörlés;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
        private BindingSource ugyfelBindingSource;
    }
}