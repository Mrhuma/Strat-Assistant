namespace Strat_Assistant
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MapSelector = new System.Windows.Forms.ComboBox();
            this.SelectMapText = new System.Windows.Forms.TextBox();
            this.SideSelectorText = new System.Windows.Forms.TextBox();
            this.SideSelector = new System.Windows.Forms.ComboBox();
            this.SelectSiteText = new System.Windows.Forms.TextBox();
            this.SelectStratText = new System.Windows.Forms.TextBox();
            this.SelectOperatorText = new System.Windows.Forms.TextBox();
            this.OperatorSelector = new System.Windows.Forms.ComboBox();
            this.StratSelector = new System.Windows.Forms.ComboBox();
            this.SiteSelector = new System.Windows.Forms.ComboBox();
            this.MainSelectorPanel = new System.Windows.Forms.Panel();
            this.OperatorInfoText = new System.Windows.Forms.RichTextBox();
            this.GetStratButton = new System.Windows.Forms.Button();
            this.EditStratButton = new System.Windows.Forms.Button();
            this.CreateStratButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.versionTextt = new System.Windows.Forms.RichTextBox();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.CreateBackButton = new System.Windows.Forms.Button();
            this.CreateCreateStratButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateSelectMapText = new System.Windows.Forms.TextBox();
            this.CreateSelectSideText = new System.Windows.Forms.TextBox();
            this.CreateSelectSiteText = new System.Windows.Forms.TextBox();
            this.CreateSelectStratText = new System.Windows.Forms.TextBox();
            this.CreateSelectOperatorText = new System.Windows.Forms.TextBox();
            this.CreateOperatorSelector = new System.Windows.Forms.ComboBox();
            this.CreateSideSelector = new System.Windows.Forms.ComboBox();
            this.CreateStratSelector = new System.Windows.Forms.ComboBox();
            this.CreateSiteSelector = new System.Windows.Forms.ComboBox();
            this.CreateMapSelector = new System.Windows.Forms.ComboBox();
            this.CreateOperatorInfo = new System.Windows.Forms.RichTextBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CheckForUpdateButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowChangelogButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.CreationWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.versionText = new System.Windows.Forms.ToolStripLabel();
            this.MainSelectorPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapSelector
            // 
            this.MapSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MapSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MapSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.MapSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapSelector.ForeColor = System.Drawing.Color.White;
            this.MapSelector.FormattingEnabled = true;
            this.MapSelector.Location = new System.Drawing.Point(3, 29);
            this.MapSelector.Name = "MapSelector";
            this.MapSelector.Size = new System.Drawing.Size(100, 21);
            this.MapSelector.Sorted = true;
            this.MapSelector.TabIndex = 0;
            this.MapSelector.SelectedValueChanged += new System.EventHandler(this.MapSelector_SelectedValueChanged);
            this.MapSelector.Enter += new System.EventHandler(this.MapSelector_Enter);
            this.MapSelector.Leave += new System.EventHandler(this.MapSelector_Leave);
            // 
            // SelectMapText
            // 
            this.SelectMapText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SelectMapText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectMapText.ForeColor = System.Drawing.Color.White;
            this.SelectMapText.Location = new System.Drawing.Point(3, 4);
            this.SelectMapText.Name = "SelectMapText";
            this.SelectMapText.ReadOnly = true;
            this.SelectMapText.Size = new System.Drawing.Size(100, 20);
            this.SelectMapText.TabIndex = 100;
            this.SelectMapText.Text = "Map";
            this.SelectMapText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SideSelectorText
            // 
            this.SideSelectorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SideSelectorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideSelectorText.ForeColor = System.Drawing.Color.White;
            this.SideSelectorText.Location = new System.Drawing.Point(215, 4);
            this.SideSelectorText.Name = "SideSelectorText";
            this.SideSelectorText.ReadOnly = true;
            this.SideSelectorText.Size = new System.Drawing.Size(100, 20);
            this.SideSelectorText.TabIndex = 100;
            this.SideSelectorText.Text = "Side";
            this.SideSelectorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SideSelector
            // 
            this.SideSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SideSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SideSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideSelector.ForeColor = System.Drawing.Color.White;
            this.SideSelector.FormattingEnabled = true;
            this.SideSelector.Items.AddRange(new object[] {
            "Attacker",
            "Defender"});
            this.SideSelector.Location = new System.Drawing.Point(215, 29);
            this.SideSelector.Name = "SideSelector";
            this.SideSelector.Size = new System.Drawing.Size(100, 21);
            this.SideSelector.Sorted = true;
            this.SideSelector.TabIndex = 2;
            this.SideSelector.SelectedValueChanged += new System.EventHandler(this.SideSelector_SelectedValueChanged);
            this.SideSelector.Enter += new System.EventHandler(this.SideSelector_Enter);
            this.SideSelector.Leave += new System.EventHandler(this.SideSelector_Leave);
            // 
            // SelectSiteText
            // 
            this.SelectSiteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SelectSiteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectSiteText.ForeColor = System.Drawing.Color.White;
            this.SelectSiteText.Location = new System.Drawing.Point(109, 4);
            this.SelectSiteText.Name = "SelectSiteText";
            this.SelectSiteText.ReadOnly = true;
            this.SelectSiteText.Size = new System.Drawing.Size(100, 20);
            this.SelectSiteText.TabIndex = 100;
            this.SelectSiteText.Text = "Site";
            this.SelectSiteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectStratText
            // 
            this.SelectStratText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SelectStratText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectStratText.ForeColor = System.Drawing.Color.White;
            this.SelectStratText.Location = new System.Drawing.Point(321, 4);
            this.SelectStratText.Name = "SelectStratText";
            this.SelectStratText.ReadOnly = true;
            this.SelectStratText.Size = new System.Drawing.Size(100, 20);
            this.SelectStratText.TabIndex = 100;
            this.SelectStratText.Text = "Strat Name";
            this.SelectStratText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectOperatorText
            // 
            this.SelectOperatorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SelectOperatorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectOperatorText.ForeColor = System.Drawing.Color.White;
            this.SelectOperatorText.Location = new System.Drawing.Point(427, 4);
            this.SelectOperatorText.Name = "SelectOperatorText";
            this.SelectOperatorText.ReadOnly = true;
            this.SelectOperatorText.Size = new System.Drawing.Size(100, 20);
            this.SelectOperatorText.TabIndex = 100;
            this.SelectOperatorText.Text = "Operator";
            this.SelectOperatorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperatorSelector
            // 
            this.OperatorSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.OperatorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperatorSelector.ForeColor = System.Drawing.Color.White;
            this.OperatorSelector.FormattingEnabled = true;
            this.OperatorSelector.Location = new System.Drawing.Point(427, 29);
            this.OperatorSelector.Name = "OperatorSelector";
            this.OperatorSelector.Size = new System.Drawing.Size(100, 21);
            this.OperatorSelector.Sorted = true;
            this.OperatorSelector.TabIndex = 4;
            this.OperatorSelector.SelectedValueChanged += new System.EventHandler(this.OperatorSelector_SelectedValueChanged);
            this.OperatorSelector.Enter += new System.EventHandler(this.OperatorSelector_Enter);
            this.OperatorSelector.Leave += new System.EventHandler(this.OperatorSelector_Leave);
            // 
            // StratSelector
            // 
            this.StratSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.StratSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StratSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StratSelector.ForeColor = System.Drawing.Color.White;
            this.StratSelector.FormattingEnabled = true;
            this.StratSelector.Location = new System.Drawing.Point(321, 29);
            this.StratSelector.Name = "StratSelector";
            this.StratSelector.Size = new System.Drawing.Size(100, 21);
            this.StratSelector.Sorted = true;
            this.StratSelector.TabIndex = 3;
            this.StratSelector.SelectedValueChanged += new System.EventHandler(this.StratSelector_SelectedValueChanged);
            this.StratSelector.Enter += new System.EventHandler(this.StratSelector_Enter);
            this.StratSelector.Leave += new System.EventHandler(this.StratSelector_Leave);
            // 
            // SiteSelector
            // 
            this.SiteSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SiteSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SiteSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SiteSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SiteSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiteSelector.ForeColor = System.Drawing.Color.White;
            this.SiteSelector.FormattingEnabled = true;
            this.SiteSelector.Location = new System.Drawing.Point(109, 29);
            this.SiteSelector.Name = "SiteSelector";
            this.SiteSelector.Size = new System.Drawing.Size(100, 21);
            this.SiteSelector.Sorted = true;
            this.SiteSelector.TabIndex = 1;
            this.SiteSelector.SelectedValueChanged += new System.EventHandler(this.SiteSelector_SelectedValueChanged);
            this.SiteSelector.Enter += new System.EventHandler(this.SiteSelector_Enter);
            this.SiteSelector.Leave += new System.EventHandler(this.SiteSelector_Leave);
            // 
            // MainSelectorPanel
            // 
            this.MainSelectorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.MainSelectorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainSelectorPanel.Controls.Add(this.SelectMapText);
            this.MainSelectorPanel.Controls.Add(this.SideSelectorText);
            this.MainSelectorPanel.Controls.Add(this.SelectSiteText);
            this.MainSelectorPanel.Controls.Add(this.SelectStratText);
            this.MainSelectorPanel.Controls.Add(this.SelectOperatorText);
            this.MainSelectorPanel.Controls.Add(this.OperatorSelector);
            this.MainSelectorPanel.Controls.Add(this.SideSelector);
            this.MainSelectorPanel.Controls.Add(this.StratSelector);
            this.MainSelectorPanel.Controls.Add(this.SiteSelector);
            this.MainSelectorPanel.Controls.Add(this.MapSelector);
            this.MainSelectorPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.MainSelectorPanel.Location = new System.Drawing.Point(3, 32);
            this.MainSelectorPanel.Name = "MainSelectorPanel";
            this.MainSelectorPanel.Size = new System.Drawing.Size(530, 53);
            this.MainSelectorPanel.TabIndex = 11;
            // 
            // OperatorInfoText
            // 
            this.OperatorInfoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.OperatorInfoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OperatorInfoText.ForeColor = System.Drawing.Color.White;
            this.OperatorInfoText.Location = new System.Drawing.Point(3, 91);
            this.OperatorInfoText.Name = "OperatorInfoText";
            this.OperatorInfoText.Size = new System.Drawing.Size(530, 200);
            this.OperatorInfoText.TabIndex = 5;
            this.OperatorInfoText.Text = "";
            this.OperatorInfoText.DragDrop += new System.Windows.Forms.DragEventHandler(this.OperatorInfoText_DragDrop);
            this.OperatorInfoText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OperatorInfoText_LinkClicked);
            // 
            // GetStratButton
            // 
            this.GetStratButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.GetStratButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.GetStratButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetStratButton.ForeColor = System.Drawing.Color.White;
            this.GetStratButton.Location = new System.Drawing.Point(431, 3);
            this.GetStratButton.Name = "GetStratButton";
            this.GetStratButton.Size = new System.Drawing.Size(100, 23);
            this.GetStratButton.TabIndex = 7;
            this.GetStratButton.Text = "Select Strat";
            this.GetStratButton.UseVisualStyleBackColor = false;
            this.GetStratButton.Click += new System.EventHandler(this.GetStratButton_Click);
            // 
            // EditStratButton
            // 
            this.EditStratButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.EditStratButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.EditStratButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStratButton.ForeColor = System.Drawing.Color.White;
            this.EditStratButton.Location = new System.Drawing.Point(431, 297);
            this.EditStratButton.Name = "EditStratButton";
            this.EditStratButton.Size = new System.Drawing.Size(100, 23);
            this.EditStratButton.TabIndex = 13;
            this.EditStratButton.Text = "Edit Strat";
            this.EditStratButton.UseVisualStyleBackColor = false;
            this.EditStratButton.Click += new System.EventHandler(this.EditStratButton_Click);
            // 
            // CreateStratButton
            // 
            this.CreateStratButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateStratButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.CreateStratButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStratButton.ForeColor = System.Drawing.Color.White;
            this.CreateStratButton.Location = new System.Drawing.Point(7, 297);
            this.CreateStratButton.Name = "CreateStratButton";
            this.CreateStratButton.Size = new System.Drawing.Size(100, 23);
            this.CreateStratButton.TabIndex = 14;
            this.CreateStratButton.Text = "Strat Creator";
            this.CreateStratButton.UseVisualStyleBackColor = false;
            this.CreateStratButton.Click += new System.EventHandler(this.CreateStratButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.versionTextt);
            this.MainPanel.Controls.Add(this.SearchBox);
            this.MainPanel.Controls.Add(this.EditStratButton);
            this.MainPanel.Controls.Add(this.CreateStratButton);
            this.MainPanel.Controls.Add(this.GetStratButton);
            this.MainPanel.Controls.Add(this.MainSelectorPanel);
            this.MainPanel.Controls.Add(this.OperatorInfoText);
            this.MainPanel.Location = new System.Drawing.Point(10, 36);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(535, 325);
            this.MainPanel.TabIndex = 16;
            // 
            // versionTextt
            // 
            this.versionTextt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.versionTextt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionTextt.ForeColor = System.Drawing.Color.White;
            this.versionTextt.Location = new System.Drawing.Point(325, 297);
            this.versionTextt.Multiline = false;
            this.versionTextt.Name = "versionTextt";
            this.versionTextt.ReadOnly = true;
            this.versionTextt.Size = new System.Drawing.Size(100, 23);
            this.versionTextt.TabIndex = 102;
            this.versionTextt.Text = "";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Location = new System.Drawing.Point(7, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(418, 21);
            this.SearchBox.Sorted = true;
            this.SearchBox.TabIndex = 101;
            this.SearchBox.Text = "Search";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // CreatePanel
            // 
            this.CreatePanel.Controls.Add(this.CreateBackButton);
            this.CreatePanel.Controls.Add(this.CreateCreateStratButton);
            this.CreatePanel.Controls.Add(this.panel2);
            this.CreatePanel.Controls.Add(this.CreateOperatorInfo);
            this.CreatePanel.Location = new System.Drawing.Point(10, 36);
            this.CreatePanel.Margin = new System.Windows.Forms.Padding(10);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(535, 325);
            this.CreatePanel.TabIndex = 17;
            this.CreatePanel.Visible = false;
            this.CreatePanel.VisibleChanged += new System.EventHandler(this.CreatePanel_VisibleChanged);
            // 
            // CreateBackButton
            // 
            this.CreateBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.CreateBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBackButton.ForeColor = System.Drawing.Color.White;
            this.CreateBackButton.Location = new System.Drawing.Point(431, 297);
            this.CreateBackButton.Name = "CreateBackButton";
            this.CreateBackButton.Size = new System.Drawing.Size(100, 23);
            this.CreateBackButton.TabIndex = 17;
            this.CreateBackButton.Text = "Back";
            this.CreateBackButton.UseVisualStyleBackColor = false;
            this.CreateBackButton.Click += new System.EventHandler(this.CreateBackButton_Click);
            // 
            // CreateCreateStratButton
            // 
            this.CreateCreateStratButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateCreateStratButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.CreateCreateStratButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCreateStratButton.ForeColor = System.Drawing.Color.White;
            this.CreateCreateStratButton.Location = new System.Drawing.Point(7, 297);
            this.CreateCreateStratButton.Name = "CreateCreateStratButton";
            this.CreateCreateStratButton.Size = new System.Drawing.Size(100, 23);
            this.CreateCreateStratButton.TabIndex = 6;
            this.CreateCreateStratButton.Text = "Create Strat";
            this.CreateCreateStratButton.UseVisualStyleBackColor = false;
            this.CreateCreateStratButton.Visible = false;
            this.CreateCreateStratButton.Click += new System.EventHandler(this.CreateCreateStratButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CreateSelectMapText);
            this.panel2.Controls.Add(this.CreateSelectSideText);
            this.panel2.Controls.Add(this.CreateSelectSiteText);
            this.panel2.Controls.Add(this.CreateSelectStratText);
            this.panel2.Controls.Add(this.CreateSelectOperatorText);
            this.panel2.Controls.Add(this.CreateOperatorSelector);
            this.panel2.Controls.Add(this.CreateSideSelector);
            this.panel2.Controls.Add(this.CreateStratSelector);
            this.panel2.Controls.Add(this.CreateSiteSelector);
            this.panel2.Controls.Add(this.CreateMapSelector);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 53);
            this.panel2.TabIndex = 11;
            // 
            // CreateSelectMapText
            // 
            this.CreateSelectMapText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSelectMapText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSelectMapText.ForeColor = System.Drawing.Color.White;
            this.CreateSelectMapText.Location = new System.Drawing.Point(3, 4);
            this.CreateSelectMapText.Name = "CreateSelectMapText";
            this.CreateSelectMapText.ReadOnly = true;
            this.CreateSelectMapText.Size = new System.Drawing.Size(100, 20);
            this.CreateSelectMapText.TabIndex = 100;
            this.CreateSelectMapText.Text = "Select Map";
            this.CreateSelectMapText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateSelectSideText
            // 
            this.CreateSelectSideText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSelectSideText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSelectSideText.ForeColor = System.Drawing.Color.White;
            this.CreateSelectSideText.Location = new System.Drawing.Point(215, 4);
            this.CreateSelectSideText.Name = "CreateSelectSideText";
            this.CreateSelectSideText.ReadOnly = true;
            this.CreateSelectSideText.Size = new System.Drawing.Size(100, 20);
            this.CreateSelectSideText.TabIndex = 100;
            this.CreateSelectSideText.Text = "Select Side";
            this.CreateSelectSideText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateSelectSideText.Visible = false;
            // 
            // CreateSelectSiteText
            // 
            this.CreateSelectSiteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSelectSiteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSelectSiteText.ForeColor = System.Drawing.Color.White;
            this.CreateSelectSiteText.Location = new System.Drawing.Point(109, 4);
            this.CreateSelectSiteText.Name = "CreateSelectSiteText";
            this.CreateSelectSiteText.ReadOnly = true;
            this.CreateSelectSiteText.Size = new System.Drawing.Size(100, 20);
            this.CreateSelectSiteText.TabIndex = 100;
            this.CreateSelectSiteText.Text = "Select Site";
            this.CreateSelectSiteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateSelectSiteText.Visible = false;
            // 
            // CreateSelectStratText
            // 
            this.CreateSelectStratText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSelectStratText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSelectStratText.ForeColor = System.Drawing.Color.White;
            this.CreateSelectStratText.Location = new System.Drawing.Point(321, 4);
            this.CreateSelectStratText.Name = "CreateSelectStratText";
            this.CreateSelectStratText.ReadOnly = true;
            this.CreateSelectStratText.Size = new System.Drawing.Size(100, 20);
            this.CreateSelectStratText.TabIndex = 100;
            this.CreateSelectStratText.Text = "Select Strat";
            this.CreateSelectStratText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateSelectStratText.Visible = false;
            // 
            // CreateSelectOperatorText
            // 
            this.CreateSelectOperatorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSelectOperatorText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateSelectOperatorText.ForeColor = System.Drawing.Color.White;
            this.CreateSelectOperatorText.Location = new System.Drawing.Point(427, 4);
            this.CreateSelectOperatorText.Name = "CreateSelectOperatorText";
            this.CreateSelectOperatorText.ReadOnly = true;
            this.CreateSelectOperatorText.Size = new System.Drawing.Size(100, 20);
            this.CreateSelectOperatorText.TabIndex = 100;
            this.CreateSelectOperatorText.Text = "Select Operator";
            this.CreateSelectOperatorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateSelectOperatorText.Visible = false;
            // 
            // CreateOperatorSelector
            // 
            this.CreateOperatorSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateOperatorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateOperatorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOperatorSelector.ForeColor = System.Drawing.Color.White;
            this.CreateOperatorSelector.FormattingEnabled = true;
            this.CreateOperatorSelector.Location = new System.Drawing.Point(427, 29);
            this.CreateOperatorSelector.Name = "CreateOperatorSelector";
            this.CreateOperatorSelector.Size = new System.Drawing.Size(100, 21);
            this.CreateOperatorSelector.Sorted = true;
            this.CreateOperatorSelector.TabIndex = 4;
            this.CreateOperatorSelector.Visible = false;
            this.CreateOperatorSelector.SelectedIndexChanged += new System.EventHandler(this.CreateOperatorSelector_SelectedIndexChanged);
            this.CreateOperatorSelector.VisibleChanged += new System.EventHandler(this.CreateOperatorSelector_VisibleChanged);
            this.CreateOperatorSelector.Click += new System.EventHandler(this.DisableBlink);
            // 
            // CreateSideSelector
            // 
            this.CreateSideSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSideSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateSideSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSideSelector.ForeColor = System.Drawing.Color.White;
            this.CreateSideSelector.FormattingEnabled = true;
            this.CreateSideSelector.Items.AddRange(new object[] {
            "Attacker",
            "Defender"});
            this.CreateSideSelector.Location = new System.Drawing.Point(215, 29);
            this.CreateSideSelector.Name = "CreateSideSelector";
            this.CreateSideSelector.Size = new System.Drawing.Size(100, 21);
            this.CreateSideSelector.Sorted = true;
            this.CreateSideSelector.TabIndex = 2;
            this.CreateSideSelector.Visible = false;
            this.CreateSideSelector.SelectedValueChanged += new System.EventHandler(this.CreateSideSelector_SelectedValueChanged);
            this.CreateSideSelector.VisibleChanged += new System.EventHandler(this.CreateSideSelector_VisibleChanged);
            this.CreateSideSelector.Click += new System.EventHandler(this.DisableBlink);
            // 
            // CreateStratSelector
            // 
            this.CreateStratSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateStratSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStratSelector.ForeColor = System.Drawing.Color.White;
            this.CreateStratSelector.FormattingEnabled = true;
            this.CreateStratSelector.Location = new System.Drawing.Point(321, 29);
            this.CreateStratSelector.Name = "CreateStratSelector";
            this.CreateStratSelector.Size = new System.Drawing.Size(100, 21);
            this.CreateStratSelector.Sorted = true;
            this.CreateStratSelector.TabIndex = 3;
            this.CreateStratSelector.Visible = false;
            this.CreateStratSelector.VisibleChanged += new System.EventHandler(this.CreateStratSelector_VisibleChanged);
            this.CreateStratSelector.Click += new System.EventHandler(this.DisableBlink);
            this.CreateStratSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateStratSelector_KeyDown);
            this.CreateStratSelector.Validated += new System.EventHandler(this.CreateStratSelector_Validated);
            // 
            // CreateSiteSelector
            // 
            this.CreateSiteSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CreateSiteSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CreateSiteSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateSiteSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateSiteSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSiteSelector.ForeColor = System.Drawing.Color.White;
            this.CreateSiteSelector.FormattingEnabled = true;
            this.CreateSiteSelector.Location = new System.Drawing.Point(109, 29);
            this.CreateSiteSelector.Name = "CreateSiteSelector";
            this.CreateSiteSelector.Size = new System.Drawing.Size(100, 21);
            this.CreateSiteSelector.Sorted = true;
            this.CreateSiteSelector.TabIndex = 1;
            this.CreateSiteSelector.Visible = false;
            this.CreateSiteSelector.SelectedIndexChanged += new System.EventHandler(this.CreateSiteSelector_SelectedIndexChanged);
            this.CreateSiteSelector.SelectedValueChanged += new System.EventHandler(this.CreateSiteSelector_SelectedValueChanged);
            this.CreateSiteSelector.VisibleChanged += new System.EventHandler(this.CreateSiteSelector_VisibleChanged);
            this.CreateSiteSelector.Click += new System.EventHandler(this.DisableBlink);
            // 
            // CreateMapSelector
            // 
            this.CreateMapSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CreateMapSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CreateMapSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateMapSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateMapSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMapSelector.ForeColor = System.Drawing.Color.White;
            this.CreateMapSelector.FormattingEnabled = true;
            this.CreateMapSelector.Location = new System.Drawing.Point(3, 29);
            this.CreateMapSelector.Name = "CreateMapSelector";
            this.CreateMapSelector.Size = new System.Drawing.Size(100, 21);
            this.CreateMapSelector.Sorted = true;
            this.CreateMapSelector.TabIndex = 0;
            this.CreateMapSelector.SelectedIndexChanged += new System.EventHandler(this.CreateMapSelector_SelectedIndexChanged);
            this.CreateMapSelector.SelectedValueChanged += new System.EventHandler(this.CreateMapSelector_SelectedValueChanged);
            this.CreateMapSelector.Click += new System.EventHandler(this.DisableBlink);
            // 
            // CreateOperatorInfo
            // 
            this.CreateOperatorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CreateOperatorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateOperatorInfo.ForeColor = System.Drawing.Color.White;
            this.CreateOperatorInfo.Location = new System.Drawing.Point(3, 91);
            this.CreateOperatorInfo.Name = "CreateOperatorInfo";
            this.CreateOperatorInfo.Size = new System.Drawing.Size(530, 200);
            this.CreateOperatorInfo.TabIndex = 5;
            this.CreateOperatorInfo.Text = "Drag and drop an image, or write some text.";
            this.CreateOperatorInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.CreateOperatorInfo_DragDrop);
            this.CreateOperatorInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.CreateOperatorInfo_LinkClicked);
            this.CreateOperatorInfo.Click += new System.EventHandler(this.DisableBlink);
            this.CreateOperatorInfo.Enter += new System.EventHandler(this.CreateOperatorInfo_Enter);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.CheckForUpdateButton,
            this.toolStripSeparator2,
            this.ShowChangelogButton,
            this.toolStripSeparator3,
            this.SettingsButton,
            this.toolStripSeparator4,
            this.versionText});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(554, 25);
            this.ToolStrip.TabIndex = 18;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CheckForUpdateButton
            // 
            this.CheckForUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.CheckForUpdateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CheckForUpdateButton.ForeColor = System.Drawing.Color.White;
            this.CheckForUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckForUpdateButton.Image")));
            this.CheckForUpdateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckForUpdateButton.Name = "CheckForUpdateButton";
            this.CheckForUpdateButton.Size = new System.Drawing.Size(103, 22);
            this.CheckForUpdateButton.Text = "Check for Update";
            this.CheckForUpdateButton.ToolTipText = "Checks for an update";
            this.CheckForUpdateButton.Click += new System.EventHandler(this.CheckForUpdateButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ShowChangelogButton
            // 
            this.ShowChangelogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ShowChangelogButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowChangelogButton.ForeColor = System.Drawing.Color.White;
            this.ShowChangelogButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowChangelogButton.Image")));
            this.ShowChangelogButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowChangelogButton.Name = "ShowChangelogButton";
            this.ShowChangelogButton.Size = new System.Drawing.Size(69, 22);
            this.ShowChangelogButton.Text = "Changelog";
            this.ShowChangelogButton.ToolTipText = "Displays the changelog";
            this.ShowChangelogButton.Click += new System.EventHandler(this.ShowChangelogButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreationWizardToolStripMenuItem});
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(65, 22);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // CreationWizardToolStripMenuItem
            // 
            this.CreationWizardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.CreationWizardToolStripMenuItem.Checked = true;
            this.CreationWizardToolStripMenuItem.CheckOnClick = true;
            this.CreationWizardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreationWizardToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreationWizardToolStripMenuItem.Name = "CreationWizardToolStripMenuItem";
            this.CreationWizardToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CreationWizardToolStripMenuItem.Text = "Creation Wizard";
            this.CreationWizardToolStripMenuItem.ToolTipText = "Toggles the Creation Wizard help tool when creating a new strat.";
            this.CreationWizardToolStripMenuItem.CheckedChanged += new System.EventHandler(this.CreationWizardToolStripMenuItem_CheckedChanged);
            this.CreationWizardToolStripMenuItem.Click += new System.EventHandler(this.CreationWizardToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // versionText
            // 
            this.versionText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.versionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(45, 22);
            this.versionText.Text = "Version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.CreatePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strat Assistant";
            this.MainSelectorPanel.ResumeLayout(false);
            this.MainSelectorPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.CreatePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MapSelector;
        private System.Windows.Forms.TextBox SelectMapText;
        private System.Windows.Forms.TextBox SideSelectorText;
        private System.Windows.Forms.ComboBox SideSelector;
        private System.Windows.Forms.TextBox SelectSiteText;
        private System.Windows.Forms.TextBox SelectStratText;
        private System.Windows.Forms.TextBox SelectOperatorText;
        private System.Windows.Forms.ComboBox OperatorSelector;
        private System.Windows.Forms.ComboBox StratSelector;
        private System.Windows.Forms.ComboBox SiteSelector;
        private System.Windows.Forms.Panel MainSelectorPanel;
        private System.Windows.Forms.RichTextBox OperatorInfoText;
        private System.Windows.Forms.Button GetStratButton;
        private System.Windows.Forms.Button EditStratButton;
        private System.Windows.Forms.Button CreateStratButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Button CreateCreateStratButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CreateSelectMapText;
        private System.Windows.Forms.TextBox CreateSelectSideText;
        private System.Windows.Forms.TextBox CreateSelectSiteText;
        private System.Windows.Forms.TextBox CreateSelectStratText;
        private System.Windows.Forms.TextBox CreateSelectOperatorText;
        private System.Windows.Forms.ComboBox CreateOperatorSelector;
        private System.Windows.Forms.ComboBox CreateSideSelector;
        private System.Windows.Forms.ComboBox CreateStratSelector;
        private System.Windows.Forms.ComboBox CreateSiteSelector;
        private System.Windows.Forms.ComboBox CreateMapSelector;
        private System.Windows.Forms.RichTextBox CreateOperatorInfo;
        private System.Windows.Forms.Button CreateBackButton;
        private System.Windows.Forms.ComboBox SearchBox;
        private System.Windows.Forms.RichTextBox versionTextt;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton CheckForUpdateButton;
        private System.Windows.Forms.ToolStripButton ShowChangelogButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem CreationWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel versionText;
    }
}

