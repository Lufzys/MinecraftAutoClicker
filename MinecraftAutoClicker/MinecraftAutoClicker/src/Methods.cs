using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftAutoClicker.src
{
    class Methods
    {
        public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey)
        {
            return 0 != (Imports.GetAsyncKeyState(vKey) & 0x8000);
        }

        private static Random r = new Random();
        public static int RandomInt(int min, int max)
        {
            return r.Next(min, max);
        }

        public static Process GetForegroundProcess()
        {
            uint processID = 0;
            IntPtr hWnd = Imports.GetForegroundWindow(); // Get foreground window handle
            uint threadID = Imports.GetWindowThreadProcessId(hWnd, out processID); // Get PID from window handle
            Process fgProc = Process.GetProcessById(Convert.ToInt32(processID)); // Get it as a C# obj.
            // NOTE: In some rare cases ProcessID will be NULL. Handle this how you want. 
            return fgProc;
        }
    }
}
