using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.hét
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int oszlop = 0; oszlop < 10; oszlop++)
            {
                for (int sor = 0; sor < 10; sor++)
                {
                    if (oszlop < sor)
                    {
                        Button b = new();
                        Controls.Add(b);
                        b.Width = 20;
                        b.Height = 20;

                        b.Top = sor * 20;
                        b.Left = oszlop * 20 - sor * 20 / 2 + 300;
                    }
                }
            }
        }
    }
}
