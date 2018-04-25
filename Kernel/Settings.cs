using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LikeMachine.Kernel
{
    public class Settings
    {
        public static Settings GetSettings()
        {
            Settings settings = null;
            string filename = Globals.SettingsFile;

            //проверка наличия файла
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Settings));
                    settings = (Settings)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else
            {
                settings = new Settings();
            }

            return settings;
        }

        /// <summary>
        /// Процедура сохранения настроек в файл
        /// </summary>
        public void Save()
        {
            string filename = Globals.SettingsFile;

            if (File.Exists(filename)) File.Delete(filename);


            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Settings));
                xser.Serialize(fs, this);
                fs.Close();
            }
        }

        public string GetMessage()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(Message));
        }

        public string GetGroups()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(Groups));
        }

        public void SetMessage(string text)
        {
            Message = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        public void SetGroups(string text)
        {
            Groups = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }



        public string Message { get; set; }

        public string Groups { get; set; }

        public bool ShowCaptcha { get; set; }

        
    }
}
