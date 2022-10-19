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
    /// Логика взаимодействия для HotelPage.xaml
    /// </summary>
    public partial class HotelPage : Page
    {
        public HotelPage()
        {
            InitializeComponent();
            DGridInfoTabel.ItemsSource = ExportOfRawMaterials2Entities.GetContext().Contract.ToList();
        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Manage.MainFrame.Navigate(new AddEditPage());
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manage.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
