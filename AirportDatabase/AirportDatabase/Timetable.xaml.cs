using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AirportDatabase
{
    /// <summary>
    /// Логика взаимодействия для Timetable.xaml
    /// </summary>
    public partial class Timetable : Window
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Flight flght = new Flight();
            flght.ShowDialog();
            Show();
        }
    }
}
