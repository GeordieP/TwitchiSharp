using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace SharpTwitchi {
    public partial class MainWindow : Form {
        private const string styles = "<style type='text/css'>body { font-family: arial, sans-serif; font-size: 10pt }</style>";
        private const string htmlPre = "<html><head>" + styles + "</head><body>";
        private const string htmlPost = "</body></html>";
        private String[] followedChannels;

        public MainWindow() {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            //string htmlContent = "<p><b><a href='http://twitch.tv/azorae'>Azorae</a></b> is live playing <b>Half-Life 2</b><br />Half Life 2 ss Race Scriptless vs isolitic</p> <p><b><a href='http://twitch.tv/sullyjhf'>SullyJHF</a></b> is live playing <b>Half-Life 2</b><br />HL2•Speedruns</p>";
            //LiveDisplay.DocumentText = htmlPre + htmlContent + htmlPost;
            if (!File.Exists("following.txt")) File.Create("following.txt");
            followedChannels = File.ReadAllLines("following.txt");

            UpdateChannelList();
        }


        // this is to trigger the custom dialog
        private void button1_Click(object sender, EventArgs e) {
            using (AddUserDialog addDialog = new AddUserDialog()) {
                if (addDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    Console.WriteLine("Test: " + addDialog.GetUsername());
                }
            }
        }

        private void UpdateChannelList() {
            ChannelListBox.Items.AddRange(followedChannels);
        }

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

        private void RemoveBtn_Click(object sender, EventArgs e) {

        }

        private void AddChannelBtn_Click(object sender, EventArgs e) {

        }
    }
}