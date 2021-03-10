using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Lógica de interacción para PresentationWindow.xaml
    /// </summary>
    public partial class PresentationWindow : Page
    {
        public PresentationWindow()
        {
            InitializeComponent();
        }

        private void GoToEmployeeForm(object sender, RoutedEventArgs e)
        {
            InsertEmployee insertEmployee = new InsertEmployee();
            this.NavigationService.Navigate(insertEmployee);
        }

        private void Button_Person_Click(object sender, RoutedEventArgs e)
        {
            FormInPerson formInPerson = new FormInPerson();
            this.NavigationService.Navigate(formInPerson);
        }

        private void Button_Products_Click(object sender, RoutedEventArgs e)
        {
            InsertProduct insertProducts = new InsertProduct();
            this.NavigationService.Navigate(insertProducts);
        }

        private void Button_Sales_Click(object sender, RoutedEventArgs e)
        {
            Sales sales = new Sales();
            this.NavigationService.Navigate(sales);
        }

        private void Button_Providers_Click(object sender, RoutedEventArgs e)
        {
            Purchase purchase = new Purchase();
            this.NavigationService.Navigate(purchase);
        }

        private void Button_Clients_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            this.NavigationService.Navigate(clients);
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }

        private void Button_ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
