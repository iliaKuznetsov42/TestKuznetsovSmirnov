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
using TestKuznetsovSmirnov.Model;

namespace TestKuznetsovSmirnov.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListStudent.xaml
    /// </summary>
    public partial class ListStudent : Page
    {
        public ListStudent()
        {
            InitializeComponent();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            group Group = GroupCmb.SelectedItem as group;
            if (GroupCmb.SelectedIndex == 0)
            {
                ListStudentDg.ItemsSource = App.context.Student.ToList();
            }
            else
            {
                ListStudentDg.ItemsSource = App.context.Student.Where(s => s.idGroup == Group.Id).ToList();
            }
        }

        private void StudentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = StudentCmb.SelectedItem as Student;
            if (GroupCmb.SelectedIndex == 0)
            {
                ListStudentDg.ItemsSource = App.context.Student.ToList();
            }
            else
            {
                ListStudentDg.ItemsSource = App.context.Student.Where(s => s.idGroup == Student.ID).ToList();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new Menu());
        }
    }
}
