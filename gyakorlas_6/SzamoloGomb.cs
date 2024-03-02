using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_6
{
    internal class SzamoloGomb:Button
    {
        int szam = 0;
        public SzamoloGomb()
        {
            Width = 40;
            Height = 40;
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam == 5) { 
                szam = 1;
                this.Text = szam.ToString();
            }
            else
            {

                szam++;
                this.Text = szam.ToString();
            }

        }
    }
}
