using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Settings
{
    private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public static LFINI.INI ini = new LFINI.INI(path + @"\settings.ini");
    public static bool AutoClicker = false;
    public static bool FakeJitter = false;
    public static bool VisualCrosshair = false;
    public static bool Humanize = false;

    public static int Sleep = 15;
    public static int RandomizeX = 5;
    public static int RandomizeY = 5;
    public static Color Crosshair = Color.Green;

    public static void Save()
    {
        ini.Write("Features", "AutoClicker", AutoClicker);
        ini.Write("Features", "FakeJitter", FakeJitter);
        ini.Write("Features", "VisualCrosshair", VisualCrosshair);
        ini.Write("Features", "Humanize", Humanize);

        ini.Write("Settings", "Sleep", Sleep);
        ini.Write("Settings", "RandomizeX", RandomizeX);
        ini.Write("Settings", "RandomizeY", RandomizeY);
        ini.Write("Settings", "Crosshair", ColorTranslator.ToHtml(Crosshair));
    }

    public static void Load()
    {
        try
        {
            AutoClicker = bool.Parse(ini.Read("Features", "AutoClicker"));
            FakeJitter = bool.Parse(ini.Read("Features", "FakeJitter"));
            VisualCrosshair = bool.Parse(ini.Read("Features", "VisualCrosshair"));
            Humanize = bool.Parse(ini.Read("Features", "Humanize"));

            Sleep = int.Parse(ini.Read("Settings", "Sleep"));
            RandomizeX = int.Parse(ini.Read("Settings", "RandomizeX"));
            RandomizeY = int.Parse(ini.Read("Settings", "RandomizeY"));
            Crosshair = System.Drawing.ColorTranslator.FromHtml(ini.Read("Settings", "Crosshair"));
        } catch { Save(); }
    }
}
