using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass1 = passBox1.Password.Trim();
            string pass2 = passBox2.Password.Trim();
            string email = textBoxEmail.Text.ToLower().Trim();
            bool allCorrect = true;
            NormalView();


            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Login too short";
                textBoxLogin.Background = Brushes.IndianRed;
                allCorrect = false;
            }

            if (pass1.Length < 5)
            {
                passBox1.ToolTip = "Pass too short";
                passBox1.Background = Brushes.IndianRed;
                allCorrect = false;
            }

            if (pass1 != pass2)
            {
                passBox2.ToolTip = "Password mismatch";
                passBox2.Background = Brushes.IndianRed;
                allCorrect = false;
            }

            if (!IsValidEmail(email))
            {
                textBoxEmail.ToolTip = "Incorrect email";
                textBoxEmail.Background = Brushes.IndianRed;
                allCorrect = false;
            }



            if (allCorrect)
            {



            }
        }

        private void NormalView()
        {
            textBoxLogin.ToolTip = "";
            textBoxLogin.Background = Brushes.Transparent;
            passBox1.ToolTip = "";
            passBox1.Background = Brushes.Transparent;
            passBox2.ToolTip = "";
            passBox2.Background = Brushes.Transparent;
            textBoxEmail.ToolTip = "";
            textBoxEmail.Background = Brushes.Transparent;
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
