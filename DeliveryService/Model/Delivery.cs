using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public class Delivery : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private bool result;
        private string company;
        private string invoice;
        private string itemName;
        private string receiverName;
        private string senderName;
        private string receiverAddr;
        private string lastLocation;
        private List<Track> trackingDetails;
        private Track lastDetail;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                if (value != company)
                {
                    company = value;
                    NotifyPropertyChanged("Company");
                }
            }
        }

        public string Invoice
        {
            get
            {
                return invoice;
            }
            set
            {
                if (value != invoice)
                {
                    invoice = value;
                    NotifyPropertyChanged("Invoice");
                }
            }
        }

        public string LastLocation
        {
            get
            {
                return lastLocation;
            }
            set
            {
                if (value != lastLocation)
                {
                    lastLocation = value;
                    NotifyPropertyChanged("LastLocation");
                }
            }
        }

        public bool Result
        {
            get
            {
                return result;
            }
            set
            {
                if (value != result)
                {
                    result = value;
                    NotifyPropertyChanged("Result");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
