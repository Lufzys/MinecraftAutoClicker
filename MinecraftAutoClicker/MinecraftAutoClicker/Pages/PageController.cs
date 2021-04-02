using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftAutoClicker.Pages
{
    public static class PageController
    {
        public static PageFeatures Features = new PageFeatures();
        public static PageSettings Settings = new PageSettings();
        public static void ChangePage(this Panel placeholder, Control cntrl)
        {
            placeholder.Controls.Clear();
            placeholder.Controls.Add(cntrl);
        }
    }
}
