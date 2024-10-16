namespace Adatbázis_feladat
{
    partial class RendelesForm
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            rendelesBindingSource = new BindingSource(components);
            cimEgybenDTOBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            listBox1 = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox3 = new ListBox();
            termekBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(267, 572);
            button1.Name = "button1";
            button1.Size = new Size(172, 56);
            button1.TabIndex = 0;
            button1.Text = "Új rendelés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", rendelesBindingSource, "SzallitasiCimId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox1.DataSource = cimEgybenDTOBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(461, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 23);
            comboBox1.TabIndex = 1;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // cimEgybenDTOBindingSource
            // 
            cimEgybenDTOBindingSource.DataSource = typeof(CimEgybenDTO);
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Statusz", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Feldolgozás alatt", "Szállítás", "Kiszállítva", "Kiszállítva" });
            comboBox2.Location = new Point(915, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(575, 433);
            dataGridView1.TabIndex = 3;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Kedvezmeny", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.00%"));
            textBox2.Location = new Point(809, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1055, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(1055, 247);
            button4.Name = "button4";
            button4.Size = new Size(100, 64);
            button4.TabIndex = 9;
            button4.Text = "Tétel hozzáadása";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.DataSource = ugyfelBindingSource;
            listBox1.DisplayMember = "Nev";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(7, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 484);
            listBox1.TabIndex = 11;
            listBox1.ValueMember = "UgyfelId";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // listBox2
            // 
            listBox2.DataSource = rendelesBindingSource;
            listBox2.DisplayMember = "RendelesDatum";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(267, 75);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(172, 484);
            listBox2.TabIndex = 12;
            listBox2.ValueMember = "RendelesId";
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 14;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 56);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 15;
            label2.Text = "Ügyfelek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 56);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 16;
            label3.Text = "Rendelések";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 51);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 17;
            label4.Text = "Rendelés címe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(809, 57);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 18;
            label5.Text = "Kedvezmény";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(915, 57);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 19;
            label6.Text = "Státusz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1055, 171);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 20;
            label7.Text = "Mennyiség";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1177, 56);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 21;
            label8.Text = "Termékek";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(461, 572);
            label9.Name = "label9";
            label9.Size = new Size(152, 15);
            label9.TabIndex = 22;
            label9.Text = "A rendelés teljes értéke: 0 Ft";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(461, 108);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 24;
            label11.Text = "Rendelt tételek";
            // 
            // button5
            // 
            button5.Location = new Point(1055, 341);
            button5.Name = "button5";
            button5.Size = new Size(100, 64);
            button5.TabIndex = 25;
            button5.Text = "Tétel törlése";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(686, 565);
            button2.Name = "button2";
            button2.Size = new Size(172, 56);
            button2.TabIndex = 26;
            button2.Text = "Mentés";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(864, 565);
            button3.Name = "button3";
            button3.Size = new Size(172, 56);
            button3.TabIndex = 27;
            button3.Text = "Excel export";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.DataSource = termekBindingSource;
            listBox3.DisplayMember = "Nev";
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(1177, 75);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(172, 484);
            listBox3.TabIndex = 28;
            listBox3.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // RendelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 651);
            Controls.Add(listBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "RendelesForm";
            Text = "RendelesForm";
            Load += RendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button5;
        private Button button2;
        private Button button3;
        private BindingSource ugyfelBindingSource;
        private ListBox listBox3;
        private BindingSource termekBindingSource;
        private BindingSource cimEgybenDTOBindingSource;
        private BindingSource rendelesBindingSource;
    }
}