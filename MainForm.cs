using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strat_Assistant
{
    public partial class MainForm : Form
    {
        enum WizardState { None, Map, Site, Side, Strat, OP, Text};
        WizardState wizardState = WizardState.None;
        bool isBlinking = false;

        public MainForm()
        {
            InitializeComponent();
            OperatorInfoText.AllowDrop = true;
            CreateOperatorInfo.AllowDrop = true;
            Global.InitGlobalVars();
            Task.Run(() => DatabaseFunctions.CreateStrats().ConfigureAwait(false));
            Task.Run(() => DatabaseFunctions.CreateErrorLog().ConfigureAwait(false));
            Global.mapList.ForEach(x => CreateMapSelector.Items.Add(x.Name));
            CreationWizardToolStripMenuItem.Checked = Global.localData.CreateWizardOn;
            Task.Run(() => Updater.CheckForUpdate()).ConfigureAwait(false);
            Task.Run(() => Global.searchMetadata = DatabaseFunctions.GetMetadata()).ConfigureAwait(false);
        }

        public void UpdateVersionText()
        {
            versionText.Text = "V " + Global.verNum;
        }

        private void CreateStratButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainPanel.Visible = false;
                CreatePanel.Visible = true;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void Blink(ComboBox box)
        {
            try
            {
                isBlinking = true;
                while (isBlinking)
                {
                    await Task.Delay(500);
                    box.BackColor = box.BackColor == Color.FromArgb(227, 175, 52) ? Color.FromArgb(44, 47, 51) : Color.FromArgb(227, 175, 52);
                }
                box.BackColor = Color.FromArgb(44, 47, 51);
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void DisableBlink(object sender, EventArgs e)
        {
            try
            {
                isBlinking = false;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreatePanel_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (Global.localData.CreateWizardOn)
                {
                    if (CreatePanel.Visible == true)
                    {
                        CreateSiteSelector.Visible = false;
                        CreateSideSelector.Visible = false;
                        CreateStratSelector.Visible = false;
                        CreateOperatorSelector.Visible = false;
                        CreateOperatorInfo.ReadOnly = true;
                        CreateOperatorInfo.Text = "Drag and drop an image, or write some text.";
                        CreateCreateStratButton.Visible = false;
                        MessageBox.Show(CreatePanel, "Select a map!", "Strat Wizard");
                        Blink(CreateMapSelector);
                        wizardState = WizardState.Map;
                    }
                }
                else if (!Global.localData.CreateWizardOn)
                {
                    CreateSiteSelector.Visible = true;
                    CreateSideSelector.Visible = true;
                    CreateStratSelector.Visible = true;
                    CreateOperatorSelector.Visible = true;
                    CreateOperatorInfo.ReadOnly = false;
                    CreateOperatorInfo.Text = "Drag and drop an image, or write some text.";
                    CreateCreateStratButton.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateSiteSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CreateSideSelector.Items.Clear();
                CreateSideSelector.Items.AddRange(new string[]{
                        "Attacker",
                        "Defender"
                    });
                CreateStratSelector.Items.Clear();
                CreateStratSelector.Text = "";
                CreateOperatorSelector.Items.Clear();
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateMapSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CreateSiteSelector.Text = "";
                CreateSiteSelector.Items.Clear();
                CreateSiteSelector.Items.AddRange(Global.mapList.Where(t => t.Name == CreateMapSelector.Text).First().Sites.ToArray());
                CreateSideSelector.Items.Clear();
                CreateSideSelector.Items.AddRange(new string[]{
                        "Attacker",
                        "Defender"
                    });
                CreateStratSelector.Items.Clear();
                CreateStratSelector.Text = "";
                CreateOperatorSelector.Items.Clear();
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateSiteSelector_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                CreateSelectSiteText.Visible = CreateSiteSelector.Visible;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateSideSelector_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                CreateSelectSideText.Visible = CreateSideSelector.Visible;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateStratSelector_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                CreateSelectStratText.Visible = CreateStratSelector.Visible;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateOperatorSelector_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                CreateSelectOperatorText.Visible = CreateOperatorSelector.Visible;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateBackButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchBox.Text = "Search";
                CreatePanel.Visible = false;
                MainPanel.Visible = true;
                isBlinking = false;
                wizardState = WizardState.None;
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateMapSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (wizardState == WizardState.Map)
                {
                    CreateSiteSelector.Visible = true;
                    MessageBox.Show(CreatePanel, "Select a site!", "Strat Wizard");
                    Blink(CreateSiteSelector);
                    wizardState = WizardState.Site;
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateSiteSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Once user has selected a site, proceed to the select side step of the creation wizard.
                if (wizardState == WizardState.Site)
                {
                    CreateSideSelector.Visible = true;
                    MessageBox.Show(CreatePanel, "Select attack or defense!", "Strat Wizard");
                    Blink(CreateSideSelector);
                    wizardState = WizardState.Side;
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void CreateSideSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Once user has selected a side, proceed to the select strat step of the creation wizard.
                if (wizardState == WizardState.Side)
                {
                    CreateStratSelector.Visible = true;
                    MessageBox.Show(CreatePanel, "Select an already created strat name, or type in a new one!", "Strat Wizard");
                    Blink(CreateStratSelector);
                    wizardState = WizardState.Strat;
                }

                bool isAttacker = false;
                CreateStratSelector.Items.Clear();
                CreateStratSelector.Text = "";
                CreateOperatorSelector.Items.Clear();

                //If user selected attacker, set operator selector panel to only show attacking operators.
                if (CreateSideSelector.Text.ToLower().StartsWith("att"))
                {
                    CreateOperatorSelector.Items.AddRange(Global.attList.ToArray());
                    isAttacker = true;
                }

                //Else if user selected defender then show defending operators.
                else if (CreateSideSelector.Text.ToLower().StartsWith("def"))
                {
                    CreateOperatorSelector.Items.AddRange(Global.defList.ToArray());
                    isAttacker = false;
                }

                string map = CreateMapSelector.Text;
                string site = CreateSiteSelector.Text;

                List<string> stratList = new List<string>();

                //Get any names of existing strats from the database and fill the strat selector combobox with them.
                await Task.Run(() => stratList = DatabaseFunctions.GetStratNames(map, site, isAttacker)).ConfigureAwait(true);
                CreateStratSelector.Items.AddRange(stratList.Distinct().ToArray());
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateOperatorSelector_Validated(object sender, EventArgs e)
        {
            try
            {
                //Once user has selected a op, proceed to the select op text step of the creation wizard.
                if (wizardState == WizardState.OP)
                {
                    CreateOperatorInfo.Visible = true;
                    MessageBox.Show(CreatePanel, "Fill the textbox with whatever is needed for the strat. You can drag images into the textbox. Once you are done, click the Create Strat button in the bottom left corner of the window.", "Strat Wizard");
                    wizardState = WizardState.None;
                    CreateCreateStratButton.Visible = true;
                    CreateOperatorInfo.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void CreateCreateStratButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAttack;

                if(CreateMapSelector.Text == "")
                {
                    MessageBox.Show("You didn't select a Map.");
                    return;
                }

                if (CreateSiteSelector.Text == "")
                {
                    MessageBox.Show("You didn't select a Site.");
                    return;
                }

                if (CreateSideSelector.Text == "")
                {
                    MessageBox.Show("You didn't select a Side.");
                    return;
                }

                if (CreateStratSelector.Text == "")
                {
                    MessageBox.Show("You didn't select a Strat.");
                    return;
                }

                if(CreateStratSelector.Text.Contains(','))
                {
                    MessageBox.Show("The strat name can't contain any commas( , ).");
                }

                if (CreateOperatorSelector.Text == "")
                {
                    MessageBox.Show("You didn't select an Operator.");
                    return;
                }

                if (CreateOperatorInfo.Text == "")
                {
                    MessageBox.Show("You didn't enter instructions for the chosen operator.");
                    return;
                }

                if (CreateSideSelector.Text.ToLower().StartsWith("att"))
                {
                    isAttack = true;
                }
                else
                {
                    isAttack = false;
                }

                DatabaseFunctions.Strats strat = new DatabaseFunctions.Strats()
                {
                    Map = CreateMapSelector.Text,
                    Site = CreateSiteSelector.Text,
                    IsAttack = isAttack,
                    Strat = CreateStratSelector.Text,
                    OP = CreateOperatorSelector.Text,
                    OPText = CreateOperatorInfo.Text,
                };

                if (await DatabaseFunctions.StratInsert(strat))
                {
                    MessageBox.Show("Successfully added the strat!");
                }
                else
                {
                    throw new Exception("There was an error inserting into the database.");
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void MapSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Global.activeControl == MapSelector)
                {
                    SiteSelector.Items.Clear();
                    SiteSelector.Items.AddRange(Global.currentMapList.Where(t => t.Name == MapSelector.Text).First().Sites.ToArray());
                    SideSelector.Items.Clear();
                    SideSelector.Items.AddRange(new string[]{
                        "Attacker",
                        "Defender"
                    });
                    StratSelector.Items.Clear();
                    OperatorSelector.Items.Clear();
                    OperatorInfoText.Text = "";
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void SiteSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Global.activeControl == SiteSelector)
                {
                    SideSelector.Items.Clear();
                    SideSelector.Items.AddRange(new string[]{
                        "Attacker",
                        "Defender"
                    });
                    StratSelector.Items.Clear();
                    OperatorSelector.Items.Clear();
                    OperatorInfoText.Text = "";
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void SideSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Global.activeControl == SideSelector)
                {
                    StratSelector.Items.Clear();
                    OperatorSelector.Items.Clear();
                    OperatorInfoText.Text = "";

                    bool isAttacker = false;

                    if (SideSelector.Text.ToLower().StartsWith("att"))
                    {
                        isAttacker = true;
                    }

                    string map = MapSelector.Text;
                    string site = SiteSelector.Text;

                    List<string> stratList = new List<string>();

                    //Get any names of existing strats from the database and fill the strat selector combobox with them.
                    await Task.Run(() => stratList = DatabaseFunctions.GetStratNames(map, site, isAttacker));
                    StratSelector.Items.AddRange(stratList.Distinct().ToArray());
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void StratSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Global.activeControl == StratSelector)
                {
                    bool isAttacker = false;

                    //If user selected attacker, set operator selector panel to only show attacking operators.
                    if (SideSelector.Text.ToLower().StartsWith("att"))
                    {
                        isAttacker = true;
                    }

                    //Else if user selected defender then show defending operators.
                    else if (SideSelector.Text.ToLower().StartsWith("def"))
                    {
                        isAttacker = false;
                    }

                    string map = MapSelector.Text;
                    string site = SiteSelector.Text;
                    string strat = StratSelector.Text;

                    List<string> opList = new List<string>();

                    //Get the names of any ops that are part of the selected strat.
                    await Task.Run(() => opList = DatabaseFunctions.GetOps(map, site, isAttacker, strat));

                    OperatorSelector.Items.Clear();
                    OperatorSelector.Items.AddRange(opList.ToArray());

                    OperatorInfoText.Text = "";
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void OperatorSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Global.activeControl == OperatorSelector)
                {
                    bool isAttacker = false;

                    if (SideSelector.Text.ToLower().StartsWith("att"))
                    {
                        isAttacker = true;
                    }

                    string map = MapSelector.Text;
                    string site = SiteSelector.Text;
                    string strat = StratSelector.Text;
                    string op = OperatorSelector.Text;

                    string OPText = "";

                    //Get any names of existing strats from the database and fill the strat selector combobox with them.
                    await Task.Run(() => OPText = DatabaseFunctions.GetOpText(map, site, isAttacker, strat, op));
                    await Task.Run(() => Global.tempStratID = DatabaseFunctions.GetID(map, site, isAttacker, strat, op));

                    OperatorInfoText.Text = OPText;
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void EditStratButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(CreatePanel, "Do you want to save your changes to the selected strat?", "Strat Wizard", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bool isAttacker = false;

                    if (SideSelector.Text.ToLower().StartsWith("att"))
                    {
                        isAttacker = true;
                    }

                    DatabaseFunctions.Strats strats = new DatabaseFunctions.Strats()
                    {
                        ID = Global.tempStratID,
                        Map = MapSelector.Text,
                        Site = SiteSelector.Text,
                        Strat = StratSelector.Text,
                        OP = OperatorSelector.Text,
                        OPText = OperatorInfoText.Text,
                        IsAttack = isAttacker
                    };

                    if (await Task.Run(() => DatabaseFunctions.UpdateStrats(strats)))
                    {
                        MessageBox.Show("Successfully edited the strat!");
                    }
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateOperatorInfo_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void OperatorInfoText_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void GetStratButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.searchMetadata.Contains(SearchBox.Text))
                {
                    SetSelectors(SearchBox.Text);
                }
                else
                {
                    throw new Exception("You need to select a strat from the dropdown menu in the search bar.");
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        public async void SetSelectors(string selectedStrat)
        {
            try
            {
                await Task.Run(async () =>
                {
                string[] strat = selectedStrat.Split(',');
                bool isAttacker = false;

                if (strat[2].ToLower().StartsWith("att"))
                {
                    isAttacker = true;
                }
                else
                {
                    isAttacker = false;
                }

                    MapSelector.Invoke(new Action(() =>
                        MapSelector.Text = strat[0]));

                    SiteSelector.Invoke(new Action(() =>
                        SiteSelector.Items.Clear()));

                    SiteSelector.Invoke(new Action(() =>
                        SiteSelector.Items.AddRange(Global.currentMapList.Where(t => t.Name == MapSelector.Text).First().Sites.ToArray())));

                    SiteSelector.Invoke(new Action(() =>
                        SiteSelector.Text = strat[1]));

                    SideSelector.Invoke(new Action(() =>
                        SideSelector.Text = strat[2]));

                    StratSelector.Invoke(new Action(() =>
                        StratSelector.Items.Clear()));

                    List<string> templist = new List<string>();
                    await Task.Run(() => templist = DatabaseFunctions.GetStratNames(strat[0], strat[1], isAttacker));

                    StratSelector.Invoke(new Action(() =>
                        StratSelector.Items.AddRange(templist.Distinct().ToArray())));

                    StratSelector.Invoke(new Action(() =>
                        StratSelector.Text = strat[3]));

                    OperatorSelector.Invoke(new Action(() =>
                        OperatorSelector.Items.Clear()));

                    await Task.Run(() => templist = DatabaseFunctions.GetOps(strat[0], strat[1], isAttacker, strat[3]));

                    OperatorSelector.Invoke(new Action(() =>
                        OperatorSelector.Items.AddRange(templist.ToArray())));

                    OperatorSelector.Invoke(new Action(() =>
                        OperatorSelector.Text = strat[4]));

                    string tempstr = "";
                    await Task.Run(() => tempstr = DatabaseFunctions.GetOpText(strat[0], strat[1], isAttacker, strat[3], strat[4]));

                    OperatorInfoText.Invoke(new Action(() =>
                        OperatorInfoText.Text = tempstr));

                    Global.tempStratID = DatabaseFunctions.GetID(strat[0], strat[1], isAttacker, strat[3], strat[4]);
                });
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void MapSelector_Enter(object sender, EventArgs e)
        {
            Global.activeControl = MapSelector;
            List<Map> maplist = new List<Map>();
            string map = "";
            string site = "";

            foreach (var metadata in Global.searchMetadata)
            {
                List<string> tempList = metadata.Split(',').ToList();
                map = tempList[0];
                site = tempList[1];
                if (maplist.Any(x => x.Name == map.ToString()))
                {
                    if (maplist.Any(x => x.Name == map.ToString() && !x.Sites.Contains(site.ToString())))
                    {
                        foreach (var Map in maplist)
                        {
                            if (Map.Name == map.ToString())
                            {
                                Map.Sites.Add(site.ToString());
                                break;
                            }
                        }
                    }
                }
                else
                {
                    maplist.Add(new Map { Name = map.ToString(), Sites = new List<string>() { site.ToString() } });
                }
            }

            Global.currentMapList = maplist;
            MapSelector.Items.Clear();
            maplist.ForEach(x => MapSelector.Items.Add(x.Name));
        }

        private void SetMaps()
        {
            List<Map> maplist = new List<Map>();
            string map = "";
            string site = "";

            foreach (var metadata in Global.searchMetadata)
            {
                List<string> tempList = metadata.Split(',').ToList();
                map = tempList[0];
                site = tempList[1];
                if (maplist.Any(x => x.Name == map.ToString()))
                {
                    if (maplist.Any(x => x.Name == map.ToString() && !x.Sites.Contains(site.ToString())))
                    {
                        foreach (var Map in maplist)
                        {
                            if (Map.Name == map.ToString())
                            {
                                Map.Sites.Add(site.ToString());
                                break;
                            }
                        }
                    }
                }
                else
                {
                    maplist.Add(new Map { Name = map.ToString(), Sites = new List<string>() { site.ToString() } });
                }
            }

            Global.currentMapList = maplist;
            MapSelector.Items.Clear();
            maplist.ForEach(x => MapSelector.Items.Add(x.Name));
        }

        private void MapSelector_Leave(object sender, EventArgs e)
        {
            Global.activeControl = null;
        }

        private void SiteSelector_Enter(object sender, EventArgs e)
        {
            Global.activeControl = SiteSelector;
        }

        private void SiteSelector_Leave(object sender, EventArgs e)
        {
            Global.activeControl = null;
        }

        private void SideSelector_Enter(object sender, EventArgs e)
        {
            Global.activeControl = SideSelector;
        }

        private void SideSelector_Leave(object sender, EventArgs e)
        {
            Global.activeControl = null;
        }

        private void StratSelector_Enter(object sender, EventArgs e)
        {
            Global.activeControl = StratSelector;
        }

        private void StratSelector_Leave(object sender, EventArgs e)
        {
            Global.activeControl = null;
        }

        private void OperatorSelector_Enter(object sender, EventArgs e)
        {
            Global.activeControl = OperatorSelector;
        }

        private void OperatorSelector_Leave(object sender, EventArgs e)
        {
            Global.activeControl = null;
        }

        private void CreateStratSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Once user has selected a strat, proceed to the select op step of the creation wizard.
                if (wizardState == WizardState.Strat)
                {
                    CreateOperatorSelector.Visible = true;
                    MessageBox.Show(CreatePanel, "Select an Operator!", "Strat Wizard");
                    Blink(CreateOperatorSelector);
                    wizardState = WizardState.OP;
                }

                CreateOperatorSelector.Text = "";
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateOperatorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Once user has selected a op, proceed to the select op text step of the creation wizard.
                if (wizardState == WizardState.OP)
                {
                    CreateOperatorInfo.Visible = true;
                    MessageBox.Show(CreatePanel, "Fill the textbox with whatever is needed for the strat. Once you are done, click the Create Strat button in the bottom left corner of the window. You can also drag photos into the textbox.", "Strat Wizard");
                    wizardState = WizardState.Text;
                    CreateCreateStratButton.Visible = true;
                    CreateOperatorInfo.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private async void OperatorInfoText_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
                foreach(string file in files)
                {
                    Form f = new WaitForm();
                    f.Show(this);
                    this.Enabled = false;
                    string tempstr = await Global.imgurAPI.UploadImage(file);
                    OperatorInfoText.AppendText(Environment.NewLine + tempstr + Environment.NewLine);
                    this.Enabled = true;
                    f.Close();
                }
            }
        }

        private async void CreateOperatorInfo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop, false));
                foreach (string file in files)
                {
                    Form f = new WaitForm();
                    f.Show(this);
                    this.Enabled = false;
                    string tempstr = await Global.imgurAPI.UploadImage(file);
                    CreateOperatorInfo.AppendText(Environment.NewLine + tempstr + Environment.NewLine);
                    this.Enabled = true;
                    f.Close();
                }
            }
        }

        private async void CreateStratSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            bool isAttacker = false;

            if (CreateSideSelector.Text.ToLower().StartsWith("att"))
            {
                isAttacker = true;
            }

            string map = CreateMapSelector.Text;
            string site = CreateSiteSelector.Text;
            string strat = CreateStratSelector.Text;
            List<string> opList = new List<string>();

            await Task.Run(() => opList = DatabaseFunctions.GetOps(map, site, isAttacker, strat)).ConfigureAwait(true);
            opList.ForEach(t => CreateOperatorSelector.Items.Remove(t));
        }

        private async void CreateStratSelector_Validated(object sender, EventArgs e)
        {
            try
            {
                //Once user has selected a strat, proceed to the select op step of the creation wizard.
                if (wizardState == WizardState.Strat)
                {
                    CreateOperatorSelector.Visible = true;
                    MessageBox.Show(CreatePanel, "Select an Operator!", "Strat Wizard");
                    Blink(CreateOperatorSelector);
                    wizardState = WizardState.OP;
                }

                CreateOperatorSelector.Text = "";

                bool isAttacker = false;

                if (CreateSideSelector.Text.ToLower().StartsWith("att"))
                {
                    isAttacker = true;
                }

                string map = CreateMapSelector.Text;
                string site = CreateSiteSelector.Text;
                string strat = CreateStratSelector.Text;
                List<string> opList = new List<string>();

                await Task.Run(() => opList = DatabaseFunctions.GetOps(map, site, isAttacker, strat)).ConfigureAwait(true);
                opList.ForEach(t => CreateOperatorSelector.Items.Remove(t));
            }
            catch(Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreateStratSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CreateOperatorInfo.Focus();
            }
        }

        private void CreateOperatorInfo_Enter(object sender, EventArgs e)
        {
            if (CreateOperatorInfo.Text == "Drag and drop an image, or write some text.")
            {
                CreateOperatorInfo.Text = "";
            }

            wizardState = WizardState.None;
        }

        private async void SearchBox_Enter(object sender, EventArgs e)
        {
            if(SearchBox.Text == "Search")
            {
                SearchBox.Text = "";
            }

            await Task.Run(() => Global.searchMetadata = DatabaseFunctions.GetMetadata()).ConfigureAwait(true);

            SearchBox.Items.AddRange(Global.searchMetadata.ToArray());
            SetMaps();
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            SearchBox.Items.Clear();
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> searchWords = new List<string>();
            List<string> newMetadata = new List<string>();

            if (SearchBox.Text.Contains(' '))
            {
                searchWords = SearchBox.Text.Split(' ').ToList();
            }
            else
            {
                searchWords.Add(SearchBox.Text);
            }

            newMetadata = Global.searchMetadata.Where(x => searchWords.All(y => x.ToLower().Contains(y.ToLower()))).ToList();

            Extensions.SafeClearItems(SearchBox);
            SearchBox.Items.AddRange(newMetadata.ToArray());
        }

        private async void CheckForUpdateButton_Click(object sender, EventArgs e)
        {
            await Updater.CheckForUpdate(true);
        }

        private void ShowChangelogButton_Click(object sender, EventArgs e)
        {
            Updater.ShowChangelog();
        }

        private void CreationWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Global.localData.CreateWizardOn = CreationWizardToolStripMenuItem.Checked;
                Global.JSONHelper.JsonSerialize(Global.localData);
                Refresh();
            }
            catch (Exception ex)
            {
                Global.LogError(ex);
            }
        }

        private void CreationWizardToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(!CreationWizardToolStripMenuItem.Checked)
            {
                CreateMapSelector.Visible = true;
                CreateSiteSelector.Visible = true;
                CreateSideSelector.Visible = true;
                CreateStratSelector.Visible = true;
                CreateOperatorSelector.Visible = true;
                CreateOperatorInfo.ReadOnly = false;
                isBlinking = false;
                wizardState = WizardState.None;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsButton.ShowDropDown();
        }
    }

    public static class Extensions
    {
        public static void SafeClearItems(this ComboBox comboBox)
        {
            foreach (var item in new ArrayList(comboBox.Items))
            {
                comboBox.Items.Remove(item);
            }
        }
    }
}