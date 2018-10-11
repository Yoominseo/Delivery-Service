using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryService.Model
{
    public class Track
    {
        private string timeString;
        private string where;
        private string telno;
        private string kind;

        public string TimeString
        {
            get => timeString;

            set
            {
                if (value != timeString)
                {
                    timeString = value;
                }
            }
        }

        public string Where
        {
            get => where;

            set
            {
                if (value != where)
                {
                    where = value;
                }
            }
        }

        public string Telno
        {
            get => telno;

            set
            {
                if (value != telno)
                {
                    telno = value;
                }
            }
        }

        public string Kind
        {
            get => kind;

            set
            {
                if (value != kind)
                {
                    kind = value;
                }
            }
        }
    }
}
