namespace HajósTeszt
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktuálisKérdések;
        int MegjelenítettKérdésSzáma = 5;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = new List<Kérdés>();
            AktuálisKérdések = new List<Kérdés>();

            ÖsszesKérdés = KérdésekBetöltése();


            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }

            dataGridView1.DataSource = AktuálisKérdések;
            KérdésMegjelenítés(AktuálisKérdések[MegjelenítettKérdésSzáma]);
        }
        List<Kérdés> KérdésekBetöltése()
        {
            List<Kérdés> kérdések = new List<Kérdés>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string? sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                Kérdés k = new();
                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3].Trim('"');
                k.Válasz3 = tömb[4].Trim('"');
                k.URL = tömb[5];

                int.TryParse(tömb[6], out int x);
                k.HelyesVálasz = x;

                kérdések.Add(k);
            }
            sr.Close();
            return kérdések;
        }

        void KérdésMegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenítettKérdésSzáma++;
            if (MegjelenítettKérdésSzáma == AktuálisKérdések.Count) MegjelenítettKérdésSzáma = 0;

            KérdésMegjelenítés(AktuálisKérdések[MegjelenítettKérdésSzáma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            Szinezés();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            Szinezés();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            Szinezés();
        }

        void Szinezés()
        {
            int helyesVálasz = AktuálisKérdések[MegjelenítettKérdésSzáma].HelyesVálasz;
            if (helyesVálasz == 1) textBox1.BackColor = Color.LightGreen;
            if (helyesVálasz == 2) textBox2.BackColor = Color.LightGreen;
            if (helyesVálasz == 3) textBox3.BackColor = Color.LightGreen;
        }
    }
}