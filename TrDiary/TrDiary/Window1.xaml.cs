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

namespace TrDiary
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
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
    }
}
