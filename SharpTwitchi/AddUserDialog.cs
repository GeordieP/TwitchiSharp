using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpTwitchi {
    public partial class AddUserDialog : Form {
        public AddUserDialog() {
            InitializeComponent();
        }

        public string GetUsername() {
            if (UsernameTextbox.Text != "" && !UsernameTextbox.Text.Contains(" ")) {
                return UsernameTextbox.Text;
            } else {
                MessageBox.Show("Invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}