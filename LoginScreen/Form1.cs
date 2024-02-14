using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string username;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text;

            outputLabel.Text = $"Welcome {username}";
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = $"Welcome Admin {username}";
        }
    }
}
