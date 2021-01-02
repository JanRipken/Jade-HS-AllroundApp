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
    /// Interaktionslogik für Hauptseite.xaml
    /// </summary>
    public partial class Hauptseite : Window
    {
        public Hauptseite()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

             

        private void Btn_OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            Btn_MenuOpen.Visibility = Visibility.Collapsed;
            Btn_MenuClose.Visibility = Visibility.Visible;
        }

        private void Btn_CloseMenu_Click(object sender, RoutedEventArgs e)
        {
            Btn_MenuOpen.Visibility = Visibility.Visible;
            Btn_MenuClose.Visibility = Visibility.Collapsed;
        }

       

        private void LVI_Home_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Visible;           
            bd_Entscheidung.Visibility = Visibility.Hidden;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Konto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_webmail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Visible;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Stundenplan_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Moodle_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Visible;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Datenlaufwerk_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Visible;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Planner_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;

        }

        private void LVI_Assitours_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Visible;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Sport_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Visible;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Cocktails_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_Bewerbung_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Hidden;
        }

        private void LVI_GitHub_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Wilkommen.Visibility = Visibility.Hidden;
            bd_Entscheidung.Visibility = Visibility.Visible;

            WB_Webmail.Visibility = Visibility.Hidden;

            WB_Moodle.Visibility = Visibility.Hidden;
            WB_Datenlaufwerk.Visibility = Visibility.Hidden;
            grd_assitours.Visibility = Visibility.Hidden;

            I_Homeworkout.Visibility = Visibility.Hidden;


            WB_GitHUB.Visibility = Visibility.Visible;
        }

        private void LI_Ingineuerswissenschaften_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LI_ICON_ingi_folderopen.Visibility = Visibility.Visible;
            LI_ICON_ingi_folderclosed.Visibility = Visibility.Hidden;

            LI_ICON_trash_folderopen.Visibility = Visibility.Hidden;
            LI_ICON_trash_folderclosed.Visibility = Visibility.Visible;
        }

        private void LI_Trashsonstiges_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LI_ICON_trash_folderopen.Visibility = Visibility.Visible;
            LI_ICON_trash_folderclosed.Visibility = Visibility.Hidden;

            LI_ICON_ingi_folderopen.Visibility = Visibility.Hidden;
            LI_ICON_ingi_folderclosed.Visibility = Visibility.Visible;
        }
    }
}
