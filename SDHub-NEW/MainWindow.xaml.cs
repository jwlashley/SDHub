using System;
using System.Diagnostics;
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

namespace SDHub_NEW
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


        //Reference Sites
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://myphs.promedica.org");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://storefront.promedica.org");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://gateway-1.promedica.org/core/login?url=/security-lookup/v0/app/#/");
        }

        //Troubleshooting Apps
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("http://amisys01.promedica.org:8050/amisys-web/PhcSessionKiller");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Process.Start("https://desktopdirector.phsi.promedica.org/Director/LogOn.aspx?cc=true");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Process.Start("https://extendedcare.com");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Process.Start("https://cagportal.mediserve.com/vpn/index.html");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Program Files\RealVNC\VNC Viewer\vncviewer.exe");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Process.Start("https://fdadmin-phl.mmodal.com/MMServicesAdmin/login.jsp");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        }

        private void HIDENT_Click_10(object sender, RoutedEventArgs e)
        {
            Process.Start("https://hident.hcr-manorcare.com/");
        }

        private void Provisioning_Click_11(object sender, RoutedEventArgs e)
        {
            Process.Start("http://provisioningsupport.app.hcr-manorcare.com/Report/Dashboard");
        }

        private void Kronos_Click_12(object sender, RoutedEventArgs e)
        {
            Process.Start("IEXPLORE.EXE", "https://kronos8.hcr-manorcare.com/wfc/logonWithUID");
        }

        private void HCHB_Click_13(object sender, RoutedEventArgs e)
        {
            Process.Start("https://login.hchb.com/vpn/index.html");
        }

        private void Optima_Click_10(object sender, RoutedEventArgs e)
        {
            Process.Start("IEXPLORE.exe", "https://login.optimahcs.com/");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Process.Start("https://hcr.pointclickcare.com/home/login.jsp");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Process.Start("https://cn420.awmdm.com/AirWatch/Login");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Process.Start("https://prod.dssi.net/Home/ShowFacilitySelect");
        }



        //Active Directory

    }
}
