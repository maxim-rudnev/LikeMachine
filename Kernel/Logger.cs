using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMachine.Kernel
{
    public class Logger
    {
        public static string Filename = Globals.ReportFile;
        public static string Folder = Globals.AppDataFolder;
        public static void AddLine(string uid)
        {

            if (Directory.Exists(Folder) == false) Directory.CreateDirectory(Folder);

            if (File.Exists(Filename) == false)
            {
                FileStream fs = File.Create(Filename);
                fs.Close();
                fs.Dispose();
            }

            int number = File.ReadAllLines(Filename).Count() + 1;

            File.AppendAllLines(Filename, new string[] { string.Format("{0} - {1}", number, uid) });
        }
    }
}
