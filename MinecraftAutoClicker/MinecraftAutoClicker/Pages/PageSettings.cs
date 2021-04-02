using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI.Controls;

namespace MinecraftAutoClicker.Pages
{
    public partial class PageSettings : UserControl
    {
        public PageSettings()
        {
            InitializeComponent();
        }

        private void tbCPS_TextChanged(object sender, EventArgs e)
        {
            if(tbSleep.Content != "")
                Settings.Sleep = int.Parse(tbSleep.Content);
            Settings.Save();
        }

        private void tbJitterRandomX_TextChanged(object sender, EventArgs e)
        {
            if (tbJitterRandomX.Content != "")
                Settings.RandomizeX = int.Parse(tbJitterRandomX.Content);
            Settings.Save();
        }

        private void tbJitterRandomY_TextChanged(object sender, EventArgs e)
        {
            if (tbJitterRandomY.Content != "")
                Settings.RandomizeY = int.Parse(tbJitterRandomY.Content);
            Settings.Save();
        }

        private void pbVisualCrosshair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress", "Auto Clicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //cpVisualCrosshair.Visible = !cpVisualCrosshair.Visible;
            //Settings.Save();
        }

        private void cpVisualCrosshair_ColorChanged(object sender, WindowsUI.Controls.ColorChangedEventArgs e)
        {
            pbVisualCrosshair.BackColor = e.Color;
            Settings.Crosshair = pbVisualCrosshair.BackColor;
        }

        private void PageSettings_Load(object sender, EventArgs e)
        {
            tbSleep.Content = Settings.Sleep.ToString();
            tbJitterRandomX.Content = Settings.RandomizeX.ToString();
            tbJitterRandomY.Content = Settings.RandomizeY.ToString();
            pbVisualCrosshair.BackColor = Settings.Crosshair;
        }
    }
}
