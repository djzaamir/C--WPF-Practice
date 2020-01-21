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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<EducationTitles> education_titles = new List<EducationTitles>();

            education_titles.Add(new EducationTitles("Computer Science"));
            education_titles.Add(new EducationTitles("English"));
            education_titles.Add(new EducationTitles("Ecnomics"));

            education_title_comboBox.ItemsSource = education_titles;
            education_title_comboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            string full_name = fullName_textbox.Text;
            string email = email_textbox.Text;
            string education_title  =  ((EducationTitles)education_title_comboBox.SelectedItem).title;

            if (full_name.Length == 0 || email.Length == 0)
            {
                MessageBox.Show($"No Name or Email Provided", "kia Yaar ?", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Welcome {full_name}\nEmail : \n{email}\nBacelors : {education_title}", "Mubarik Ho, Mubarik Ho", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
