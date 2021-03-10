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
using LogicTier;

namespace PresentationTier
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        UserLogicTier userLogicTier = new UserLogicTier();

        public Login() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String userName = userTextBox.Text;
                String password = passwordBox.Password.ToString();


                string message;
                if (userName != "" && password != "")
                {
                    message = userLogicTier.AuthenticateUser(userName, password);

                    if (message.Equals("Authentification correct"))
                    {
                        PresentationWindow presentationWindow = new PresentationWindow();
                        this.NavigationService.Navigate(presentationWindow);
                        Response.Text = message;
                    }
                    else
                    {
                        Response.Text = message;
                    }
                }
                else if (userName == "" && password != "")
                {
                    message = "User name is empty";
                    Response.Text = message;
                }
                else if (userName != "" && password == "")
                {
                    message = "Password is empty";
                    Response.Text = message;
                }
                else
                {
                    message = "User name and Password are empty";
                    Response.Text = message;
                }


            }
            catch (Exception a)
            {
                throw a;
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordChangedHandler(Object sender, RoutedEventArgs args)
        {

        }


    }
}
