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
        public Menu(LoginForm login_form, MapuaSurveyBot.bot user_bot)
        {
            this.login_form = login_form;
            this.user_bot = user_bot;
            InitializeComponent();
            labelName.Text = "Welcome, " + user_bot.Get_Username();
        }

        private void buttonFaculty_Click(object sender, EventArgs e)
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

        private void buttonLab_Click(object sender, EventArgs e)
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form.Close();
            user_bot.Close();
        }
    }
}
