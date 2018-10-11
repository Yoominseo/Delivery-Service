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
using System.Windows.Shapes;

namespace DeliveryService
{
    /// <summary>
    /// DeliveryServiceDirectorDialogBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DeliveryServiceDirectorDialogBox : Window
    {
        public DeliveryServiceDirectorDialogBox()
        { 
            InitializeComponent();

            lv_DeliveryList.ItemsSource = App.deliveryViewModel.Items;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvDeliveryList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("d");
        }
    }
}
