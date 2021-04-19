using System;
using System.Windows;
using System.Windows.Controls;

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
            

            try
            {
                String message ="Pinte el blackswan";
                /*
                employee.Id_Personal = textBox_Id_Personal.Text;
                employee.LastName = textBox_LastName.Text;
                employee.FirstName = textBox_FirstName.Text;
                employee.Gender = gender;
                employee.PAddress = textBox_PAddress.Text;
                employee.DateOfBirth = datePicker_DateOfBirth.SelectedDate.Value;
                employee.Id_Employee = GenerateUserName(textBox_FirstName.Text, textBox_LastName.Text);
                employee.SystemInDate = DateTime.Now;
                */
                textBlock_Message.Text = message;
                popup.IsOpen = true;
                //message = employee.RegisterEmployee();

                //textBlock_Id_Employee_show.Text = employee.Id_Employee;
                
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

        private String GenerateUserName(String _Name, String _LastName)
        {

            Random rnd = new Random();
            int randomNumber = rnd.Next(2000);
            String randomNumberText = randomNumber.ToString();
            String generatedIdEmployee = "";
            String FirstName = _Name.Substring(0, 3);
            String LastName = _LastName.Substring(0, 3);
            generatedIdEmployee = FirstName + LastName + randomNumberText;

            return generatedIdEmployee;
        }
    }
}
