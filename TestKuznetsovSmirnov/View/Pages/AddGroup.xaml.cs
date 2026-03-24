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
    /// Логика взаимодействия для AddGroup.xaml
    /// </summary>
    public partial class AddGroup : Page
    {
        public AddGroup()
        {
            InitializeComponent();


        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameGroupTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                 group newGroup = new group()
                {
                    Name = NameGroupTb.Text 
                };

                App.context.group.Add(newGroup);
                App.context.SaveChanges();
                MessageBox.Show("Группа добавлена");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new Menu());
        }
    }
}
