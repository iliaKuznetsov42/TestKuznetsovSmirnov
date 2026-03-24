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
    /// Логика взаимодействия для MainPAge.xaml
    /// </summary>
    public partial class MainPAge : Page
    {
        public MainPAge()
        {
            InitializeComponent();
        }

        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new AuthorizationPage());
        }

        private void StudentBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new RegistrationStudentPage());
        }
    }
}
