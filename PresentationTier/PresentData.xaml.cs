using LogicTier;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace PresentationTier
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class PresentData : Page
    {
        Persons persons = new Persons();
        Employee employee = new Employee();
        Products products = new Products();

        public PresentData(Persons persons)
        {
            InitializeComponent();
            ShowInfoPersons();
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        public PresentData(Employee employee)
        {
            InitializeComponent();
            ShowInfoEmployee();
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        public PresentData(Products products)
        {
            InitializeComponent();
            ShowInfoProducts();
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        public PresentData(String newQuery)
        {
            InitializeComponent();
            ShowSearchEmployee(newQuery);
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        private void ShowInfoPersons()
        {
            DataTable dataTable = persons.Persons_list();
            dataGrid_showInfo.DataContext = dataTable.DefaultView;
            textBox_Test.Text = "Updated on date: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

        }

        private void ShowInfoEmployee()
        {
            DataTable dataTable = employee.Employee_list();
            dataGrid_showInfo.DataContext = dataTable.DefaultView;
            textBox_Test.Text = "Updated on date: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void ShowInfoProducts()
        {
            DataTable dataTable = products.Product_list();
            dataGrid_showInfo.DataContext = dataTable.DefaultView;
            textBox_Test.Text = "Updated on date: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void ShowSearchEmployee(String newQuery)
        {
            DataTable dataTable = employee.Search_Employee(newQuery);
            dataGrid_showInfo.DataContext = dataTable.DefaultView;
            textBox_Test.Text = "Updated on date" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }


        private void Button_Modify_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
