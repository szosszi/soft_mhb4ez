using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_6
{
     internal class VillogoGomb:Button
    {
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }
}
