using LogicTier;
using System;
using System.Data;
using System.Windows;

namespace PresentationTier
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Persons persons = new Persons();
        Employee employee = new Employee();
        Products products = new Products();
        
        public MainWindow(Persons persons)
        {
            InitializeComponent();
            ShowInfoPersons();
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        public MainWindow(Employee employee)
        {
            InitializeComponent();
            ShowInfoEmployee();
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        public MainWindow(Products products)
        {
            InitializeComponent();
            ShowInfoProducts();
            button_Modify.IsEnabled = false;
            button_Delete.IsEnabled = false;

        }

        public MainWindow(String newQuery)
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

        private void DataGrid_showInfo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            button_Modify.IsEnabled = true;
            button_Delete.IsEnabled = true;
            dataGrid_showInfo.SelectedCellsChanged += DataGrid_showInfo_SelectedCellsChanged;
            
        }

        Object selectedCell;

        private void DataGrid_showInfo_SelectedCellsChanged(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            
            selectedCell = sender;
            throw new NotImplementedException();
        }

        private void Button_Modify_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(selectedCell);
            String Nombre = dataGrid_showInfo.CurrentCell.ToString();     
            Console.WriteLine(Nombre);
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
