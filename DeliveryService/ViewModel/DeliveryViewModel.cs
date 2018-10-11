using DeliveryService.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryService.ViewModel
{
    public class DeliveryViewModel
    {
        public ObservableCollection<Delivery> Items { get; set; }

        public DeliveryViewModel()
        {
            Items = new ObservableCollection<Delivery>();
        }

        public void LoadData(ObservableCollection<Delivery> ob_Deliveries)
        {
            Items = new ObservableCollection<Delivery>();

            foreach (var data in ob_Deliveries)
            {
                Debug.WriteLine("id : " + data.Id + ", Name : " + data.Name + ", company : " + data.Company + ", number : " + data.Invoice);
                Items.Add(data);
            }
        }
    }
}
