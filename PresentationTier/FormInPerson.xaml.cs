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
    /// Lógica de interacción para FormInPerson.xaml
    /// </summary>
    public partial class FormInPerson : Page
    {

        Persons persons = new Persons();
        //Gender check
        Char gender;
        public FormInPerson()
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

        private void textbox_address(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_InsertData_Click(object sender, RoutedEventArgs e)
        {
            String message; 
            
            try
            {
                persons.Id_Personal = textBox_Id_Personal.Text;
                persons.LastName = textBox_LastName.Text;
                persons.FirstName = textBox_FirstName.Text;
                persons.Gender = gender;
                persons.PAddress = textBox_PAddress.Text;
                persons.DateOfBirth = datePicker_DateOfBirth.SelectedDate.Value;
                
                message = persons.RegisterPersons();

                textBlock_Message.Text = message;
            }
            catch (Exception exception)
            {
                
                textBlock_Message.Text = "Under construccion :(";
                throw exception;
            }
        }

        private void Button_PersonList_Click(object sender, RoutedEventArgs e)
        {
            PresentData presentData = new PresentData(persons);
            this.NavigationService.Navigate(presentData);
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            PresentationWindow presentationWindow = new PresentationWindow();
            this.NavigationService.Navigate(presentationWindow);
        }


    }
}
