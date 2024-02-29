using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik
{
    internal class szamoloGomb:villogoGomb
    {
        public int szam = 1;
        public szamoloGomb()
        {
            
            MouseClick += SzamoloGomb_MouseClick;
            Text = szam.ToString();
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam < 5)
            {
                szam++;
                Text = (szam).ToString();
            }
            else {
                szam = 0;
                Text = "0";
            }


        }
    }
}
