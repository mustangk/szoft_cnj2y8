using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.hét
{
    internal class VillogóGomb : Button
    {
        public VillogóGomb()
        {
            MouseEnter += VillogóGomb_MouseEnter;
            MouseLeave += VillogóGomb_MouseLeave;
        }

        private void VillogóGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void VillogóGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
