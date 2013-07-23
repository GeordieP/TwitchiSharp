using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpTwitchi {
    public partial class MainWindow : Form {
        private const string styles = "<style type='text/css'>body { font-family: arial, sans-serif; font-size: 9pt }</style>";
        private const string htmlPre = "<html><head>" + styles + "</head><body>";
        private const string htmlPost = "</body></html>";

        private Notifier notifier;

        public MainWindow() {
            InitializeComponent();
            notifier = new Notifier();
            UpdateChannelList();
            UpdateAutoRefreshStatusLabel();
            UpdateLiveDisplay();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            UpdateLiveDisplay();
        }

        private void SelectAllBtn_Click(object sender, EventArgs e) {
            for (int i = 0; i < ChannelListBox.Items.Count; i++) {
                ChannelListBox.SetSelected(i, true);
            }
        }
        private void DeselectAllBtn_Click(object sender, EventArgs e) {
            for (int i = 0; i < ChannelListBox.Items.Count; i++) {
                ChannelListBox.SetSelected(i, false);
            }
        }

        private void AddChannelBtn_Click(object sender, EventArgs e) {
            using (AddUserDialog addDialog = new AddUserDialog()) {
                if (addDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    notifier.AddUser(addDialog.GetUsername());
                    UpdateChannelList();
                    UpdateLiveDisplay();
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e) {
            List<String> selectedNames = new List<String>();
            foreach (Object selectedItem in ChannelListBox.SelectedItems) {
                selectedNames.Add(selectedItem.ToString());
            }

            notifier.RemoveUsers(selectedNames);
            UpdateChannelList();
            UpdateLiveDisplay();
        }

        private void AutoRefreshTimer_Tick(object sender, EventArgs e) {
            UpdateLiveDisplay();
        }

        private void AutoRefreshBtn_Click(object sender, EventArgs e) {
            AutoRefreshTimer.Enabled = !AutoRefreshTimer.Enabled;
            UpdateAutoRefreshStatusLabel();
        }

        // UI-Unrelated Methods
        private void UpdateChannelList() {
            ChannelListBox.Items.Clear();
            notifier.SyncFollowingList();     // sync the following list with file
            ChannelListBox.Items.AddRange(notifier.FollowedChannels.ToArray());     // Get the followed channels and toss them in the ListBox
        }

        private void UpdateAutoRefreshStatusLabel() {
            if (AutoRefreshTimer.Enabled) {
                AutoRefreshStatus.ForeColor = Color.LimeGreen;
                AutoRefreshStatus.Text = "Enabled";
            } else {
                AutoRefreshStatus.ForeColor = Color.Red;
                AutoRefreshStatus.Text = "Disabled";
            }
        }

        private void UpdateLiveDisplay() {
            LiveDisplay.DocumentText = htmlPre + notifier.BuildDisplayPage() + htmlPost;
        }
    }
}