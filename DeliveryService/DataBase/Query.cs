using DeliveryService.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryService
{
    public interface Query
    {
        bool DB_Insert(SQLiteConnection conn, string Name, string Company, string Invoice);
        ObservableCollection<Delivery> DB_Select(SQLiteConnection conn);
        bool DB_Update(SQLiteConnection conn, string id, string Name, string Company, string Invoice);
        bool DB_Remove(SQLiteConnection conn, string id);
    }
}
