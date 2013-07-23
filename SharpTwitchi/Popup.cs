using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace SharpTwitchi {
    public partial class Popup : Form {

        private enum WindowPosition {
            TopLeft, TopRight, BottomLeft, BottomRight
        }

        private const string styles = "<style type='text/css'>* { padding: 0; margin: 0; } body { background: #000000; color: #ffffff; font-family: arial, sans-serif; font-size: 8pt; padding: 3px;} a { color: dodgerblue; }</style>";
        private const string htmlPre = "<html><head>" + styles + "</head><body>";
        private const string htmlPost = "</body></html>";

        private WindowPosition winPos = WindowPosition.TopLeft;
        private int screenPadding = 30;
 
        public Popup(string htmlContent) {
            InitializeComponent();

            Console.WriteLine("Popup created");

            // Move the window
            switch (winPos) {
                case WindowPosition.TopLeft:
                    this.Left = screenPadding;
                    this.Top = screenPadding;
                    break;
                case WindowPosition.TopRight:
                    this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (this.Width + screenPadding);
                    this.Top = screenPadding;
                    break;
                case WindowPosition.BottomLeft:
                    this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (this.Height + screenPadding);
                    this.Left = screenPadding;
                    break;
                case WindowPosition.BottomRight:
                    this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - (this.Height + screenPadding);
                    this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - (this.Width + screenPadding);
                    break;
                default:
                    this.Left = screenPadding;
                    this.Top = screenPadding;
                    break;
            }
            
            // Set the text of the popup window to display the live statuses
            LiveDisplay.DocumentText = htmlPre + htmlContent + htmlPost;

        }

        private void CloseWindow(object sender, EventArgs e) {
            Console.WriteLine(this.RectangleToScreen(this.DisplayRectangle));
            Console.WriteLine("display rect: " + this.DisplayRectangle);
            this.Close();
        }

        private void Popup_Load(object sender, EventArgs e) {
            CloseTimer.Enabled = true;
            Console.WriteLine("test");
            (new SoundPlayer("popup.wav")).Play();
        }


        private void CursorCheckTimer_Tick(object sender, EventArgs e) {
            if (this.RectangleToScreen(this.DisplayRectangle).Contains(Cursor.Position)) {
                this.Opacity = 1.0;
                this.CloseTimer.Enabled = false;
            } else {
                this.Opacity = 0.7;
                this.CloseTimer.Enabled = true;
            }
        }
    }
}