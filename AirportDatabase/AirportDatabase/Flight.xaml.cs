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
    /// Логика взаимодействия для Flight.xaml
    /// </summary>
    public partial class Flight : Window
    {
        public Flight()
        {
            InitializeComponent();
            Flight_List.ItemsSource = new List<string>() { "    3           2       23:59       03:40       43256     3" };

        }

        private void Flight_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
