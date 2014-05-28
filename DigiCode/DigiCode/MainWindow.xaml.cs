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

namespace DigiCode
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IEnumerable<SalleEntity> mySalles = SalleService.LoadSalleList();
            SalleListView.ItemsSource = mySalles;
            //SalleListView.Items.Add(new Salle());
            //((Salle)SalleListView.Items[0]).SetUnamedSalle("SALLE");
        }

        private void ResetCodeButton_Click(object sender, RoutedEventArgs e)
        {
            if (SalleListView.SelectedItems.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show("Changer le Digicode de ces(cette) salle(s)?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    foreach (SalleEntity salle in SalleListView.SelectedItems)
                    {
                        salle.ResetCode();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pas de salle séléctionnée");
            }
        }
    }
}
