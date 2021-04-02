using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace LFINI
{
    class INI
    {
        private string IniPath = string.Empty;
        public INI(string iniPath)
        {
            IniPath = iniPath;
            Funcs.CreateProfile(this);
        }

        public bool Write(string sectionName, string keyName, object value)
        {
            try
            {
                bool result = Imports.WritePrivateProfileString(sectionName, keyName, value.ToString(), IniPath);
                return result;
            }
            catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); return false; }
        }

        public string Read(string sectionName, string keyName)
        {
            try
            {
                StringBuilder sb = new StringBuilder(5000);
                Imports.GetPrivateProfileString(sectionName, keyName, string.Empty, sb, sb.Capacity, IniPath);
                string result = sb.ToString();
                return result;
            }
            catch (Exception ex) { Console.WriteLine("ERROR : " + ex.Message); return string.Empty; }
        }

        public static class Funcs
        {
            public static bool CreateProfile(INI ini)
            {
                using (StreamWriter sw = (File.Exists(ini.IniPath)) ? File.AppendText(ini.IniPath) : File.CreateText(ini.IniPath))
                {
                    return File.Exists(ini.IniPath);
                }
            }
        }

        public static class Imports
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

            [DllImport("kernel32.dll")]
            public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        }
    }
}