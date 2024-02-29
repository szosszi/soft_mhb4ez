using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik
{
    internal class villogoGomb: Button
    {
        public villogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            
            BackColor = Color.Fuchsia;
            
        }
    }
}
