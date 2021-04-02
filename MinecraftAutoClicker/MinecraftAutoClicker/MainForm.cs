using MinecraftAutoClicker.Pages;
using MinecraftAutoClicker.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI;

namespace MinecraftAutoClicker
{
    public partial class MainForm : WinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Settings.Load();
            plPageholder.ChangePage(PageController.Features);
            ThreadsCore.thCore.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnFeatures_Click(object sender, EventArgs e)
        {
            plPageholder.ChangePage(PageController.Features);
            Settings.Save();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            plPageholder.ChangePage(PageController.Settings);
            Settings.Save();
        }
    }
}
