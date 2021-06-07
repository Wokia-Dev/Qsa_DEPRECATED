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
    /// Logique d'interaction pour NavigateursView.xaml
    /// </summary>
    public partial class NavigateursView : UserControl
    {
        public NavigateursView()
        {
            InitializeComponent();
        }

        private void Chrome_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Chrome_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[4] = true;
            }
            else
            {
                UserView.Logiciel_Cks[4] = false;
            }
        }

        private void FireFox_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (FireFox_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[5] = true;
            }
            else
            {
                UserView.Logiciel_Cks[5] = false;
            }
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            Chrome_CheckBox.IsChecked = UserView.Logiciel_Cks[4];
            FireFox_CheckBox.IsChecked = UserView.Logiciel_Cks[5];
        }

        
    }
}
