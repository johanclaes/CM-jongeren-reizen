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

namespace wpf
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

        private void btnPersonen_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(personen2);
        }

        private void btnInschrijvingen_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(inschrijvingen2);
        }

        private void btnGroepsreizen_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(groepsreizen2);
        }

        private void btnOpleidingen_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(opleidingen2);
        }

        private void btnBestemmingen_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(bestemmingen2);
        }
        public void SetActiveUserControl(UserControl control5)
        {
            // hide all user controls
            bestemmingen2.Visibility = Visibility.Collapsed;
            groepsreizen2.Visibility = Visibility.Collapsed;
            inschrijvingen2.Visibility = Visibility.Collapsed;
            opleidingen2.Visibility = Visibility.Collapsed;
            personen2.Visibility = Visibility.Collapsed;
            // show the current user control
            control5.Visibility = Visibility.Visible;

        }
    }
}
