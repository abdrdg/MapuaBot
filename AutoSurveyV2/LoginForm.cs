using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapuaSurveyBot;

namespace AutoSurveyV2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Text = "Logging in... Please wait!";
            buttonStart.Enabled = false;
            MapuaSurveyBot.bot bot = new MapuaSurveyBot.bot(textBoxMyMail.Text, textBoxPassword.Text, !checkBoxHeadless.Checked);
            if (bot.Login())
            {
                buttonStart.Text = "Logged in!";
                this.Hide();

                Menu menu = new Menu(this, bot);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login. Please try again.");
                bot.Close();
                buttonStart.Text = "Log in";
                buttonStart.Enabled = true;
            }
            textBoxMyMail.Clear();
            textBoxPassword.Clear();
        }
    }
}
