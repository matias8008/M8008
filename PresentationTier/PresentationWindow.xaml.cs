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

namespace PresentationTier
{
    /// <summary>
    /// Lógica de interacción para PresentationWindow.xaml
    /// </summary>
    public partial class PresentationWindow : Window
    {
        public PresentationWindow()
        {
            InitializeComponent();
        }

        private void PresentationButton_Employee_Click(object sender, RoutedEventArgs e)
        {
            InsertEmployee insertEmployee = new InsertEmployee();
            insertEmployee.ShowDialog();
            this.Close();
        }

        private void PresentationButton_Person_Click(object sender, RoutedEventArgs e)
        {
            FormInPerson formInPerson = new FormInPerson();
            formInPerson.ShowDialog();
            this.Close();
        }

        private void PresentationButton_Products_Click(object sender, RoutedEventArgs e)
        {
            InsertProduct insertProduct = new InsertProduct();
            insertProduct.ShowDialog();
            this.Close();
        }

        private void PresentationButton_Orders_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PresentationButton_Providers_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PresentationButton_Clients_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            clients.ShowDialog();
            Close();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Change_User_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
    }
}
