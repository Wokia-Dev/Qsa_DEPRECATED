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
using Qsa_Wpf.Core;

namespace Qsa_Wpf.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
            
        }

        public static bool[] Logiciel_Cks = new bool[10];


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogicielsInfo LibreOffice_info = new LogicielsInfo("Libre office", 0,"https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/LibreOffice_7.1.3_Win_x64.msi",
                   "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/LibreOfficeScript.cmd", "LibreOffice_7.1.3_Win_x64.msi", "LibreOfficeScript.cmd");

            LogicielsInfo Vlc_info = new LogicielsInfo("Vlc", 1, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/vlc-3.0.14-win64.exe"
                    , "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/VlcScript.cmd", "vlc-3.0.14-win64.exe", "VlcScript.cmd");

            LogicielsInfo WinrRar_info = new LogicielsInfo("WinRar", 2, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/winrar-x64-601fr.exe",
                    "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/WinRarScript.cmd", "winrar-x64-601fr.exe", "WinRarScript.cmd");

            LogicielsInfo Spotify_info = new LogicielsInfo("Spotify", 3, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/SpotifySetup.exe",
                   "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/SpotifyScript.cmd", "SpotifySetup.exe", "SpotifyScript.cmd");

            LogicielsInfo Chrome_info = new LogicielsInfo("Chrome", 4, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/googlechromestandaloneenterprise.msi",
                    "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/ChromeScript.cmd",
                    "googlechromestandaloneenterprise.msi", "ChromeScript.cmd");


            //Libre Offfice
            if (Logiciel_Cks[0])
            {
                LibreOffice_info.DowloadFiles(LibreOffice_info._nomFichierCmd, LibreOffice_info._nomFichier, 
                    LibreOffice_info._url, LibreOffice_info._cmdUrl);

                LibreOffice_info.RunScript(LibreOffice_info._nomFichierCmd, true);
            }

            //Vlc
            if(Logiciel_Cks[1])
            {
                Vlc_info.DowloadFiles(Vlc_info._nomFichierCmd, Vlc_info._nomFichier,
                    Vlc_info._url, Vlc_info._cmdUrl);

                Vlc_info.RunScript(Vlc_info._nomFichierCmd, true);
            }

            //WinRar
            if (Logiciel_Cks[2])
            {
                WinrRar_info.DowloadFiles(WinrRar_info._nomFichierCmd, WinrRar_info._nomFichier,
                    WinrRar_info._url, WinrRar_info._cmdUrl);

                WinrRar_info.RunScript(WinrRar_info._nomFichierCmd, true);
            }

            //Spotify
            if (Logiciel_Cks[3])
            {
                Spotify_info.DowloadFiles(Spotify_info._nomFichierCmd, Spotify_info._nomFichier,
                    Spotify_info._url, Spotify_info._cmdUrl);

                Spotify_info.RunScript(Spotify_info._nomFichierCmd, false);
            }

            //Chrome
            if (Logiciel_Cks[4])
            {
                Chrome_info.DowloadFiles(Chrome_info._nomFichierCmd, Chrome_info._nomFichier,
                    Chrome_info._url, Chrome_info._cmdUrl);

                Chrome_info.RunScript(Chrome_info._nomFichierCmd, true);
            }

            MessageBox.Show("Installation fini");
            LibreOffice_info.DeleteFiles(LibreOffice_info._nomFichier, LibreOffice_info._nomFichierCmd);
            Vlc_info.DeleteFiles(Vlc_info._nomFichier, Vlc_info._nomFichierCmd);
            WinrRar_info.DeleteFiles(WinrRar_info._nomFichier, WinrRar_info._nomFichierCmd);
            Spotify_info.DeleteFiles(Spotify_info._nomFichier, Spotify_info._nomFichierCmd);
            Chrome_info.DeleteFiles(Chrome_info._nomFichier, Chrome_info._nomFichierCmd);


        }




        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
