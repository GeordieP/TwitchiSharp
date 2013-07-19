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
        private const string styles = "<style type='text/css'>body { font-family: arial, sans-serif; font-size: 10pt }</style>";
        private const string htmlPre = "<html><head>" + styles + "</head><body>";
        private const string htmlPost = "</body></html>";

        private Notifier notifier;

        public MainWindow() {
            InitializeComponent();
            notifier = new Notifier();
            UpdateChannelList();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            //string htmlContent = "<p><b><a href='http://twitch.tv/azorae'>Azorae</a></b> is live playing <b>Half-Life 2</b><br />Half Life 2 ss Race Scriptless vs isolitic</p> <p><b><a href='http://twitch.tv/sullyjhf'>SullyJHF</a></b> is live playing <b>Half-Life 2</b><br />HL2•Speedruns</p>";
            //LiveDisplay.DocumentText = htmlPre + htmlContent + htmlPost;

            // Update channel list box every refresh
            UpdateChannelList();
        }

        // set the html of the webbrowser
        private void toolStripButton2_Click(object sender, EventArgs e) {
            string htmlContent = "<p>Nobody you follow is currently streaming.</p>";
            LiveDisplay.DocumentText = htmlPre + htmlContent + htmlPost;
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
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e) {
            List<String> selectedNames = new List<String>();
            foreach (Object selectedItem in ChannelListBox.SelectedItems) {
                selectedNames.Add(selectedItem.ToString());
            }

            notifier.RemoveUsers(selectedNames);
            UpdateChannelList();    // update channel list after names have been removed
        }


        // UI-Unrelated Methods
        private void UpdateChannelList() {
            ChannelListBox.Items.Clear();
            notifier.SyncFollowingList();     // sync the following list with file
            ChannelListBox.Items.AddRange(notifier.FollowedChannels.ToArray());     // Get the followed channels and toss them in the ListBox
        }
    }
}