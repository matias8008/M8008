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
    /// Lógica de interacción para InsertEmployee.xaml
    /// </summary>
    public partial class InsertEmployee : Page
    {
        Employee employee = new Employee();
       
        //Gender check
        Char gender;

        public InsertEmployee()
        {
            InitializeComponent();
        }

        //Functions action in Form
        private void TextBox_Id_Personal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_LastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Male_Checked(object sender, RoutedEventArgs e)
        {
            gender = 'M';
        }

        private void RadioButton_Female_Checked(object sender, RoutedEventArgs e)
        {
            gender = 'F';
        }

        private void RadioButton_Other_Checked(object sender, RoutedEventArgs e)
        {
            gender = 'O';
        }

        private void TextBox_Id_Employee_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_InsertData_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(2000);
            String randomNumberText = randomNumber.ToString();
            String message;
            String generatedIdEmployee = "";
            String FirstName = textBox_FirstName.Text.Substring(0, 3);
            String LastName = textBox_LastName.Text.Substring(0, 3);
            generatedIdEmployee = FirstName + LastName + randomNumberText ;

            try
            {
                employee.Id_Personal = textBox_Id_Personal.Text;
                employee.LastName = textBox_LastName.Text;
                employee.FirstName = textBox_FirstName.Text;
                employee.Gender = gender;
                employee.PAddress = textBox_PAddress.Text;
                employee.DateOfBirth = datePicker_DateOfBirth.SelectedDate.Value;
                employee.Id_Employee = generatedIdEmployee;
                employee.SystemInDate = DateTime.Now;
                message = employee.RegisterEmployee();

                //textBlock_Id_Employee_show.Text = employee.Id_Employee;
                textBlock_Message.Text = message;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void Button_PersonList_Click(object sender, RoutedEventArgs e)
        {
            PresentData presentData = new PresentData(employee);
            this.NavigationService.Navigate(presentData);
        }
        /*
        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            String newQuery = textBox_Search.Text;
            PresentData presentData = new PresentData(newQuery);
            this.NavigationService.Navigate(presentData);

        }
        */
        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PresentationWindow presentationWindow = new PresentationWindow();
            this.NavigationService.Navigate(presentationWindow);
        }

        private void TextBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void textBox_PAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
