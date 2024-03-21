using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyok_kigyoznak
{
    internal class KigyoElem:PictureBox
    {
        public static int meret = 20;
        public KigyoElem()
        {
            this.Width = KigyoElem.meret;
            this.Height = KigyoElem.meret;
            this.BackColor = Color.Green;
        }
    }
}
