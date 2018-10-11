using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using DeliveryService.Model;
using System.Collections.ObjectModel;

namespace DeliveryService
{
    public class DBQuery : Query
    {
        private ReaderWriterLockSlim sqliteLock = new ReaderWriterLockSlim();
        
        public bool DB_Insert(SQLiteConnection conn, string Name, string Company, string Invoice)
        {
            try
            {
                DeliveryServiceTable ds_T = new DeliveryServiceTable
                {
                    NAME = Name,
                    COMPANY = Company,
                    INVOICE = Invoice
                };

                sqliteLock.EnterWriteLock();
                conn.Insert(ds_T);
                sqliteLock.ExitWriteLock();
            }
            catch
            {
                if (sqliteLock.IsWriteLockHeld)
                {
                    sqliteLock.ExitWriteLock();
                }
                return true;
            }

            Debug.WriteLine("Success Data Insert");

            return false;
        }

        public ObservableCollection<Delivery> DB_Select(SQLiteConnection conn)
        {
            var selectItem = conn.Table<DeliveryServiceTable>();

            var item = new ObservableCollection<Delivery>();

            foreach (var data in selectItem)
            {
                item.Add(new Delivery {
                    Id = data.ID,
                    Name = data.NAME,
                    Company = data.COMPANY,
                    Invoice = data.INVOICE,
                    LastLocation = data.LAST_LOCATION,
                    Result = data.RESULT == 0 ? false : true
                });
            }

            Debug.WriteLine("Success Data Select");

            return item;
        }

        public bool DB_Remove(SQLiteConnection conn, string id)
        {
            return true;
        }

        public bool DB_Update(SQLiteConnection conn, string id, string Name, string Company, string Invoice)
        {
            return true;
        }
    }
}
