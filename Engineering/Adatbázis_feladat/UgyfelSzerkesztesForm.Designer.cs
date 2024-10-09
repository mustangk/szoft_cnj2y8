namespace Adatbázis_feladat
{
    partial class UgyfelSzerkesztesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ugyfelBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 85);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefonszám";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 216);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Ország";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 246);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 6;
            label7.Text = "Irányítószám";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 275);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 7;
            label8.Text = "Város";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 304);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 8;
            label9.Text = "Utca";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 333);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 9;
            label10.Text = "Házszám";
            // 
            // button1
            // 
            button1.Location = new Point(186, 375);
            button1.Name = "button1";
            button1.Size = new Size(286, 23);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(186, 415);
            button2.Name = "button2";
            button2.Size = new Size(286, 23);
            button2.TabIndex = 11;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Nev", true));
            textBox1.Location = new Point(186, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 12;
            textBox1.Validating += textBox1_Validating;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Email", true));
            textBox2.Location = new Point(186, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 13;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Telefonszam", true));
            textBox3.Location = new Point(186, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 23);
            textBox3.TabIndex = 14;
            textBox3.Validating += textBox3_Validating;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Lakcim", true));
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 23);
            comboBox1.TabIndex = 20;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 127);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(134, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Létező cím beállítása";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(33, 167);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(111, 19);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Új cím beállítása";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(286, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(186, 246);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(286, 23);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(186, 275);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(286, 23);
            textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(186, 304);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(286, 23);
            textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(186, 333);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(286, 23);
            textBox8.TabIndex = 27;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // UgyfelSzerkesztesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UgyfelSzerkesztesForm";
            Text = "UgyfelSzerkesztesForm";
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private BindingSource ugyfelBindingSource;
        private ErrorProvider errorProvider;
    }
}