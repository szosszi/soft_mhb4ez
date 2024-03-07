using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlasi
{
    internal class VillogoGomb:Button
    {
        public VillogoGomb()
        {
            MouseLeave += VillogoGomb_MouseLeave;
            MouseEnter += VillogoGomb_MouseEnter;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
           
            this.BackColor = SystemColors.ButtonFace;
        }
    }
}
