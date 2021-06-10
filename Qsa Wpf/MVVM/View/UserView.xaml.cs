using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public static bool[] Logiciel_Cks = new bool[20];


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region Déclaration infos logiciels

            LogicielsInfo LibreOffice_info = new LogicielsInfo("Libre office", 0, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Bureautique/LibreOffice_7.1.3_Win_x64.msi",
                   "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Bureautique/LibreOfficeScript.cmd",
                   "LibreOffice_7.1.3_Win_x64.msi", "LibreOfficeScript.cmd");

            LogicielsInfo Vlc_info = new LogicielsInfo("Vlc", 1, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Bureautique/vlc-3.0.14-win64.exe"
                    , "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Bureautique/VlcScript.cmd",
                    "vlc-3.0.14-win64.exe", "VlcScript.cmd");

            LogicielsInfo WinrRar_info = new LogicielsInfo("WinRar", 2, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Bureautique/winrar-x64-601fr.exe",
                    "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Bureautique/WinRarScript.cmd",
                    "winrar-x64-601fr.exe", "WinRarScript.cmd");

            LogicielsInfo Skype_info = new LogicielsInfo("Skype", 3, "url",
                   "cmdUrl", "nomFichier", "nomFichierCmd");

            LogicielsInfo Chrome_info = new LogicielsInfo("Chrome", 4, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Navigateurs/googlechromestandaloneenterprise.msi",
                    "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Navigateurs/ChromeScript.cmd",
                    "googlechromestandaloneenterprise.msi", "ChromeScript.cmd");

            LogicielsInfo FireFox_info = new LogicielsInfo("FireFox", 5, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Navigateurs/Firefox.msi",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Navigateurs/FireFoxScript.cmd",
                "Firefox.msi", "FireFoxScript.cmd");

            LogicielsInfo Brave_info = new LogicielsInfo("Brave", 6, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Navigateurs/BraveBrowserStandaloneSilentSetup.exe",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Navigateurs/BraveScript.cmd",
                "BraveBrowserStandaloneSilentSetup.exe", "BraveScript.cmd");

            LogicielsInfo Opera_info = new LogicielsInfo("Opera", 7, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Navigateurs/OperaSetup.exe",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Navigateurs/OperaScript.cmd",
                "OperaSetup.exe", "OperaScript.cmd");

            LogicielsInfo qBittorrent_info = new LogicielsInfo("qBittorrent", 8, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Bureautique/qbittorrent_4.3.5_x64_setup.exe",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Bureautique/qBittorrentScript.cmd",
                "qbittorrent_4.3.5_x64_setup.exe", "qBittorrentScript.cmd");

            LogicielsInfo ReaderDC_info = new LogicielsInfo("ReaderDC", 9, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Bureautique/AcroRdrDC2100520048_fr_FR.exe",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Bureautique/ReaderDCScript.cmd",
                "AcroRdrDC2100520048_fr_FR.exe", "ReaderDCScript.cmd");

            LogicielsInfo SevenZip_info = new LogicielsInfo("7-Zip", 10, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Bureautique/7z1900-x64.exe",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Bureautique/7-ZipScript.cmd",
                "7z1900-x64.exe", "7-ZipScript.cmd");

            LogicielsInfo NotePad_info = new LogicielsInfo("NotePad", 11, "https://stockagewpokia.blob.core.windows.net/qsa/Dowload%20FIle/Outils%20Dev/npp.8.0.Installer.x64.exe",
                "https://stockagewpokia.blob.core.windows.net/qsa/Script%20/Outils%20Dev/NotePadScript.cmd",
                "npp.8.0.Installer.x64.exe", "NotePadScript.cmd");



            #endregion

            #region telechargement et installation des logiciels
            //Libre Offfice
            if (Logiciel_Cks[0])
            {
                LibreOffice_info.DowloadFiles(LibreOffice_info._nomFichierCmd, LibreOffice_info._nomFichier,
                LibreOffice_info._url, LibreOffice_info._cmdUrl);

                LibreOffice_info.RunScript(LibreOffice_info._nomFichierCmd, true);
            }

            //Vlc
            if (Logiciel_Cks[1])
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

            //Skype
            if (Logiciel_Cks[3])
            {
                Skype_info.DowloadFiles(Skype_info._nomFichierCmd, Skype_info._nomFichier,
                    Skype_info._url, Skype_info._cmdUrl);

                Skype_info.RunScript(Skype_info._nomFichierCmd, false);
            }

            //Chrome
            if (Logiciel_Cks[4])
            {
                Chrome_info.DowloadFiles(Chrome_info._nomFichierCmd, Chrome_info._nomFichier,
                    Chrome_info._url, Chrome_info._cmdUrl);

                Chrome_info.RunScript(Chrome_info._nomFichierCmd, true);

            }

            //FireFox
            if (Logiciel_Cks[5])
            {
                FireFox_info.DowloadFiles(FireFox_info._nomFichierCmd, FireFox_info._nomFichier,
                    FireFox_info._url, FireFox_info._cmdUrl);

                FireFox_info.RunScript(FireFox_info._nomFichierCmd, true);
            }

            //Brave
            if (Logiciel_Cks[6])
            {
                Brave_info.DowloadFiles(Brave_info._nomFichierCmd, Brave_info._nomFichier,
                    Brave_info._url, Brave_info._cmdUrl);

                Brave_info.RunScript(Brave_info._nomFichierCmd, true);
            }

            //Opera
            if (Logiciel_Cks[7])
            {
                Opera_info.DowloadFiles(Opera_info._nomFichierCmd, Opera_info._nomFichier,
                    Opera_info._url, Opera_info._cmdUrl);

                Opera_info.RunScript(Opera_info._nomFichierCmd, true);
            }

            //qBittorrent
            if (Logiciel_Cks[8])
            {
                qBittorrent_info.DowloadFiles(qBittorrent_info._nomFichierCmd, qBittorrent_info._nomFichier,
                    qBittorrent_info._url, qBittorrent_info._cmdUrl);

                qBittorrent_info.RunScript(qBittorrent_info._nomFichierCmd, true);
            }

            //Reader DC
            if (Logiciel_Cks[9])
            {
                ReaderDC_info.DowloadFiles(ReaderDC_info._nomFichierCmd, ReaderDC_info._nomFichier,
                    ReaderDC_info._url, ReaderDC_info._cmdUrl);

                ReaderDC_info.RunScript(ReaderDC_info._nomFichierCmd, true);
            }

            //7-Zip
            if (Logiciel_Cks[10])
            {
                SevenZip_info.DowloadFiles(SevenZip_info._nomFichierCmd, SevenZip_info._nomFichier,
                    SevenZip_info._url, SevenZip_info._cmdUrl);

                SevenZip_info.RunScript(SevenZip_info._nomFichierCmd, true);
            }

            //NotePad ++
            if (Logiciel_Cks[11])
            {
                NotePad_info.DowloadFiles(NotePad_info._nomFichierCmd, NotePad_info._nomFichier,
                    NotePad_info._url, NotePad_info._cmdUrl);

                NotePad_info.RunScript(NotePad_info._nomFichierCmd, true);
            }

            #endregion

            Thread.Sleep(1000);


            LibreOffice_info.DeleteFiles(LibreOffice_info._nomFichier, LibreOffice_info._nomFichierCmd);
            Vlc_info.DeleteFiles(Vlc_info._nomFichier, Vlc_info._nomFichierCmd);
            WinrRar_info.DeleteFiles(WinrRar_info._nomFichier, WinrRar_info._nomFichierCmd);
            Skype_info.DeleteFiles(Skype_info._nomFichier, Skype_info._nomFichierCmd);
            Chrome_info.DeleteFiles(Chrome_info._nomFichier, Chrome_info._nomFichierCmd);
            FireFox_info.DeleteFiles(FireFox_info._nomFichier, FireFox_info._nomFichierCmd);
            Brave_info.DeleteFiles(Brave_info._nomFichier, Brave_info._nomFichierCmd);
            Opera_info.DeleteFiles("File no exist", Opera_info._nomFichierCmd);
            qBittorrent_info.DeleteFiles(qBittorrent_info._nomFichier, qBittorrent_info._nomFichierCmd);
            ReaderDC_info.DeleteFiles(ReaderDC_info._nomFichier, ReaderDC_info._nomFichierCmd);
            SevenZip_info.DeleteFiles(SevenZip_info._nomFichier, SevenZip_info._nomFichierCmd);
            NotePad_info.DeleteFiles(NotePad_info._nomFichier, NotePad_info._nomFichierCmd);

            Thread.Sleep(3000);
        }




        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
