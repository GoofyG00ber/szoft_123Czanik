using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_1_gyakorlas
{
    internal class ValtoGomb : Button
    {
        public ValtoGomb()
        {
            MouseClick += ValtoGomb_MouseClick;
        }

        private void ValtoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (!be)
            {
                BackColor = Color.Red;
                be = true;
            }
            else
            {
                BackColor = Color.Transparent;
                be = false;
            }
        }

        bool be = false;

    }
}
