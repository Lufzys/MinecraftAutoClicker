using System;
using System.Runtime.InteropServices;
using System.Threading;
using static LFInput.LFInput.Enums;
using static LFInput.LFInput.Imports;

namespace LFInput
{
    class LFInput
    {
        public static void SetKeyState(Imports.ScanCodeShort scanCode, Enums.KeyState state)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = (uint)Enums.InputType.KEYBOARD;
            inputs[0].U.ki.dwFlags = (state == Enums.KeyState.DOWN ? KEYEVENTF.KEYDOWN : KEYEVENTF.KEYUP); // https://www.ownedcore.com/forums/mmo/mmo-exploits-hacks/186390-sendinput-example-c.html
            inputs[0].U.ki.wScan = scanCode;
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        public static void SetKeyState(Imports.VirtualKeyShort virtualKey, Enums.KeyState state)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = (uint)Enums.InputType.KEYBOARD;
            inputs[0].U.ki.dwFlags = (state == Enums.KeyState.DOWN ? KEYEVENTF.KEYDOWN : KEYEVENTF.KEYUP);
            inputs[0].U.ki.wVk = virtualKey;
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey)
        {
            return 0 != (GetAsyncKeyState(vKey) & 0x8000);
        }

        public static void Move(int x, int y)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = (uint)Enums.InputType.MOUSE;
            inputs[0].U.mi.mouseData = 0;
            inputs[0].U.mi.dx = GetDX(x);
            inputs[0].U.mi.dy = GetDY(y);
            inputs[0].U.mi.dwFlags = MOUSEEVENTF.ABSOLUTE | MOUSEEVENTF.MOVE;
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        public static void Click(Buttons button, int sleep = 20, bool humanize = false)
        {
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = (uint)Enums.InputType.MOUSE;
            inputs[0].U.mi.mouseData = 0;
            inputs[0].U.mi.dwFlags = (button == Buttons.RIGHT ? MOUSEEVENTF.RIGHTDOWN : MOUSEEVENTF.LEFTDOWN);
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            int humanizePtr = 0;
            if (humanize) { humanizePtr = new Random().Next(1, 10); }
            Thread.Sleep(sleep + humanizePtr);

            INPUT[] inputs1 = new INPUT[1];
            inputs1[0].type = (uint)Enums.InputType.MOUSE;
            inputs1[0].U.mi.mouseData = 0;
            inputs1[0].U.mi.dwFlags = (button == Buttons.RIGHT ? MOUSEEVENTF.RIGHTUP : MOUSEEVENTF.LEFTUP);
            SendInput((uint)inputs1.Length, inputs1, Marshal.SizeOf(typeof(INPUT)));
        }

        #region D-XY
        private static DXY GetDXY(int x, int y)
        {
            DXY dXY = new DXY();
            dXY.x = GetDX(x);
            dXY.y = GetDY(y);
            return dXY;
        }

        private static int GetDX(int x)
        {
            return x * (65536 / GetSystemMetrics(SystemMetric.SM_CXSCREEN));
        }

        private static int GetDY(int y)
        {
            return y * (65536 / GetSystemMetrics(SystemMetric.SM_CYSCREEN));
        }
        #endregion

        public class Enums
        {
            public enum Buttons
            {
                RIGHT,
                LEFT
            }

            public enum KeyState
            {
                DOWN,
                UP
            }

            public enum InputType : uint
            {
                MOUSE = 0,
                KEYBOARD = 1,
                HARDWARE = 2
            }

            public struct DXY
            {
                public int x;
                public int y;
            }
        }

        public class Imports
        {
            #region SendInput
            [DllImport("user32.dll")]
            internal static extern uint SendInput(uint nInputs, // https://www.pinvoke.net/default.aspx/user32.sendinput
          [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs,
          int cbSize);

            [StructLayout(LayoutKind.Sequential)] // http://www.pinvoke.net/default.aspx/Structures/INPUT.html
            public struct INPUT
            {
                internal uint type;
                internal InputUnion U;
                internal static int Size
                {
                    get { return Marshal.SizeOf(typeof(INPUT)); }
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            internal struct InputUnion
            {
                [FieldOffset(0)]
                internal MOUSEINPUT mi;
                [FieldOffset(0)]
                internal KEYBDINPUT ki;
                [FieldOffset(0)]
                internal HARDWAREINPUT hi;
            }

            #endregion

            #region Mouse

            [StructLayout(LayoutKind.Sequential)] // http://www.pinvoke.net/default.aspx/Structures/MOUSEINPUT.html
            internal struct MOUSEINPUT
            {
                internal int dx;
                internal int dy;
                internal int mouseData;
                internal MOUSEEVENTF dwFlags;
                internal uint time;
                internal UIntPtr dwExtraInfo;
            }

            [Flags]
            internal enum MOUSEEVENTF : uint
            {
                ABSOLUTE = 0x8000,
                HWHEEL = 0x01000,
                MOVE = 0x0001,
                MOVE_NOCOALESCE = 0x2000,
                LEFTDOWN = 0x0002,
                LEFTUP = 0x0004,
                RIGHTDOWN = 0x0008,
                RIGHTUP = 0x0010,
                MIDDLEDOWN = 0x0020,
                MIDDLEUP = 0x0040,
                VIRTUALDESK = 0x4000,
                WHEEL = 0x0800,
                XDOWN = 0x0080,
                XUP = 0x0100
            }
            #endregion

            #region Keyboard

            [StructLayout(LayoutKind.Sequential)] // http://www.pinvoke.net/default.aspx/Structures/KEYBDINPUT.html
            internal struct KEYBDINPUT
            {
                internal VirtualKeyShort wVk;
                internal ScanCodeShort wScan;
                internal KEYEVENTF dwFlags;
                internal int time;
                internal UIntPtr dwExtraInfo;
            }

            [Flags]
            internal enum KEYEVENTF : uint
            {
                EXTENDEDKEY = 0x0001,
                KEYUP = 0x0002,
                SCANCODE = 0x0008,
                UNICODE = 0x0004,
                KEYDOWN = 0,
            }

            internal enum VirtualKeyShort : short
            {
                ///<summary>
                ///Left mouse button
                ///</summary>
                LBUTTON = 0x01,
                ///<summary>
                ///Right mouse button
                ///</summary>
                RBUTTON = 0x02,
                ///<summary>
                ///Control-break processing
                ///</summary>
                CANCEL = 0x03,
                ///<summary>
                ///Middle mouse button (three-button mouse)
                ///</summary>
                MBUTTON = 0x04,
                ///<summary>
                ///Windows 2000/XP: X1 mouse button
                ///</summary>
                XBUTTON1 = 0x05,
                ///<summary>
                ///Windows 2000/XP: X2 mouse button
                ///</summary>
                XBUTTON2 = 0x06,
                ///<summary>
                ///BACKSPACE key
                ///</summary>
                BACK = 0x08,
                ///<summary>
                ///TAB key
                ///</summary>
                TAB = 0x09,
                ///<summary>
                ///CLEAR key
                ///</summary>
                CLEAR = 0x0C,
                ///<summary>
                ///ENTER key
                ///</summary>
                RETURN = 0x0D,
                ///<summary>
                ///SHIFT key
                ///</summary>
                SHIFT = 0x10,
                ///<summary>
                ///CTRL key
                ///</summary>
                CONTROL = 0x11,
                ///<summary>
                ///ALT key
                ///</summary>
                MENU = 0x12,
                ///<summary>
                ///PAUSE key
                ///</summary>
                PAUSE = 0x13,
                ///<summary>
                ///CAPS LOCK key
                ///</summary>
                CAPITAL = 0x14,
                ///<summary>
                ///Input Method Editor (IME) Kana mode
                ///</summary>
                KANA = 0x15,
                ///<summary>
                ///IME Hangul mode
                ///</summary>
                HANGUL = 0x15,
                ///<summary>
                ///IME Junja mode
                ///</summary>
                JUNJA = 0x17,
                ///<summary>
                ///IME final mode
                ///</summary>
                FINAL = 0x18,
                ///<summary>
                ///IME Hanja mode
                ///</summary>
                HANJA = 0x19,
                ///<summary>
                ///IME Kanji mode
                ///</summary>
                KANJI = 0x19,
                ///<summary>
                ///ESC key
                ///</summary>
                ESCAPE = 0x1B,
                ///<summary>
                ///IME convert
                ///</summary>
                CONVERT = 0x1C,
                ///<summary>
                ///IME nonconvert
                ///</summary>
                NONCONVERT = 0x1D,
                ///<summary>
                ///IME accept
                ///</summary>
                ACCEPT = 0x1E,
                ///<summary>
                ///IME mode change request
                ///</summary>
                MODECHANGE = 0x1F,
                ///<summary>
                ///SPACEBAR
                ///</summary>
                SPACE = 0x20,
                ///<summary>
                ///PAGE UP key
                ///</summary>
                PRIOR = 0x21,
                ///<summary>
                ///PAGE DOWN key
                ///</summary>
                NEXT = 0x22,
                ///<summary>
                ///END key
                ///</summary>
                END = 0x23,
                ///<summary>
                ///HOME key
                ///</summary>
                HOME = 0x24,
                ///<summary>
                ///LEFT ARROW key
                ///</summary>
                LEFT = 0x25,
                ///<summary>
                ///UP ARROW key
                ///</summary>
                UP = 0x26,
                ///<summary>
                ///RIGHT ARROW key
                ///</summary>
                RIGHT = 0x27,
                ///<summary>
                ///DOWN ARROW key
                ///</summary>
                DOWN = 0x28,
                ///<summary>
                ///SELECT key
                ///</summary>
                SELECT = 0x29,
                ///<summary>
                ///PRINT key
                ///</summary>
                PRINT = 0x2A,
                ///<summary>
                ///EXECUTE key
                ///</summary>
                EXECUTE = 0x2B,
                ///<summary>
                ///PRINT SCREEN key
                ///</summary>
                SNAPSHOT = 0x2C,
                ///<summary>
                ///INS key
                ///</summary>
                INSERT = 0x2D,
                ///<summary>
                ///DEL key
                ///</summary>
                DELETE = 0x2E,
                ///<summary>
                ///HELP key
                ///</summary>
                HELP = 0x2F,
                ///<summary>
                ///0 key
                ///</summary>
                KEY_0 = 0x30,
                ///<summary>
                ///1 key
                ///</summary>
                KEY_1 = 0x31,
                ///<summary>
                ///2 key
                ///</summary>
                KEY_2 = 0x32,
                ///<summary>
                ///3 key
                ///</summary>
                KEY_3 = 0x33,
                ///<summary>
                ///4 key
                ///</summary>
                KEY_4 = 0x34,
                ///<summary>
                ///5 key
                ///</summary>
                KEY_5 = 0x35,
                ///<summary>
                ///6 key
                ///</summary>
                KEY_6 = 0x36,
                ///<summary>
                ///7 key
                ///</summary>
                KEY_7 = 0x37,
                ///<summary>
                ///8 key
                ///</summary>
                KEY_8 = 0x38,
                ///<summary>
                ///9 key
                ///</summary>
                KEY_9 = 0x39,
                ///<summary>
                ///A key
                ///</summary>
                KEY_A = 0x41,
                ///<summary>
                ///B key
                ///</summary>
                KEY_B = 0x42,
                ///<summary>
                ///C key
                ///</summary>
                KEY_C = 0x43,
                ///<summary>
                ///D key
                ///</summary>
                KEY_D = 0x44,
                ///<summary>
                ///E key
                ///</summary>
                KEY_E = 0x45,
                ///<summary>
                ///F key
                ///</summary>
                KEY_F = 0x46,
                ///<summary>
                ///G key
                ///</summary>
                KEY_G = 0x47,
                ///<summary>
                ///H key
                ///</summary>
                KEY_H = 0x48,
                ///<summary>
                ///I key
                ///</summary>
                KEY_I = 0x49,
                ///<summary>
                ///J key
                ///</summary>
                KEY_J = 0x4A,
                ///<summary>
                ///K key
                ///</summary>
                KEY_K = 0x4B,
                ///<summary>
                ///L key
                ///</summary>
                KEY_L = 0x4C,
                ///<summary>
                ///M key
                ///</summary>
                KEY_M = 0x4D,
                ///<summary>
                ///N key
                ///</summary>
                KEY_N = 0x4E,
                ///<summary>
                ///O key
                ///</summary>
                KEY_O = 0x4F,
                ///<summary>
                ///P key
                ///</summary>
                KEY_P = 0x50,
                ///<summary>
                ///Q key
                ///</summary>
                KEY_Q = 0x51,
                ///<summary>
                ///R key
                ///</summary>
                KEY_R = 0x52,
                ///<summary>
                ///S key
                ///</summary>
                KEY_S = 0x53,
                ///<summary>
                ///T key
                ///</summary>
                KEY_T = 0x54,
                ///<summary>
                ///U key
                ///</summary>
                KEY_U = 0x55,
                ///<summary>
                ///V key
                ///</summary>
                KEY_V = 0x56,
                ///<summary>
                ///W key
                ///</summary>
                KEY_W = 0x57,
                ///<summary>
                ///X key
                ///</summary>
                KEY_X = 0x58,
                ///<summary>
                ///Y key
                ///</summary>
                KEY_Y = 0x59,
                ///<summary>
                ///Z key
                ///</summary>
                KEY_Z = 0x5A,
                ///<summary>
                ///Left Windows key (Microsoft Natural keyboard)
                ///</summary>
                LWIN = 0x5B,
                ///<summary>
                ///Right Windows key (Natural keyboard)
                ///</summary>
                RWIN = 0x5C,
                ///<summary>
                ///Applications key (Natural keyboard)
                ///</summary>
                APPS = 0x5D,
                ///<summary>
                ///Computer Sleep key
                ///</summary>
                SLEEP = 0x5F,
                ///<summary>
                ///Numeric keypad 0 key
                ///</summary>
                NUMPAD0 = 0x60,
                ///<summary>
                ///Numeric keypad 1 key
                ///</summary>
                NUMPAD1 = 0x61,
                ///<summary>
                ///Numeric keypad 2 key
                ///</summary>
                NUMPAD2 = 0x62,
                ///<summary>
                ///Numeric keypad 3 key
                ///</summary>
                NUMPAD3 = 0x63,
                ///<summary>
                ///Numeric keypad 4 key
                ///</summary>
                NUMPAD4 = 0x64,
                ///<summary>
                ///Numeric keypad 5 key
                ///</summary>
                NUMPAD5 = 0x65,
                ///<summary>
                ///Numeric keypad 6 key
                ///</summary>
                NUMPAD6 = 0x66,
                ///<summary>
                ///Numeric keypad 7 key
                ///</summary>
                NUMPAD7 = 0x67,
                ///<summary>
                ///Numeric keypad 8 key
                ///</summary>
                NUMPAD8 = 0x68,
                ///<summary>
                ///Numeric keypad 9 key
                ///</summary>
                NUMPAD9 = 0x69,
                ///<summary>
                ///Multiply key
                ///</summary>
                MULTIPLY = 0x6A,
                ///<summary>
                ///Add key
                ///</summary>
                ADD = 0x6B,
                ///<summary>
                ///Separator key
                ///</summary>
                SEPARATOR = 0x6C,
                ///<summary>
                ///Subtract key
                ///</summary>
                SUBTRACT = 0x6D,
                ///<summary>
                ///Decimal key
                ///</summary>
                DECIMAL = 0x6E,
                ///<summary>
                ///Divide key
                ///</summary>
                DIVIDE = 0x6F,
                ///<summary>
                ///F1 key
                ///</summary>
                F1 = 0x70,
                ///<summary>
                ///F2 key
                ///</summary>
                F2 = 0x71,
                ///<summary>
                ///F3 key
                ///</summary>
                F3 = 0x72,
                ///<summary>
                ///F4 key
                ///</summary>
                F4 = 0x73,
                ///<summary>
                ///F5 key
                ///</summary>
                F5 = 0x74,
                ///<summary>
                ///F6 key
                ///</summary>
                F6 = 0x75,
                ///<summary>
                ///F7 key
                ///</summary>
                F7 = 0x76,
                ///<summary>
                ///F8 key
                ///</summary>
                F8 = 0x77,
                ///<summary>
                ///F9 key
                ///</summary>
                F9 = 0x78,
                ///<summary>
                ///F10 key
                ///</summary>
                F10 = 0x79,
                ///<summary>
                ///F11 key
                ///</summary>
                F11 = 0x7A,
                ///<summary>
                ///F12 key
                ///</summary>
                F12 = 0x7B,
                ///<summary>
                ///F13 key
                ///</summary>
                F13 = 0x7C,
                ///<summary>
                ///F14 key
                ///</summary>
                F14 = 0x7D,
                ///<summary>
                ///F15 key
                ///</summary>
                F15 = 0x7E,
                ///<summary>
                ///F16 key
                ///</summary>
                F16 = 0x7F,
                ///<summary>
                ///F17 key  
                ///</summary>
                F17 = 0x80,
                ///<summary>
                ///F18 key  
                ///</summary>
                F18 = 0x81,
                ///<summary>
                ///F19 key  
                ///</summary>
                F19 = 0x82,
                ///<summary>
                ///F20 key  
                ///</summary>
                F20 = 0x83,
                ///<summary>
                ///F21 key  
                ///</summary>
                F21 = 0x84,
                ///<summary>
                ///F22 key, (PPC only) Key used to lock device.
                ///</summary>
                F22 = 0x85,
                ///<summary>
                ///F23 key  
                ///</summary>
                F23 = 0x86,
                ///<summary>
                ///F24 key  
                ///</summary>
                F24 = 0x87,
                ///<summary>
                ///NUM LOCK key
                ///</summary>
                NUMLOCK = 0x90,
                ///<summary>
                ///SCROLL LOCK key
                ///</summary>
                SCROLL = 0x91,
                ///<summary>
                ///Left SHIFT key
                ///</summary>
                LSHIFT = 0xA0,
                ///<summary>
                ///Right SHIFT key
                ///</summary>
                RSHIFT = 0xA1,
                ///<summary>
                ///Left CONTROL key
                ///</summary>
                LCONTROL = 0xA2,
                ///<summary>
                ///Right CONTROL key
                ///</summary>
                RCONTROL = 0xA3,
                ///<summary>
                ///Left MENU key
                ///</summary>
                LMENU = 0xA4,
                ///<summary>
                ///Right MENU key
                ///</summary>
                RMENU = 0xA5,
                ///<summary>
                ///Windows 2000/XP: Browser Back key
                ///</summary>
                BROWSER_BACK = 0xA6,
                ///<summary>
                ///Windows 2000/XP: Browser Forward key
                ///</summary>
                BROWSER_FORWARD = 0xA7,
                ///<summary>
                ///Windows 2000/XP: Browser Refresh key
                ///</summary>
                BROWSER_REFRESH = 0xA8,
                ///<summary>
                ///Windows 2000/XP: Browser Stop key
                ///</summary>
                BROWSER_STOP = 0xA9,
                ///<summary>
                ///Windows 2000/XP: Browser Search key
                ///</summary>
                BROWSER_SEARCH = 0xAA,
                ///<summary>
                ///Windows 2000/XP: Browser Favorites key
                ///</summary>
                BROWSER_FAVORITES = 0xAB,
                ///<summary>
                ///Windows 2000/XP: Browser Start and Home key
                ///</summary>
                BROWSER_HOME = 0xAC,
                ///<summary>
                ///Windows 2000/XP: Volume Mute key
                ///</summary>
                VOLUME_MUTE = 0xAD,
                ///<summary>
                ///Windows 2000/XP: Volume Down key
                ///</summary>
                VOLUME_DOWN = 0xAE,
                ///<summary>
                ///Windows 2000/XP: Volume Up key
                ///</summary>
                VOLUME_UP = 0xAF,
                ///<summary>
                ///Windows 2000/XP: Next Track key
                ///</summary>
                MEDIA_NEXT_TRACK = 0xB0,
                ///<summary>
                ///Windows 2000/XP: Previous Track key
                ///</summary>
                MEDIA_PREV_TRACK = 0xB1,
                ///<summary>
                ///Windows 2000/XP: Stop Media key
                ///</summary>
                MEDIA_STOP = 0xB2,
                ///<summary>
                ///Windows 2000/XP: Play/Pause Media key
                ///</summary>
                MEDIA_PLAY_PAUSE = 0xB3,
                ///<summary>
                ///Windows 2000/XP: Start Mail key
                ///</summary>
                LAUNCH_MAIL = 0xB4,
                ///<summary>
                ///Windows 2000/XP: Select Media key
                ///</summary>
                LAUNCH_MEDIA_SELECT = 0xB5,
                ///<summary>
                ///Windows 2000/XP: Start Application 1 key
                ///</summary>
                LAUNCH_APP1 = 0xB6,
                ///<summary>
                ///Windows 2000/XP: Start Application 2 key
                ///</summary>
                LAUNCH_APP2 = 0xB7,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_1 = 0xBA,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the '+' key
                ///</summary>
                OEM_PLUS = 0xBB,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the ',' key
                ///</summary>
                OEM_COMMA = 0xBC,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the '-' key
                ///</summary>
                OEM_MINUS = 0xBD,
                ///<summary>
                ///Windows 2000/XP: For any country/region, the '.' key
                ///</summary>
                OEM_PERIOD = 0xBE,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_2 = 0xBF,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_3 = 0xC0,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_4 = 0xDB,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_5 = 0xDC,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_6 = 0xDD,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_7 = 0xDE,
                ///<summary>
                ///Used for miscellaneous characters; it can vary by keyboard.
                ///</summary>
                OEM_8 = 0xDF,
                ///<summary>
                ///Windows 2000/XP: Either the angle bracket key or the backslash key on the RT 102-key keyboard
                ///</summary>
                OEM_102 = 0xE2,
                ///<summary>
                ///Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
                ///</summary>
                PROCESSKEY = 0xE5,
                ///<summary>
                ///Windows 2000/XP: Used to pass Unicode characters as if they were keystrokes.
                ///The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information,
                ///see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
                ///</summary>
                PACKET = 0xE7,
                ///<summary>
                ///Attn key
                ///</summary>
                ATTN = 0xF6,
                ///<summary>
                ///CrSel key
                ///</summary>
                CRSEL = 0xF7,
                ///<summary>
                ///ExSel key
                ///</summary>
                EXSEL = 0xF8,
                ///<summary>
                ///Erase EOF key
                ///</summary>
                EREOF = 0xF9,
                ///<summary>
                ///Play key
                ///</summary>
                PLAY = 0xFA,
                ///<summary>
                ///Zoom key
                ///</summary>
                ZOOM = 0xFB,
                ///<summary>
                ///Reserved
                ///</summary>
                NONAME = 0xFC,
                ///<summary>
                ///PA1 key
                ///</summary>
                PA1 = 0xFD,
                ///<summary>
                ///Clear key
                ///</summary>
                OEM_CLEAR = 0xFE
            }
            internal enum ScanCodeShort : short
            {
                LBUTTON = 0,
                RBUTTON = 0,
                CANCEL = 70,
                MBUTTON = 0,
                XBUTTON1 = 0,
                XBUTTON2 = 0,
                BACK = 14,
                TAB = 15,
                CLEAR = 76,
                RETURN = 28,
                SHIFT = 42,
                CONTROL = 29,
                MENU = 56,
                PAUSE = 0,
                CAPITAL = 58,
                KANA = 0,
                HANGUL = 0,
                JUNJA = 0,
                FINAL = 0,
                HANJA = 0,
                KANJI = 0,
                ESCAPE = 1,
                CONVERT = 0,
                NONCONVERT = 0,
                ACCEPT = 0,
                MODECHANGE = 0,
                SPACE = 57,
                PRIOR = 73,
                NEXT = 81,
                END = 79,
                HOME = 71,
                LEFT = 75,
                UP = 72,
                RIGHT = 77,
                DOWN = 80,
                SELECT = 0,
                PRINT = 0,
                EXECUTE = 0,
                SNAPSHOT = 84,
                INSERT = 82,
                DELETE = 83,
                HELP = 99,
                KEY_0 = 11,
                KEY_1 = 2,
                KEY_2 = 3,
                KEY_3 = 4,
                KEY_4 = 5,
                KEY_5 = 6,
                KEY_6 = 7,
                KEY_7 = 8,
                KEY_8 = 9,
                KEY_9 = 10,
                KEY_A = 30,
                KEY_B = 48,
                KEY_C = 46,
                KEY_D = 32,
                KEY_E = 18,
                KEY_F = 33,
                KEY_G = 34,
                KEY_H = 35,
                KEY_I = 23,
                KEY_J = 36,
                KEY_K = 37,
                KEY_L = 38,
                KEY_M = 50,
                KEY_N = 49,
                KEY_O = 24,
                KEY_P = 25,
                KEY_Q = 16,
                KEY_R = 19,
                KEY_S = 31,
                KEY_T = 20,
                KEY_U = 22,
                KEY_V = 47,
                KEY_W = 17,
                KEY_X = 45,
                KEY_Y = 21,
                KEY_Z = 44,
                LWIN = 91,
                RWIN = 92,
                APPS = 93,
                SLEEP = 95,
                NUMPAD0 = 82,
                NUMPAD1 = 79,
                NUMPAD2 = 80,
                NUMPAD3 = 81,
                NUMPAD4 = 75,
                NUMPAD5 = 76,
                NUMPAD6 = 77,
                NUMPAD7 = 71,
                NUMPAD8 = 72,
                NUMPAD9 = 73,
                MULTIPLY = 55,
                ADD = 78,
                SEPARATOR = 0,
                SUBTRACT = 74,
                DECIMAL = 83,
                DIVIDE = 53,
                F1 = 59,
                F2 = 60,
                F3 = 61,
                F4 = 62,
                F5 = 63,
                F6 = 64,
                F7 = 65,
                F8 = 66,
                F9 = 67,
                F10 = 68,
                F11 = 87,
                F12 = 88,
                F13 = 100,
                F14 = 101,
                F15 = 102,
                F16 = 103,
                F17 = 104,
                F18 = 105,
                F19 = 106,
                F20 = 107,
                F21 = 108,
                F22 = 109,
                F23 = 110,
                F24 = 118,
                NUMLOCK = 69,
                SCROLL = 70,
                LSHIFT = 42,
                RSHIFT = 54,
                LCONTROL = 29,
                RCONTROL = 29,
                LMENU = 56,
                RMENU = 56,
                BROWSER_BACK = 106,
                BROWSER_FORWARD = 105,
                BROWSER_REFRESH = 103,
                BROWSER_STOP = 104,
                BROWSER_SEARCH = 101,
                BROWSER_FAVORITES = 102,
                BROWSER_HOME = 50,
                VOLUME_MUTE = 32,
                VOLUME_DOWN = 46,
                VOLUME_UP = 48,
                MEDIA_NEXT_TRACK = 25,
                MEDIA_PREV_TRACK = 16,
                MEDIA_STOP = 36,
                MEDIA_PLAY_PAUSE = 34,
                LAUNCH_MAIL = 108,
                LAUNCH_MEDIA_SELECT = 109,
                LAUNCH_APP1 = 107,
                LAUNCH_APP2 = 33,
                OEM_1 = 39,
                OEM_PLUS = 13,
                OEM_COMMA = 51,
                OEM_MINUS = 12,
                OEM_PERIOD = 52,
                OEM_2 = 53,
                OEM_3 = 41,
                OEM_4 = 26,
                OEM_5 = 43,
                OEM_6 = 27,
                OEM_7 = 40,
                OEM_8 = 0,
                OEM_102 = 86,
                PROCESSKEY = 0,
                PACKET = 0,
                ATTN = 0,
                CRSEL = 0,
                EXSEL = 0,
                EREOF = 93,
                PLAY = 0,
                ZOOM = 98,
                NONAME = 0,
                PA1 = 0,
                OEM_CLEAR = 0,
            }
            #endregion

            #region Hardware
            [StructLayout(LayoutKind.Sequential)] // http://www.pinvoke.net/default.aspx/Structures/HARDWAREINPUT.html
            internal struct HARDWAREINPUT
            {
                internal int uMsg;
                internal short wParamL;
                internal short wParamH;
            }
            #endregion

            #region GetSystemMetrics
            [DllImport("user32.dll")]
            public static extern int GetSystemMetrics(SystemMetric smIndex);

            public enum SystemMetric
            {
                SM_CXSCREEN = 0,  // 0x00
                SM_CYSCREEN = 1,  // 0x01
                SM_CXVSCROLL = 2,  // 0x02
                SM_CYHSCROLL = 3,  // 0x03
                SM_CYCAPTION = 4,  // 0x04
                SM_CXBORDER = 5,  // 0x05
                SM_CYBORDER = 6,  // 0x06
                SM_CXDLGFRAME = 7,  // 0x07
                SM_CXFIXEDFRAME = 7,  // 0x07
                SM_CYDLGFRAME = 8,  // 0x08
                SM_CYFIXEDFRAME = 8,  // 0x08
                SM_CYVTHUMB = 9,  // 0x09
                SM_CXHTHUMB = 10, // 0x0A
                SM_CXICON = 11, // 0x0B
                SM_CYICON = 12, // 0x0C
                SM_CXCURSOR = 13, // 0x0D
                SM_CYCURSOR = 14, // 0x0E
                SM_CYMENU = 15, // 0x0F
                SM_CXFULLSCREEN = 16, // 0x10
                SM_CYFULLSCREEN = 17, // 0x11
                SM_CYKANJIWINDOW = 18, // 0x12
                SM_MOUSEPRESENT = 19, // 0x13
                SM_CYVSCROLL = 20, // 0x14
                SM_CXHSCROLL = 21, // 0x15
                SM_DEBUG = 22, // 0x16
                SM_SWAPBUTTON = 23, // 0x17
                SM_CXMIN = 28, // 0x1C
                SM_CYMIN = 29, // 0x1D
                SM_CXSIZE = 30, // 0x1E
                SM_CYSIZE = 31, // 0x1F
                SM_CXSIZEFRAME = 32, // 0x20
                SM_CXFRAME = 32, // 0x20
                SM_CYSIZEFRAME = 33, // 0x21
                SM_CYFRAME = 33, // 0x21
                SM_CXMINTRACK = 34, // 0x22
                SM_CYMINTRACK = 35, // 0x23
                SM_CXDOUBLECLK = 36, // 0x24
                SM_CYDOUBLECLK = 37, // 0x25
                SM_CXICONSPACING = 38, // 0x26
                SM_CYICONSPACING = 39, // 0x27
                SM_MENUDROPALIGNMENT = 40, // 0x28
                SM_PENWINDOWS = 41, // 0x29
                SM_DBCSENABLED = 42, // 0x2A
                SM_CMOUSEBUTTONS = 43, // 0x2B
                SM_SECURE = 44, // 0x2C
                SM_CXEDGE = 45, // 0x2D
                SM_CYEDGE = 46, // 0x2E
                SM_CXMINSPACING = 47, // 0x2F
                SM_CYMINSPACING = 48, // 0x30
                SM_CXSMICON = 49, // 0x31
                SM_CYSMICON = 50, // 0x32
                SM_CYSMCAPTION = 51, // 0x33
                SM_CXSMSIZE = 52, // 0x34
                SM_CYSMSIZE = 53, // 0x35
                SM_CXMENUSIZE = 54, // 0x36
                SM_CYMENUSIZE = 55, // 0x37
                SM_ARRANGE = 56, // 0x38
                SM_CXMINIMIZED = 57, // 0x39
                SM_CYMINIMIZED = 58, // 0x3A
                SM_CXMAXTRACK = 59, // 0x3B
                SM_CYMAXTRACK = 60, // 0x3C
                SM_CXMAXIMIZED = 61, // 0x3D
                SM_CYMAXIMIZED = 62, // 0x3E
                SM_NETWORK = 63, // 0x3F
                SM_CLEANBOOT = 67, // 0x43
                SM_CXDRAG = 68, // 0x44
                SM_CYDRAG = 69, // 0x45
                SM_SHOWSOUNDS = 70, // 0x46
                SM_CXMENUCHECK = 71, // 0x47
                SM_CYMENUCHECK = 72, // 0x48
                SM_SLOWMACHINE = 73, // 0x49
                SM_MIDEASTENABLED = 74, // 0x4A
                SM_MOUSEWHEELPRESENT = 75, // 0x4B
                SM_XVIRTUALSCREEN = 76, // 0x4C
                SM_YVIRTUALSCREEN = 77, // 0x4D
                SM_CXVIRTUALSCREEN = 78, // 0x4E
                SM_CYVIRTUALSCREEN = 79, // 0x4F
                SM_CMONITORS = 80, // 0x50
                SM_SAMEDISPLAYFORMAT = 81, // 0x51
                SM_IMMENABLED = 82, // 0x52
                SM_CXFOCUSBORDER = 83, // 0x53
                SM_CYFOCUSBORDER = 84, // 0x54
                SM_TABLETPC = 86, // 0x56
                SM_MEDIACENTER = 87, // 0x57
                SM_STARTER = 88, // 0x58
                SM_SERVERR2 = 89, // 0x59
                SM_MOUSEHORIZONTALWHEELPRESENT = 91, // 0x5B
                SM_CXPADDEDBORDER = 92, // 0x5C
                SM_DIGITIZER = 94, // 0x5E
                SM_MAXIMUMTOUCHES = 95, // 0x5F

                SM_REMOTESESSION = 0x1000, // 0x1000
                SM_SHUTTINGDOWN = 0x2000, // 0x2000
                SM_REMOTECONTROL = 0x2001, // 0x2001


                SM_CONVERTIBLESLATEMODE = 0x2003,
                SM_SYSTEMDOCKED = 0x2004,
            }
            #endregion

            #region GetAsyncKeyState
            [DllImport("user32.dll")]
            public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
            #endregion
        }
    }
}