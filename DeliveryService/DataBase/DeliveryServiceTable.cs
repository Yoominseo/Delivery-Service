using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryService
{
    public class DeliveryServiceTable
    {
        [PrimaryKey, NotNull, AutoIncrement]
        public int ID { get; set; }

        [NotNull]
        public string NAME { get; set; }

        [NotNull]
        public string ITEM_NAME { get; set; }

        [NotNull]
        public string COMPANY { get; set; }

        [NotNull]
        public string INVOICE { get; set; }

        [NotNull]
        public string LAST_LOCATION { get; set; }

        [NotNull]
        public int RESULT { get; set; }
    }
}
