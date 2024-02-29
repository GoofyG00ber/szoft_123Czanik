using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.hét
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            if (Text == "")
            {
                BackColor = Color.Transparent;
            }
        }


        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }

    }
}
