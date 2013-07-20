namespace SharpTwitchi {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ControlToolstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AutoRefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.AutoRefreshStatus = new System.Windows.Forms.ToolStripLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TabWindow = new System.Windows.Forms.TabControl();
            this.LiveTab = new System.Windows.Forms.TabPage();
            this.LiveDisplay = new System.Windows.Forms.WebBrowser();
            this.ChannelsTab = new System.Windows.Forms.TabPage();
            this.ChannelsToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddChannelBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllBtn = new System.Windows.Forms.ToolStripButton();
            this.DeselectAllBtn = new System.Windows.Forms.ToolStripButton();
            this.ChannelListBox = new System.Windows.Forms.ListBox();
            this.AutoRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.ControlToolstrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.TabWindow.SuspendLayout();
            this.LiveTab.SuspendLayout();
            this.ChannelsTab.SuspendLayout();
            this.ChannelsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlToolstrip
            // 
            this.ControlToolstrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ControlToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2,
            this.AutoRefreshBtn,
            this.AutoRefreshStatus});
            this.ControlToolstrip.Location = new System.Drawing.Point(0, 348);
            this.ControlToolstrip.Name = "ControlToolstrip";
            this.ControlToolstrip.Padding = new System.Windows.Forms.Padding(0);
            this.ControlToolstrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlToolstrip.Size = new System.Drawing.Size(592, 25);
            this.ControlToolstrip.TabIndex = 1;
            this.ControlToolstrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(66, 22);
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AutoRefreshBtn
            // 
            this.AutoRefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("AutoRefreshBtn.Image")));
            this.AutoRefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoRefreshBtn.Name = "AutoRefreshBtn";
            this.AutoRefreshBtn.Size = new System.Drawing.Size(95, 22);
            this.AutoRefreshBtn.Text = "Auto Refresh";
            this.AutoRefreshBtn.Click += new System.EventHandler(this.AutoRefreshBtn_Click);
            // 
            // AutoRefreshStatus
            // 
            this.AutoRefreshStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AutoRefreshStatus.ForeColor = System.Drawing.Color.DimGray;
            this.AutoRefreshStatus.Name = "AutoRefreshStatus";
            this.AutoRefreshStatus.Size = new System.Drawing.Size(39, 22);
            this.AutoRefreshStatus.Text = "Status";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenuItem,
            this.HelpMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(592, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuMenuItem
            // 
            this.MenuMenuItem.Name = "MenuMenuItem";
            this.MenuMenuItem.Size = new System.Drawing.Size(50, 20);
            this.MenuMenuItem.Text = "Menu";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(149, 22);
            this.HelpAbout.Text = "About Twitchi";
            // 
            // TabWindow
            // 
            this.TabWindow.Controls.Add(this.LiveTab);
            this.TabWindow.Controls.Add(this.ChannelsTab);
            this.TabWindow.Location = new System.Drawing.Point(12, 27);
            this.TabWindow.Margin = new System.Windows.Forms.Padding(0);
            this.TabWindow.Name = "TabWindow";
            this.TabWindow.SelectedIndex = 0;
            this.TabWindow.Size = new System.Drawing.Size(568, 318);
            this.TabWindow.TabIndex = 3;
            // 
            // LiveTab
            // 
            this.LiveTab.Controls.Add(this.LiveDisplay);
            this.LiveTab.Location = new System.Drawing.Point(4, 22);
            this.LiveTab.Name = "LiveTab";
            this.LiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.LiveTab.Size = new System.Drawing.Size(560, 292);
            this.LiveTab.TabIndex = 0;
            this.LiveTab.Text = "Live";
            this.LiveTab.UseVisualStyleBackColor = true;
            // 
            // LiveDisplay
            // 
            this.LiveDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LiveDisplay.IsWebBrowserContextMenuEnabled = false;
            this.LiveDisplay.Location = new System.Drawing.Point(3, 3);
            this.LiveDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.LiveDisplay.Name = "LiveDisplay";
            this.LiveDisplay.Size = new System.Drawing.Size(554, 286);
            this.LiveDisplay.TabIndex = 0;
            // 
            // ChannelsTab
            // 
            this.ChannelsTab.Controls.Add(this.ChannelsToolStrip);
            this.ChannelsTab.Controls.Add(this.ChannelListBox);
            this.ChannelsTab.Location = new System.Drawing.Point(4, 22);
            this.ChannelsTab.Name = "ChannelsTab";
            this.ChannelsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChannelsTab.Size = new System.Drawing.Size(560, 292);
            this.ChannelsTab.TabIndex = 1;
            this.ChannelsTab.Text = "Channels";
            this.ChannelsTab.UseVisualStyleBackColor = true;
            // 
            // ChannelsToolStrip
            // 
            this.ChannelsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ChannelsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChannelBtn,
            this.toolStripSeparator4,
            this.RemoveBtn,
            this.toolStripSeparator5,
            this.SelectAllBtn,
            this.DeselectAllBtn});
            this.ChannelsToolStrip.Location = new System.Drawing.Point(3, 3);
            this.ChannelsToolStrip.Name = "ChannelsToolStrip";
            this.ChannelsToolStrip.Size = new System.Drawing.Size(554, 25);
            this.ChannelsToolStrip.TabIndex = 1;
            this.ChannelsToolStrip.Text = "toolStrip1";
            // 
            // AddChannelBtn
            // 
            this.AddChannelBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddChannelBtn.Image")));
            this.AddChannelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddChannelBtn.Name = "AddChannelBtn";
            this.AddChannelBtn.Size = new System.Drawing.Size(96, 22);
            this.AddChannelBtn.Text = "Add Channel";
            this.AddChannelBtn.Click += new System.EventHandler(this.AddChannelBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.Image")));
            this.RemoveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(117, 22);
            this.RemoveBtn.Text = "Remove Selected";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // SelectAllBtn
            // 
            this.SelectAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllBtn.Image")));
            this.SelectAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllBtn.Name = "SelectAllBtn";
            this.SelectAllBtn.Size = new System.Drawing.Size(75, 22);
            this.SelectAllBtn.Text = "Select All";
            this.SelectAllBtn.Click += new System.EventHandler(this.SelectAllBtn_Click);
            // 
            // DeselectAllBtn
            // 
            this.DeselectAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeselectAllBtn.Image")));
            this.DeselectAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeselectAllBtn.Name = "DeselectAllBtn";
            this.DeselectAllBtn.Size = new System.Drawing.Size(88, 22);
            this.DeselectAllBtn.Text = "Deselect All";
            this.DeselectAllBtn.Click += new System.EventHandler(this.DeselectAllBtn_Click);
            // 
            // ChannelListBox
            // 
            this.ChannelListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChannelListBox.FormattingEnabled = true;
            this.ChannelListBox.Location = new System.Drawing.Point(2, 28);
            this.ChannelListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ChannelListBox.Name = "ChannelListBox";
            this.ChannelListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ChannelListBox.Size = new System.Drawing.Size(555, 262);
            this.ChannelListBox.TabIndex = 0;
            // 
            // AutoRefreshTimer
            // 
            this.AutoRefreshTimer.Enabled = true;
            this.AutoRefreshTimer.Interval = 180000;
            this.AutoRefreshTimer.Tick += new System.EventHandler(this.AutoRefreshTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.TabWindow);
            this.Controls.Add(this.ControlToolstrip);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitchi";
            this.ControlToolstrip.ResumeLayout(false);
            this.ControlToolstrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabWindow.ResumeLayout(false);
            this.LiveTab.ResumeLayout(false);
            this.ChannelsTab.ResumeLayout(false);
            this.ChannelsTab.PerformLayout();
            this.ChannelsToolStrip.ResumeLayout(false);
            this.ChannelsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ControlToolstrip;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripButton AutoRefreshBtn;
        private System.Windows.Forms.ToolStripLabel AutoRefreshStatus;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.TabControl TabWindow;
        private System.Windows.Forms.TabPage LiveTab;
        private System.Windows.Forms.TabPage ChannelsTab;
        private System.Windows.Forms.WebBrowser LiveDisplay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListBox ChannelListBox;
        private System.Windows.Forms.ToolStrip ChannelsToolStrip;
        private System.Windows.Forms.ToolStripButton AddChannelBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton RemoveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton SelectAllBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DeselectAllBtn;
        private System.Windows.Forms.Timer AutoRefreshTimer;
    }
}

