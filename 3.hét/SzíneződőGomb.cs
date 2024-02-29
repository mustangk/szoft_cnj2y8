using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.hét
{
    internal class SzíneződőGomb : Button
    {
        public SzíneződőGomb()
        {
            Width = 20;
            Height = 20;

            Click += SzíneződőGomb_Click;
        }

        private void SzíneződőGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
