using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strat_Assistant
{
    class Global
    {
        public static List<Map> currentMapList = new List<Map>();
        public static List<Map> mapList = new List<Map>();
        public static List<string> defList = new List<string>();
        public static List<string> attList = new List<string>();
        public static string localDataFilePath = @"..\Data\LocalData.json";
        public static string errorLogFilePath = @"..\Data\ErrorLog.txt";
        public static LocalData localData;
        public static ImgurAPI imgurAPI = new ImgurAPI();
        public static JSONHelper JSONHelper = new JSONHelper();
        public static int tempStratID = -1;
        public static object activeControl = null;
        public static string verNum;
        public static List<string> searchMetadata = new List<string>();

        public static Task InitGlobalVars()
        {
            try
            {
                mapList.AddRange(new List<Map>()
            {
                new Map()
                {
                    Name = "Oregon",
                    Sites = new List<string>()
                    {
                        "Kids",
                        "Kitchen",
                        "Laundry",
                        "Tower"
                    }
                },
                new Map()
                {
                    Name = "Clubhouse",
                    Sites = new List<string>()
                    {
                        "Bedroom",
                        "Cash",
                        "Bar",
                        "Armory"
                    }
                },
                new Map()
                {
                    Name = "Consulate",
                    Sites = new List<string>()
                    {
                        "Consul",
                        "Lobby",
                        "Garage"
                    }
                },
                new Map()
                {
                    Name = "Bank",
                    Sites = new List<string>()
                    {
                        "CEO",
                        "Open",
                        "Tellers",
                        "CCTV"
                    }
                },
                new Map()
                {
                    Name = "Chalet",
                    Sites = new List<string>()
                    {
                        "Master",
                        "Bar",
                        "Garage",
                        "Kitchen"
                    }
                },
                new Map()
                {
                    Name = "Kafe",
                    Sites = new List<string>()
                    {
                        "Bar",
                        "Train",
                        "Bakery"
                    }
                },
                new Map()
                {
                    Name = "Border",
                    Sites = new List<string>()
                    {
                        "Customs",
                        "Workshop",
                        "Tellers",
                        "Armory"
                    }
                },
                new Map()
                {
                    Name = "Skyscraper",
                    Sites = new List<string>()
                    {
                        "Tea",
                        "Kitchen",
                        "Office",
                        "Master"
                    }
                },
                new Map()
                {
                    Name = "Favela",
                    Sites = new List<string>()
                    {
                        "Meth Lab",
                        "Football",
                        "Aunt's",
                        "Biker's"
                    }
                },
                new Map()
                {
                    Name = "Hereford Base",
                    Sites = new List<string>()
                    {
                        "3rd Floor",
                        "Split",
                        "Kitchen",
                        "Basement"
                    }
                },
                new Map()
                {
                    Name = "House",
                    Sites = new List<string>()
                    {
                        "Kids",
                        "Split",
                        "Garage"
                    }
                },
                new Map()
                {
                    Name = "Kanal",
                    Sites = new List<string>()
                    {
                        "Control",
                        "Kitchen",
                        "Coast Guard"
                    }
                },
                new Map()
                {
                    Name = "Plane",
                    Sites = new List<string>()
                    {
                        "Front",
                        "Middle",
                        "Basement"
                    }
                },
                new Map()
                {
                    Name = "Theme Park",
                    Sites = new List<string>()
                    {
                        "Initiation",
                        "Bunks",
                        "Gargoyle",
                        "Drug Lab"
                    }
                },
                new Map()
                {
                    Name = "Tower",
                    Sites = new List<string>()
                    {
                        "Gift Shop",
                        "Media Center",
                        "Tea",
                        "Restaurant"
                    }
                },
                new Map()
                {
                    Name = "Yacht",
                    Sites = new List<string>()
                    {
                        "Cockpit",
                        "Kitchen",
                        "Cafe",
                        "Engine"
                    }
                },
                new Map()
                {
                    Name = "Coastline",
                    Sites = new List<string>()
                    {
                        "Master",
                        "Hookah",
                        "Kitchen",
                        "Sunrise"
                    }
                }
            });
                defList.AddRange(new List<string>()
            {
                "Maestro",
                "Alibi",
                "Vigil",
                "Ela",
                "Lesion",
                "Mira",
                "Echo",
                "Caveira",
                "Valkyrie",
                "Frost",
                "Mute",
                "Smoke",
                "Castle",
                "Pulse",
                "Doc",
                "Rook",
                "Jager",
                "Bandit",
                "Tachanka",
                "Kapkan"
            });
                attList.AddRange(new List<string>()
            {
                "Lion",
                "Finka",
                "Dokkaebi",
                "Zofia",
                "Ying",
                "Jackal",
                "Hibana",
                "Capitao",
                "Blackbeard",
                "Buck",
                "Sledge",
                "Thatcher",
                "Ash",
                "Thermite",
                "Montagne",
                "Twitch",
                "Blitz",
                "IQ",
                "Fuze",
                "Glaz"
            });

                if (!File.Exists(localDataFilePath))
                {
                    Directory.CreateDirectory(@"..\Data\");
                    JSONHelper.JsonSerialize(new LocalData()
                    {
                        CreateWizardOn = true,
                        Updated = false,
                    });
                }

                if (!File.Exists(errorLogFilePath))
                {
                    File.CreateText(errorLogFilePath);
                }

                localData = JSONHelper.JsonDeserialize();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            return Task.CompletedTask;
        }

        public static async void LogError(Exception ex)
        {
            try
            {
                File.AppendAllLines(errorLogFilePath, new string[] {$"{DateTime.Now.ToString()}: {ex.Message}", ex.StackTrace });
                MessageBox.Show("Error occurred: " + ex.Message, "Error occurred");

                DatabaseFunctions.ErrorLog errorlog = new DatabaseFunctions.ErrorLog()
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    Time = DateTime.Now,
                };

                await Task.Run(() => DatabaseFunctions.ErrorLogInsert(errorlog)).ConfigureAwait(false);
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was an error creating an error report! Connection to the database has likely been terminated, contact Mrhuma if this issue persists. Error: " + exc.Message);
            }
        }
    }

    public class FormList
    {
        private static MainForm _mainform = new MainForm();
        public static MainForm MainForm { get { return _mainform; } }
    }

    public class Map
    {
        public string Name { get; set; }
        public List<string> Sites { get; set; }
    }
}