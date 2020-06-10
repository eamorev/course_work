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

namespace AirportDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Airline_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Arrivals_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Arrivals arr = new Arrivals();
            arr.ShowDialog();
            Show();
        }

        private void Departures_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Departures dep = new Departures();
            dep.ShowDialog();
            Show();
        }
        private void Timetable_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Timetable tim = new Timetable();
            tim.ShowDialog();
            Show();
        }
    }
}
