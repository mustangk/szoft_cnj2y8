namespace _3.hét
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button sajátGomb = new Button();
            Controls.Add(sajátGomb);
            sajátGomb.Width = 40;
            sajátGomb.Height = 40;
            
            sajátGomb.Top = ClientRectangle.Height/2 - sajátGomb.Height/2;
            sajátGomb.Left = ClientRectangle.Width/2 - sajátGomb.Width/2;

            int méret = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzámolóGomb b = new();
                    Controls.Add(b);
                    b.Width = méret;
                    b.Height = méret;

                    b.Top = sor * méret;
                    b.Left = oszlop * méret;

                    //b.Text = (oszlop * sor).ToString();
                }
            }

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                Button gomb = new();
                Controls.Add(gomb);

                gomb.Width = 40;
                gomb.Height = 40;
                
                gomb.Top = rnd.Next(0, ClientRectangle.Height);
                gomb.Left = rnd.Next(0, ClientRectangle.Width);

                gomb.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
        }
    }
}