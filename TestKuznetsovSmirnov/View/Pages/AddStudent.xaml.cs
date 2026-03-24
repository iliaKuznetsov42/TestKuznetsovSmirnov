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
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Page
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new Menu());
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EnterStudentTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Student newStudent = new Student()
                {
                    Name = EnterStudentTb.Text
                };

                App.context.Student.Add(newStudent);
                App.context.SaveChanges();
                MessageBox.Show("Студент добавлен");
            }
        }
    }
}
