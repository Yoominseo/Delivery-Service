using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public class Del
    {
        private int id;
        private string nickname;
        private string company;
        private string completeYN;
        private string itemName;
        private string invoice;
        private string receiverName;
        private string senderName;
        private string receiverAddr;
        private List<Track> NotrackingDetails;
        private List<Track> lastStateDetail;
        private List<Track> firstDetail;
    }
}
