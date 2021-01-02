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

namespace Jade_HS_AllroundAPP
{
    /// <summary>
    /// Interaktionslogik für Registrierung.xaml
    /// </summary>
    public partial class Registrierung : Window
    {
        public Registrierung()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void SCHLISSEN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_registrieren_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CB_Geschlecht_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CB_Geschlecht.SelectedIndex == 0)
            {

            }

            if (CB_Geschlecht.SelectedIndex == 1)
            {

            }
        }

        private void CB_Hochschule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CB_Hochschule.SelectedIndex == 0)
            {

            }

            if (CB_Hochschule.SelectedIndex == 1)
            {

            }

            if (CB_Hochschule.SelectedIndex == 2)
            {

            }
        }

        private void DP_Gebrtstag_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
