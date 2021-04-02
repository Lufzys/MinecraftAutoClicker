using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftAutoClicker.Pages
{
    public partial class PageFeatures : UserControl
    {
        public PageFeatures()
        {
            InitializeComponent();
        }

        private void cbAutoClicker_CheckedChanged(object sender, EventArgs e)
        {
            Settings.AutoClicker = cbAutoClicker.Checked;
            Settings.Save();
        }

        private void cbFakeJitter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.FakeJitter = cbFakeJitter.Checked;
            Settings.Save();
        }

        private void cbVisualCrosshair_CheckedChanged(object sender, EventArgs e)
        {
            Settings.VisualCrosshair = cbVisualCrosshair.Checked;
            Settings.Save();
        }

        private void cbHumanize_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Humanize = cbHumanize.Checked;
            Settings.Save();
        }

        private void PageFeatures_Load(object sender, EventArgs e)
        {
            cbAutoClicker.Checked = Settings.AutoClicker;
            cbFakeJitter.Checked = Settings.FakeJitter;
            cbVisualCrosshair.Checked = Settings.VisualCrosshair;
            cbHumanize.Checked = Settings.Humanize;
        }
    }
}
