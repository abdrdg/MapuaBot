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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MapuaSurveyBot;

namespace AutoSurvey_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MapuaSurveyBot.bot bot;
        public Task botTask;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            

            button_Login.Content = "Logging in... Please wait!";
            button_Login.IsEnabled = false;
            bot = new MapuaSurveyBot.bot(textbox_Mail.Text, passswordBox_Password.Password, !(bool)checkBox_ShowBrowser.IsChecked);

            if (bot.Login())
            {
                button_Login.Content = "Logged in!";
                Menu menu = new Menu(this, bot);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login. Please try again.");
                bot.Close();
                button_Login.Content = "LOG IN";
                button_Login.IsEnabled = true;
            }
            textbox_Mail.Clear();
            passswordBox_Password.Clear();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Libre niyo ko milktea. >:(");
        }

    }
}
