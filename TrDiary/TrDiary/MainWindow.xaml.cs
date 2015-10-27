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

namespace TrDiary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ExerciseList list = new ExerciseList();
            listboxExercise.ItemsSource = list;

            User u = new User() { UserName = "sfksl" };
            DataContext = u;
            //UserName.Text = u.UserName;
            //UserWeight.Text = Convert.ToString(u.Weight);
            //UserHeight.Text = Convert.ToString(u.Height);
            AllExercises.ItemsSource = list;

        }

        private void UserReady(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewTraining(object sender, RoutedEventArgs e)
        {
            var AddNewWindow = new Window1();
            AddNewWindow.ShowDialog();
        }
    }
    }

