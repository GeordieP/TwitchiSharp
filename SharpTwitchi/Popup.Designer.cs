namespace SharpTwitchi {
    partial class Popup {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.LiveDisplay = new System.Windows.Forms.WebBrowser();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.CursorCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LiveDisplay
            // 
            this.LiveDisplay.IsWebBrowserContextMenuEnabled = false;
            this.LiveDisplay.Location = new System.Drawing.Point(2, 2);
            this.LiveDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.LiveDisplay.Name = "LiveDisplay";
            this.LiveDisplay.ScrollBarsEnabled = false;
            this.LiveDisplay.Size = new System.Drawing.Size(252, 92);
            this.LiveDisplay.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Black;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(210, 72);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(44, 22);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseWindow);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 5000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseWindow);
            // 
            // CursorCheckTimer
            // 
            this.CursorCheckTimer.Enabled = true;
            this.CursorCheckTimer.Interval = 200;
            this.CursorCheckTimer.Tick += new System.EventHandler(this.CursorCheckTimer_Tick);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(256, 96);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LiveDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Popup";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Popup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser LiveDisplay;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Timer CursorCheckTimer;
    }
}