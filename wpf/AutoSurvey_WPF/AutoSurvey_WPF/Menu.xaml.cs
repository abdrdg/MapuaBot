using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MapuaSurveyBot;


namespace AutoSurvey_WPF
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        MapuaSurveyBot.bot user_bot;
        MainWindow login_form;
        bool isRead;

        public Menu(MainWindow login_form, MapuaSurveyBot.bot user_bot)
        {
            this.login_form = login_form;
            this.user_bot = user_bot;
            InitializeComponent();
            this.textBlock_Username.Text = "Welcome, " + user_bot.Get_Username();
            isRead = false;
        }

        private void buttonFaculty_Click(object sender, EventArgs e)
        {
            if (isRead)
            {

                button_FacEvaluation.Content = "Please wait...";
                button_FacEvaluation.IsEnabled = false;

                if (user_bot.AnswerFacultyAssessment())
                {
                    button_FacEvaluation.Content = "Faculty Assessment Survey Done!";
                }
                else
                {
                    button_FacEvaluation.Content = "No pending Faculty Assessment Survey";
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
                button_LabAssessment.Content = "Please wait...";
                button_LabAssessment.IsEnabled = false;

                if (user_bot.AnswerLabAssessment())
                {
                    button_LabAssessment.Content = "Laboratory Assessment Survey Done!";
                }
                else
                {
                    button_LabAssessment.Content = "No pending Laboratory Assessment Survey";
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
