using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        // need a method that checks each user status and returns a string of html to put in the browser


        // first check if user is live before getting and parsing json

        //string htmlContent = "<p><b><a href='http://twitch.tv/azorae'>Azorae</a></b> is live playing <b>Half-Life 2</b><br />Half Life 2 ss Race Scriptless vs isolitic</p> <p><b><a href='http://twitch.tv/sullyjhf'>SullyJHF</a></b> is live playing <b>Half-Life 2</b><br />HL2•Speedruns</p>";

        public string TempName() {
            string baseUrl = "http://api.justin.tv/api/stream/list.json?channel=";
            string receivedText;
            WebClient wc = new WebClient();
            JArray json;
            string returnText = "";

            foreach (String username in followedChannels) {
                receivedText = wc.DownloadString(baseUrl + username);
                if (receivedText.Length > 2) {      // only parse the json if user is live
                    json = JArray.Parse(receivedText);
                    // title, meta_game, status = username, game, stream title
                    returnText += String.Format("<p><b><a href='javascript:window.open(\"http://www.twitch.tv/{0}/popout\",\"{0}\",\"menubar=no,width=854,height=480,toolbar=no\");window.focus();'>{0}</a></b> is live playing <b>{1}</b><br />{2}</p>", username, json[0]["channel"]["meta_game"], json[0]["channel"]["status"]);
                }
            }

            if (returnText == "") returnText = "<p>Nobody you follow is currently live.</p>";
            return returnText;
        }

        public void GetJson() {
            string url = "http://api.justin.tv/api/stream/list.json?channel=ludendi";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);
            string test = objReader.ReadToEnd();

            JArray a = JArray.Parse(test);

            Console.WriteLine("Title: " + a[0]["channel"]["title"]);
        }

        public void TestingSomething() {
            WebClient wc = new WebClient();
            string temp = wc.DownloadString("http://api.justin.tv/api/stream/list.json?channel=ludendi");
            Console.WriteLine("ESA: " + temp.Length);
            temp = wc.DownloadString("http://api.justin.tv/api/stream/list.json?channel=enjoi0");
            Console.WriteLine("Me: " + temp.Length);
        }
    }
}
