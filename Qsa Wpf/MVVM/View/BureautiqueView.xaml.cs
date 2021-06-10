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

        private void Skype_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Skype_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[3] = true;
            }
            else
            {
                UserView.Logiciel_Cks[3] = false;
            }
        }

        private void qBittorrent_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (qBittorrent_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[8] = true;
            }
            else
            {
                UserView.Logiciel_Cks[8] = false;
            }
        }

        private void ReaderDC_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (ReaderDC_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[9] = true;
            }
            else
            {
                UserView.Logiciel_Cks[9] = false;
            }
        }

        private void SevenZip_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (SevenZip_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[10] = true;
            }
            else
            {
                UserView.Logiciel_Cks[10] = false;
            }
        }
        


        private void Grid_Initialized(object sender, EventArgs e)
        {
            LibreOffice_checkBox.IsChecked = UserView.Logiciel_Cks[0];
            Vlc_checkBox.IsChecked = UserView.Logiciel_Cks[1];
            WinRar_CheckBox.IsChecked = UserView.Logiciel_Cks[2];
            Skype_CheckBox.IsChecked = UserView.Logiciel_Cks[3];
            qBittorrent_CheckBox.IsChecked = UserView.Logiciel_Cks[8];
            ReaderDC_CheckBox.IsChecked = UserView.Logiciel_Cks[9];
            SevenZip_CheckBox.IsChecked = UserView.Logiciel_Cks[10];
        }


    }
}
