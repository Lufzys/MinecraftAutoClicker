using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LFInput;
using static MinecraftAutoClicker.src.CursorExtensions;

namespace MinecraftAutoClicker.src
{
    class ThreadsCore
    {
        public static Thread thCore = new Thread(new ThreadStart(Core));
        static int state = 0;

        public static void Core()
        {
            while (true)
            {   
                if(Methods.GetForegroundProcess().ProcessName == "javaw")
                {
                    if (Methods.IsKeyPushedDown(System.Windows.Forms.Keys.RButton))
                    {
                        if(Settings.AutoClicker)
                        {
                            Point realcursor = Cursor.Position;
                            LFInput.LFInput.Click(LFInput.LFInput.Enums.Buttons.LEFT, (Settings.Humanize) ? (Settings.Sleep + Methods.RandomInt(5, 20)) : Settings.Sleep, true);
                            if (Settings.FakeJitter)
                            {
                                if (state == 0)
                                {
                                    LFInput.LFInput.Move(Cursor.Position.X - (Settings.RandomizeX + Methods.RandomInt(5, 15)), Cursor.Position.Y + 6);
                                    state = 1;
                                }
                                else
                                {
                                    LFInput.LFInput.Move(Cursor.Position.X + (Settings.RandomizeX + Methods.RandomInt(5, 15)), Cursor.Position.Y + 6);
                                    state = 0;
                                }
                            }
                        }
                    }
                }

                Thread.Sleep(5);
            }
        }
    }
}
