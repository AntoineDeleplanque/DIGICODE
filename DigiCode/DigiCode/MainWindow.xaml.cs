using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace DigiCode
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            IEnumerable<SalleEntity> mySalles = SalleService.LoadSalleList();
            SalleListView.ItemsSource = mySalles;
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

        private void ShowCodeButton_Click(object sender, RoutedEventArgs e)
        {
            if (SalleListView.SelectedItems.Count > 0)
            {
                SalleEntity firstOrDefaultSalleEntity = (SalleEntity)((IList<object>)SalleListView.SelectedItems).FirstOrDefault();
                if (firstOrDefaultSalleEntity != null)
                {
                    MessageBoxResult result = MessageBox.Show("Voir le code de cette salle : " + firstOrDefaultSalleEntity.Libelle + "?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        MessageBox.Show(firstOrDefaultSalleEntity.Code.ToString(CultureInfo.InvariantCulture));
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
