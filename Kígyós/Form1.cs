namespace Kígyós
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        int lépésszám;
        int hossz = 5;

        List<KígyóElem> kígyó = new List<KígyóElem>();
        Random rnd = new Random();

        int szín;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    
                    KígyóElem k = (KígyóElem)item;

                    if (szín % 2 == 0) k.BackColor = Color.Green;
                    else k.BackColor = Color.Red;
                    szín++;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Vége a játéknak!");
                        return;
                    }
                }
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            Controls.Add(ke);

            if (Controls.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            //kaja
            if (lépésszám % 2 == 0)
            {
                Kaja k = new Kaja();
                k.Top = rnd.Next(ClientRectangle.Bottom);
                k.Left = rnd.Next(ClientRectangle.Right);
                Controls.Add(k);
            }

            foreach (object item in Controls) {
                
                if (item is Kaja)
                {
                    Kaja k = (Kaja)item;

                    if (Math.Abs(k.Top - fej_y)<10 && Math.Abs(k.Left - fej_x)<10)
                    {
                        Controls.Remove(k);
                        hossz++;
                        KígyóElem új = new KígyóElem();
                        új.Top = fej_y;
                        új.Left = fej_x;
                        kígyó.Add(új);
                        Controls.Add(új);
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}