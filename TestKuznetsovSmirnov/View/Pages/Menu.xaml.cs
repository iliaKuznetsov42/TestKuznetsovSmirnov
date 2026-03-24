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
using TestKuznetsovSmirnov.Class;

namespace TestKuznetsovSmirnov.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new AddStudent());
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new AddGroup());
        }

        private void StudentListBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new ListStudent());
        }

        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new DeleteStudent());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new MainPAge());
        }
    }
}
