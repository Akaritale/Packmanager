using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManager.Core
{
    public class Archives
    {
        public static string[] ReadFromDirectory()
        {
            var path = Properties.Settings.Default.PackDirectory;
            if (!Directory.Exists(path))
                return null;

            return Directory.GetDirectories(path);
        }
    }
}
