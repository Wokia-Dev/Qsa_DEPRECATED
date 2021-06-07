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
using System.Net;
using System.IO;
using System.Diagnostics;
using Path = System.IO.Path;

namespace Qsa_Wpf.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour BureautiqueView.xaml
    /// </summary>
    public partial class BureautiqueView : UserControl
    {
        public BureautiqueView()
        {
            InitializeComponent();
           
        }
       
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists(Path.GetTempPath() + "googlechromestandaloneenterprise.msi"))
            {
                return;
            }
            else
            {
                string urlCmd = "https://stockagewpokia.blob.core.windows.net/test/Fichier%20d'installatipn/test.cmd";
                string url = "https://dl.google.com/tag/s/dl/chrome/install/googlechromestandaloneenterprise.msi";

                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, Path.GetTempPath() + "googlechromestandaloneenterprise.msi");
                webClient.DownloadFile(urlCmd, Path.GetTempPath() + "test.cmd");

                Process process = new Process();
                process.StartInfo.Verb = "runas";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = Path.GetTempPath() + "test.cmd";
                process.Start();

            }
            
        }

        private void LibreOffice_checkBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (LibreOffice_checkBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[0] = true;

            }
            else
            {
                UserView.Logiciel_Cks[0] = false;
            }

        }

        private void Vlc_checkBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Vlc_checkBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[1] = true;
            }
            else
            {
                UserView.Logiciel_Cks[1] = false;
            }
        }

        private void WinRar_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (WinRar_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[2] = true;
            }
            else
            {
                UserView.Logiciel_Cks[2] = false;
            }
        }

        private void Spotify_CheckBox_DataContextChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Spotify_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[3] = true;
            }
            else
            {
                UserView.Logiciel_Cks[3] = false;
            }
        }




        private void Grid_Initialized(object sender, EventArgs e)
        {
            LibreOffice_checkBox.IsChecked = UserView.Logiciel_Cks[0];
            Vlc_checkBox.IsChecked = UserView.Logiciel_Cks[1];
            WinRar_CheckBox.IsChecked = UserView.Logiciel_Cks[2];
            Spotify_CheckBox.IsChecked = UserView.Logiciel_Cks[3];
        }

        
    }
}
