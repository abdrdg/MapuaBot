﻿using System;
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
            buttonLab.Enabled = false;
            buttonLab.Text = "Please wait...";
        }

        private void buttonStud_Click(object sender, EventArgs e)
        {
            buttonStud.Enabled = false;
            buttonStud.Text = "Please wait...";
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_form.Close();
            user_bot.Close();
        }
    }
}
