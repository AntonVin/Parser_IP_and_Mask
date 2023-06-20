using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_Ip_and_Mask
{
    public static class RegistrHelper
    {
        public static string GetPath()
        {
            var key = Registry.CurrentUser.OpenSubKey("ParserIpAndMask");
            if (key is null)
                return "укажите путь";
            var path = key.GetValue("path") as string;
            key.Close();
            return path;
        }

        public static void SetPath(string path)
        {
            var key = Registry.CurrentUser.CreateSubKey("ParserIpAndMask");
            key.SetValue("path", path);
            key.Close();
        }
    }
}
