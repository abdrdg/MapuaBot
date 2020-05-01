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
    public partial class Menu : Form
    {
        MapuaSurveyBot.bot user_bot;
        LoginForm login_form;
        bool isRead;
        public Menu(LoginForm login_form, MapuaSurveyBot.bot user_bot)
        {
            this.login_form = login_form;
            this.user_bot = user_bot;
            InitializeComponent();
            labelName.Text = "Welcome, " + user_bot.Get_Username();
            isRead = false;
        }

        private void buttonFaculty_Click(object sender, EventArgs e)
        {
            if (isRead)
            {

                buttonFaculty.Text = "Please wait...";
                buttonFaculty.Enabled = false;

                if (user_bot.AnswerFacultyAssessment())
                {
                    buttonFaculty.Text = "Faculty Assessment Survey Done!";
                }
                else
                {
                    buttonFaculty.Text = "No pending Faculty Assessment Survey";
                }
            }
            else
            {
                MessageBox.Show("Please read the 'README' first at the upper right.");
            }

        }

        private void buttonLab_Click(object sender, EventArgs e)
        {
            if (isRead)
            {
                buttonLab.Text = "Please wait...";
                buttonLab.Enabled = false;

                if (user_bot.AnswerLabAssessment())
                {
                    buttonLab.Text = "Laboratory Assessment Survey Done!";
                }
                else
                {
                    buttonLab.Text = "No pending Laboratory Assessment Survey";
                }
            }
            else
            {
                MessageBox.Show("Please read the 'README' first at the upper right.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form.Close();
            user_bot.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Automatic perfect score ang ilalagay neto sa mga survey. \nSo sagutan niyo muna manually yung gusto niyong bigyan ng hindi perfect score tas balik nalang kayo dito. \nUse this responsibly, wag tamad hehe.");
            isRead = true;
        }
    }
}
