using DeliveryService.Model;
using SQLite;
using System.Collections.ObjectModel;
using System.IO;

namespace DeliveryService
{
    public class DBManager
    {
        public string db_Path;
        public SQLiteConnection conn;
        private DBQuery db_Query;

        public DBManager(string path)
        {
            if (!File.Exists(path)) //파일이 없을 시 파일 생성
            {
                File.Create(path);
            }

            db_Path = path;

            conn = new SQLiteConnection(path);
            conn.CreateTable<DeliveryServiceTable>();
            db_Query = new DBQuery();
        }

        public bool Insert(string Name, string Company, string Invoice)
        {
            //return db_Query.DB_Insert(conn, ds_Name, ds_Company, ds_Invoice);
            return false;
        }

        public ObservableCollection<Delivery> DB_Select()
        {
            return db_Query.DB_Select(conn);
        }
    }
}
