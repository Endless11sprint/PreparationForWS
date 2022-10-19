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
namespace Progevt43
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Contract _currentContract = new Contract();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentContract;
            ComboСustomersСountry.ItemsSource = ExportOfRawMaterials2Entities.GetContext().Сountries.ToList();
            ComboСust1.ItemsSource = ExportOfRawMaterials2Entities.GetContext().Сountries.ToList();
        }

        private void BtnSaveBD_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboСustomersСountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboСust1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAddRaw_Click(object sender, RoutedEventArgs e)
        {
            Manage.MainFrame.Navigate(new PageAddRaw());

        }
    }
}
