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
    /// Логика взаимодействия для RegistrationStudentPage.xaml
    /// </summary>
    public partial class RegistrationStudentPage : Page
    {
        public RegistrationStudentPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.group.ToList();
            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();
            TestCmb.SelectedValuePath = "ID";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Test.ToList();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TestCmb.Text) && string.IsNullOrEmpty(StudentCmb.Text) && string.IsNullOrEmpty(GroupCmb.Text))
            {
                MessageBox.Show("Заполнить все поля");
            }

            else if (TestCmb.Text == "Общие основы функцианирования субъектов хозяйствования")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test1Page());
            }

            else if (TestCmb.Text == "Сущности и структура основного капитала и оборотных средств предприятия")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test2Page());
            }

            else if (TestCmb.Text == "Формы и системы оплаты труда")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test3Page());
            }

            else if (TestCmb.Text == "Результаты коммерческой деятельности")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test4Page());
            }

            ClassVariable.classman = Convert.ToInt32(StudentCmb.SelectedValue);
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.context.Student.Where(s => s.idGroup == selectedGroup).ToList();
        }
    }
}
