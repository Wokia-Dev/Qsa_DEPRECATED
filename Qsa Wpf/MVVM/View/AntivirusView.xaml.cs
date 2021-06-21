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
    /// Logique d'interaction pour AntivirusView.xaml
    /// </summary>
    public partial class AntivirusView : UserControl
    {
        public AntivirusView()
        {
            InitializeComponent();
        }

        

        private void Malwarebytes_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Malwarebytes_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[15] = true;
            }
            else
            {
                UserView.Logiciel_Cks[15] = false;
            }
        }

        private void Avast_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Avast_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[16] = true;
            }
            else
            {
                UserView.Logiciel_Cks[16] = false;
            }
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            Malwarebytes_CheckBox.IsChecked = UserView.Logiciel_Cks[15];
            Avast_CheckBox.IsChecked = UserView.Logiciel_Cks[16];
        }

        
    }
}
