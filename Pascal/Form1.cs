namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Faktorialis(int n)
        {
            int eredmény = 1;
            for (int i = 1; i <= n; i++) eredmény *= i;
            return eredmény;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    Button button = new();
                    Controls.Add(button);
                    button.Left = oszlop*n-sor*n/2 + 300;
                    button.Top = sor*n;
                    button.Height = n;
                    button.Width = n;

                    int x = Faktorialis(sor) / (Faktorialis(oszlop) * Faktorialis(sor - oszlop));
                    button.Text = x.ToString();
                }
                
            }
        }
    }
}