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
using LogicTier;
using System.Data;

namespace PresentationTier
{
    
    /// <summary>
    /// Lógica de interacción para Clients.xaml
    /// </summary>
    public partial class Clients : Page
    {
        ClientsLogicTier clientsLogicTier = new ClientsLogicTier();
        //String clientCode;

        public Clients()
        {
            InitializeComponent();
          
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Show_List_Click(object sender, RoutedEventArgs e)
        {
            //PresentData presentData = new PresentData(clientsLogicTier);
            //this.NavigationService.Navigate(presentData);
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PresentationWindow presentationWindow = new PresentationWindow();
            this.NavigationService.Navigate(presentationWindow);

        }
    }
}
