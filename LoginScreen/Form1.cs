using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string userName;
        int pin;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Red;
            adminButton.BackColor = Color.Gray;

            try
            {
                userName = usernameInput.Text;
                pin = Convert.ToInt32(pinInput.Text);

                outputLabel.Text = $"{userName} {pin}";
            }
            catch
            {
                pinInput.Text = "Numbers Only";
                pinInput.Focus();
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Gray;
            adminButton.BackColor = Color.Red;
            outputLabel.Text = $"{pin} {userName} ";
        }
    }
}
