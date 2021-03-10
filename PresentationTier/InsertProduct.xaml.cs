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


namespace PresentationTier
{
    /// <summary>
    /// Lógica de interacción para InsertProduct.xaml
    /// </summary>
    public partial class InsertProduct : Page
    {
        Products products = new Products();
        ComboBoxItem comboBoxItem = new ComboBoxItem();
        
        
        public InsertProduct()
        {
            InitializeComponent();


            _1.Content = "1 - Drinks";
            _2.Content = "2 - Industrial food";
            _3.Content = "3 - Fresh food";
            _4.Content = "4 - Home & Garden";
        }

        private void ProductCodeTextBox__TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ProductNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CategorieComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void DimentionsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SuplierTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StockTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SellPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BuyPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonInsertProduct_Click(object sender, RoutedEventArgs e)
        {
            String message;

            try
            {
                products.ProductCode = ProductCodeTextBox.Text;
                products.ProductName = ProductNameTextBox.Text;
               
                if (CategorieComboBox.SelectedItem == _1)
                    products.Categorie = 1;
                if (CategorieComboBox.SelectedItem == _2)
                    products.Categorie = 2;
                if (CategorieComboBox.SelectedItem == _3)
                    products.Categorie = 3;
                if (CategorieComboBox.SelectedItem == _4)
                    products.Categorie = 4;

                products.Dimentions = DimentionsTextBox.Text;
                products.ProductProvider = ProductProviderTextBox.Text;
                products.ProductDescription = DescriptionTextBox.Text;

                //To avoid DDBB exceptions
                int number1 = 0;
                bool canConvert = int.TryParse(StockTextBox.Text, out number1);
                if (canConvert == true)
                    products.Stock = int.Parse(StockTextBox.Text);
                else
                    textBlock_Stock_alert.Text="Only integer numbers";

                Double number2 = 0.0;
                bool canConvert2 = Double.TryParse(SalePriceTextBox.Text, out number2);
                if (canConvert == true)
                    products.SalePrice = Double.Parse(SalePriceTextBox.Text);
                else
                    textBlock_Stock_alert.Text = "Only numbers";

                bool canConvert3 = Double.TryParse(SalePriceTextBox.Text, out number2);
                if (canConvert == true)
                    products.BuyPrice = Double.Parse(BuyPriceTextBox.Text);
                else
                    textBlock_Stock_alert.Text = "Only numbers";
                products.BuyPrice = Double.Parse(BuyPriceTextBox.Text);

                //Calling Procedure DDBB Register_Products
                message = products.RegisterProducts();

                messageTextBlock.Text = message;

                if (message == "Product stored")
                {
                    buttonInsertProduct.IsEnabled = false;
                }
               
                
            }

            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void Button_Show_List_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow(products);
            //mainWindow.dataGrid_showInfo();

        }
        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PresentationWindow presentationWindow = new PresentationWindow();
            this.NavigationService.Navigate(presentationWindow);
        }
    }
}
