using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace SharpTwitchi {
    public class Notifier {

        private List<String> followedChannels;

        // Use a property for access from other classes, but don't worry about it in this class
        public List<String> FollowedChannels {
            get { return followedChannels; }
            set { followedChannels = value; }
        }

        public Notifier() {
            if (!File.Exists("following.txt")) File.Create("following.txt");
            SyncFollowingList();
        }

        public void AddUser(String enteredString) {
            String[] usernames = enteredString.Split(' ');

            foreach (String s in usernames) {
                if (s != "") {
                    followedChannels.Add(s);
                }
            }

            UpdateFile();
        }

        public void RemoveUsers(List<String> usernames) {
            for (int i = followedChannels.Count()-1; i >= 0; i--) {      // TODO: problem with this - won't remove last name because count-1 is 0 so loop doesn't start
                if (usernames.Contains(followedChannels[i])){
                    followedChannels.RemoveAt(i);
                }
            }

            UpdateFile();
        }

        // Sync following list with file
        public void SyncFollowingList() {
            followedChannels = File.ReadAllLines("following.txt").ToList();
        }

        public void UpdateFile() {
            File.WriteAllLines("following.txt", FollowedChannels.ToArray());
        }

        public List<string> currentlyLiveUsers = new List<string>();

        Popup popup;

        public string BuildDisplayPage() {
            string baseUrl = "http://api.justin.tv/api/stream/list.json?channel=";
            string receivedText;
            WebClient wc = new WebClient();
            JArray json;
            string liveDisplayText = "";
            string popupDisplayText = "";

            foreach (String username in followedChannels) {
                receivedText = wc.DownloadString(baseUrl + username);
                if (receivedText.Length > 2) {      // only parse the json if user is live
                    json = JArray.Parse(receivedText);

                    liveDisplayText += String.Format("<p><b><a href='javascript:window.open(\"http://www.twitch.tv/{0}/popout\",\"{0}\",\"menubar=yes,width=854,height=480,toolbar=yes\");window.focus();'>{0}</a></b> is live playing <b>{1}</b><br />{2}</p>", username, json[0]["channel"]["meta_game"], json[0]["channel"]["status"]);

                    if (!currentlyLiveUsers.Contains(username)) {       // If the current username isn't in the currently live list - meaning we haven't yet shown them on a popup window
                        currentlyLiveUsers.Add(username);
                        popupDisplayText += String.Format("<p><b><a href='javascript:window.open(\"http://www.twitch.tv/{0}/popout\",\"{0}\",\"menubar=no,width=854,height=480,toolbar=no\");window.focus();'>{0}</a></b> is live playing <b>{1}</b></p>", username, json[0]["channel"]["meta_game"]);
                    }
                } else if (currentlyLiveUsers.Contains(username)) {     // if username we're checking is offline, check if they're in currently live list
                    // If current username is in currentlyLive, remove them because they're no longer live
                    currentlyLiveUsers.Remove(username);
                }
            }

            // Show popup window if someone is live (if text isn't empty)
            if (popupDisplayText != "") {
                popup = new Popup(popupDisplayText);
                popup.Show();
            }

            if (liveDisplayText == "") liveDisplayText = "<p>Nobody you follow is currently live.</p>";

            return liveDisplayText;
        }
    }
}
