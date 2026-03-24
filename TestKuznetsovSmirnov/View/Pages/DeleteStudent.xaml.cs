using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для DeleteStudent.xaml
    /// </summary>
    public partial class DeleteStudent : Page
    {
        public DeleteStudent()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.group.ToList();
        }
        

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            group Group = GroupCmb.SelectedItem as group;
            if (GroupCmb.SelectedIndex == 0)
            {
                StudentLv.ItemsSource = App.context.Student.ToList();
            }
            else
            {
                StudentLv.ItemsSource = App.context.Student.Where(s => s.idGroup == Group.Id).ToList();
            }
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = StudentLv.SelectedItem as Student;
            MessageBoxResult messageBoxResult = MessageBox.Show("Удалить выбранного студента?", "Удалить", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                App.context.Student.Remove(selectedStudent);
                MessageBox.Show("Студент удален");

            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new Menu());
        }
    }
}
