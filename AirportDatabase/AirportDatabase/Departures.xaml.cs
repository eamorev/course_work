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
    /// Логика взаимодействия для Departures.xaml
    /// </summary>
    public partial class Departures : Window
    {
        public Departures()
        {
            InitializeComponent();
            Departure_List.ItemsSource = new List<string>() { "2          23:00    34657       S7        2      Not cancelled", "3     22:00    356787       Luft        2      Not cancelled", "4           23:00    432167       S7        2      Not Cancelled" };
        }

        private void Departure_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
