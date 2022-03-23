using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace Strat_Assistant
{
    class Updater
    {
        public static async Task CheckForUpdate(bool manualCheck = false)
        {
            string exePath = "";
            using (var mgr = new UpdateManager("http://www.mrhumagames.com/StratUpdates"))
            {
                UpdateInfo updateInfo = await Task.Run(() => mgr.CheckForUpdate().Result).ConfigureAwait(true);

                if (updateInfo.ReleasesToApply.Any())
                {
                    Global.localData.Updated = true;
                    Global.JSONHelper.JsonSerialize(Global.localData);
                    Global.verNum = updateInfo.ReleasesToApply.Last().Version.ToString();

                    exePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).ToString(), $"app-{Global.verNum}\\StratAssistant.exe");
                    await mgr.UpdateApp();

                    mgr.CreateShortcutsForExecutable(exePath, ShortcutLocation.Desktop, false);

                    MessageBox.Show($"The app has been updated to version {Global.verNum}. " +
                        $"{Environment.NewLine} Press OK to restart the app in the new version. " +
                        $"{Environment.NewLine} " +
                        $"{Environment.NewLine} WARNING: Do not close the application while it is updating. " +
                        $"{Environment.NewLine} When the update is complete it will automatically close. " +
                        $"{Environment.NewLine} This process may take up to 10-15 seconds. ");

                    Cursor.Current = Cursors.WaitCursor;
                    UpdateManager.RestartApp(exePath);
                }
                else
                {
                    Global.verNum = updateInfo.CurrentlyInstalledVersion.Version.ToString();

                    if (!manualCheck && Global.localData.Updated)
                    {
                        ShowChangelog();
                    }
                    else if(manualCheck)
                    {
                        MessageBox.Show("No update detected.");
                    }
                }

                FormList.MainForm.UpdateVersionText();
            }
        }

        public static void ShowChangelog()
        {
            List<ChangeLog> changeLogList = new List<ChangeLog>
            {
                new ChangeLog
                {
                    Version = "3.0",
                    Changes = new List<string>
                {
                    "Added 'Check for Update' and 'Changelog' buttons.",
                    "Moved the Creation Wizard setting to a settings tab at the top of the window alongside the 2 new buttons.",
                    "Moved the version number to the top right.",
                }
                },
                new ChangeLog
                {
                    Version = "2.0",
                    Changes = new List<string>
                {
                    "Reworked the search bar to be more intuitive and easier to use.",
                    "Added all maps to the combobox when creating a new strat.",
                    "Fixed a bug when putting a space into a strat name.",
                    "Now shows the version number in the bottom right.",
                }
                }
            };

            string changeLog = "";

            foreach(var changelog in changeLogList)
            {
                changeLog += changelog.ToString();
            }

            MessageBox.Show($"Current Version: {Global.verNum}" + Environment.NewLine + "Changelog:" + Environment.NewLine + $"{changeLog}", "Changelog");

            if (Global.localData.Updated)
            {
                Global.localData.Updated = false;
                Global.JSONHelper.JsonSerialize(Global.localData);
            }
        }
    }

    class ChangeLog
    {
        public string Version { get; set; }
        public List<string> Changes { get; set; }

        public override string ToString()
        {
            string retstr;

            retstr = $"{Environment.NewLine} {Version}: {Environment.NewLine}";

            foreach(var change in Changes)
            {
                retstr += $"    {change}{Environment.NewLine}";
            }

            return retstr;
        }
    }
}
