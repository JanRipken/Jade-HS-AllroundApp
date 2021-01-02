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



namespace Jade_HS_AllroundAPP
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
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
            Application.Current.Shutdown();
        }

        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            Hauptseite hauptseite = new Hauptseite();
            hauptseite.Show();
            this.Close();
        }

        private void REGISTRIEREN_Click(object sender, RoutedEventArgs e)
        {
            Registrierung registrierung = new Registrierung();
            registrierung.Show();
        }

       

      

        private void txtb_Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtb_Username.Text.Length == 0)
            {
                lbl_username.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_username.Visibility = Visibility.Hidden;
            }
        }

        private void txtb_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtb_Password.Password.Length == 0)
            {
                lbl_Passwort.Visibility = Visibility.Visible;
            }
            else
            {
                lbl_Passwort.Visibility = Visibility.Hidden;
            }
        }
    }
}
