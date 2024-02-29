using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.hét
{
    internal class SzámolóGomb : VillogóGomb
    {
        static int szám = 0;
        public SzámolóGomb()
        {
            Click += SzámolóGomb_Click;

            Height = 20;
            Width = 20;
        }

        private void SzámolóGomb_Click(object? sender, EventArgs e)
        {
            szám++;
            if (szám == 6)
            {
                szám = 1;
            }
            Text=szám.ToString();
        }
    }
}
