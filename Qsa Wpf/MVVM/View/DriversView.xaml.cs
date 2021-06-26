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
    /// Logique d'interaction pour DriversView.xaml
    /// </summary>
    public partial class DriversView : UserControl
    {
        public DriversView()
        {
            InitializeComponent();
        }

        private void IntelDrivers_CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IntelDrivers_CheckBox.IsChecked == true)
            {
                UserView.Logiciel_Cks[19] = true;

            }
            else
            {
                UserView.Logiciel_Cks[19] = false;
            }
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            IntelDrivers_CheckBox.IsChecked = UserView.Logiciel_Cks[19];
        }


    }
}
