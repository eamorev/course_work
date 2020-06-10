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
    /// Логика взаимодействия для Arrivals.xaml
    /// </summary>
    public partial class Arrivals : Window
    {
        List<Flight> flights;
        public Arrivals()
        {
            InitializeComponent();
            Arrivals_List.ItemsSource = new List<string>() { "0           23:59    432567    Lufthansa    2      In Air", "1           22:49    443567    Aeroflot    2      Landed" , "1           23:40    432567    Utair    2      In Air" , "1           23:22    432447    RomaAir    2      Landed" , "2           23:50    432347    Lufthansa    2      In Air" , "3           23:59    432567    Lufthansa    2      In Air" , "0           23:56    432657       S7        2      In Air" };
            //flights = 
        }

        private void Arrivals_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
