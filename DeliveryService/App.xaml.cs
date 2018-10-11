using DeliveryService.Model;
using DeliveryService.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DeliveryService
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public static DBManager dbManager = new DBManager("DeliveryService.sqlite");
        public static DeliveryViewModel deliveryViewModel = new DeliveryViewModel();

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            dbManager.conn.Close();
        }
    }
}
