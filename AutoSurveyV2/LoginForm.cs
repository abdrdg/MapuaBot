using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapuaSurveyBot;

namespace AutoSurveyV2
{
    public partial class LoginForm : Form
    {
        MapuaSurveyBot.bot bot;
        Thread progress;

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
            progress = new Thread(login_progress);
            
            buttonStart.Text = "Logging in... Please wait!";
            buttonStart.Enabled = false;
            bot = new MapuaSurveyBot.bot(textBoxMyMail.Text, textBoxPassword.Text, !checkBoxHeadless.Checked);

            progress.Start();
            if (bot.Login())
            {
                buttonStart.Text = "Logged in!";
                Menu menu = new Menu(this, bot);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login. Please try again.");
                bot.Close();
                buttonStart.Text = "LOG IN";
                buttonStart.Enabled = true;
            }
            textBoxMyMail.Clear();
            textBoxPassword.Clear();

            progress.Abort();
        }


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Libre niyo ko milktea. >:(");
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void login_progress()
        {
            do
            {
                label_progress.Text = ((bot.progress) * 100).ToString();
                Console.WriteLine(((bot.progress) * 100).ToString());
            } while (bot.progress < 1);
        }
    }
}
