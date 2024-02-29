using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.hét
{
    internal class SzamoloGomb : VillogoGomb
    {
        public SzamoloGomb()
        {
            MouseClick += SzamoloGomb_MouseClick;
        }

        public int i = 0;

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (i >= 6)
            {
                i = 0;
            }
            else
            {
                BackColor = Color.FromArgb(i*40,60,140);
                i++;
                Text = i.ToString();
            }
        }
    }
}
