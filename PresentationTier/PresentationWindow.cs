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

        private void PresentationButton_Person_Click(object sender, RoutedEventArgs e)
        {
            FormInPerson formInPerson = new FormInPerson();
            this.NavigationService.Navigate(formInPerson);
        }

        private void PresentationButton_Products_Click(object sender, RoutedEventArgs e)
        {
            Products products = new Products();
            this.NavigationService.Navigate(products);
        }

        private void PresentationButton_Sales_Click(object sender, RoutedEventArgs e)
        {
            Sales sales = new Sales();
            this.NavigationService.Navigate(sales);
        }

        private void PresentationButton_Providers_Click(object sender, RoutedEventArgs e)
        {
            Purchase purchase = new Purchase();
            this.NavigationService.Navigate(purchase);
        }

        private void PresentationButton_Clients_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            this.NavigationService.Navigate(clients);
        }

        private void Button_Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }

        private void Button_Change_User_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.NavigationService.Navigate(login);
        }
    }
}
