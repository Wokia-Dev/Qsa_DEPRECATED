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

namespace Qsa_Wpf.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour OutilsDevView.xaml
    /// </summary>
    public partial class OutilsDevView : UserControl
    {
        public OutilsDevView()
        {
            InitializeComponent();
        }


        private void NotePad_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (NotePad_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[11] = true;
            }
            else
            {
                UserView.Logiciel_Cks[11] = false;
            }
        }

        private void VS2019_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (VS2019_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[12] = true;
            }
            else
            {
                UserView.Logiciel_Cks[12] = false;
            }

        }

        private void AndroidStudio_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (AndroidStudio_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[13] = true;
            }
            else
            {
                UserView.Logiciel_Cks[13] = false;
            }
        }

        private void VSCode_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (VSCode_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[14] = true;
            }
            else
            {
                UserView.Logiciel_Cks[14] = false;
            }
        }

        private void FileZilla_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (FileZilla_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[17] = true;
            }
            else
            {
                UserView.Logiciel_Cks[17] = false;
            }
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            NotePad_CheckBox.IsChecked = UserView.Logiciel_Cks[11];
            VS2019_CheckBox.IsChecked = UserView.Logiciel_Cks[12];
            AndroidStudio_CheckBox.IsChecked = UserView.Logiciel_Cks[13];
            VSCode_CheckBox.IsChecked = UserView.Logiciel_Cks[14];
            FileZilla_CheckBox.IsChecked = UserView.Logiciel_Cks[17];

        }

        
    }
}
