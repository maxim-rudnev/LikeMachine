using LikeMachine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMachine
{
    public static class Globals
    {
        public static string AppDataFolder = string.Format(@"{0}\Sharpcoder\Like Machine",
                                                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

        public static string ReportFile = string.Format(@"{0}\Report.txt", AppDataFolder);

        public static string SettingsFile = string.Format(@"{0}\Settings.txt", AppDataFolder);




        public static List<KeyValuePair<string, string>> CityDictionary = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string,string>("Не указано",null),
            new KeyValuePair<string,string>("Серпухов","340"),
            new KeyValuePair<string,string>("Подольск","270"),
            new KeyValuePair<string,string>("Пущино","115"),
            new KeyValuePair<string,string>("Протвино","449"),
            new KeyValuePair<string,string>("Чехов","872")
        };

        public static List<KeyValuePair<string, string>> StatusDictionary = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string,string>("Не указано"                ,null),
            new KeyValuePair<string,string>("В активном поиске",        "6"),
            new KeyValuePair<string,string>("Не женат / Не замужем",    "1"),
            new KeyValuePair<string,string>("Есть друг / Есть подруга", "2"),
            new KeyValuePair<string,string>("Помолвлен / Помолвлена",   "3"),
            new KeyValuePair<string,string>("Женат / Замужем",          "4"),
            new KeyValuePair<string,string>("Всё сложно",               "5"),
            new KeyValuePair<string,string>("Влюблён / Влюблена",       "7"),
            new KeyValuePair<string,string>("В гражданском браке",      "8"),
            new KeyValuePair<string,string>("Не указано",               "0"),
        };

        public static List<KeyValuePair<string, Sex?>> SexDictionary = new List<KeyValuePair<string, Sex?>>()
        {
            new KeyValuePair<string,Sex?>("Все", null),
            new KeyValuePair<string,Sex?>("Муж.",Sex.Male),
            new KeyValuePair<string,Sex?>("Жен.",Sex.Female)
        };

        
        
    }
}
