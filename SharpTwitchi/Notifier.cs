using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SharpTwitchi {
    public class Notifier {

        private List<String> followedChannels;

        // Use a property for access from other classes, but don't worry about it in this class
        public List<String> FollowedChannels {
            get {
                return followedChannels;
            }
            set {
                followedChannels = value;
            }
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

            //if (enteredString != "") {
            //    followedChannels.Add(enteredString);
            //    UpdateFile();
            //}

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
    }
}
