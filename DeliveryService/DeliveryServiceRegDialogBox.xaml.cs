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
using System.Text.RegularExpressions;
using SQLite;
using static DeliveryService.DBQuery;
using System.Diagnostics;

namespace DeliveryService
{
    /// <summary>
    /// DeliveryServiceRegDialogBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DeliveryServiceRegDialogBox : Window
    {
        public DeliveryServiceRegDialogBox()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            
            List<String> list = new List<String>();
            string message = "";

            string postName = tb_PostName.Text;
            string postCompany = ((ComboBoxItem)cb_PostCompany.SelectedItem).Content.ToString();
            

            if (tb_PostName.Text.Equals("") || postCompany.Equals("---택배사를 선택해주세요---") || tb_PostNumber.Text.Equals(""))
            {
                int cnt = 0;

                if (postName.Equals(""))
                    list.Add("택배 명칭");

                if (postCompany.Equals("---택배사를 선택해주세요---"))
                    list.Add("택배사");

                if (tb_PostNumber.Text.Equals(""))
                    list.Add("운송장 번호");

                cnt = list.Count;
                message = list[0];

                if (cnt > 1)
                    for (int i = 1; i < cnt; i++)
                        message += ", " + list[i];

                MessageBox.Show(message + "를 확인해주세요", "오류");
            }
            else
            {
                string postNumber = tb_PostNumber.Text;

                MessageBoxResult result;
                result = MessageBox.Show("택배 명칭 : '" + postName + "'\n" 
                                         + "택배사 : '" + postCompany + "'\n" 
                                        + "운송장 번호 : '" + postNumber + "'"
                                        ,"Question", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    bool db_result = App.dbManager.Insert(postName, postCompany, postNumber);

                    if (db_result)
                    {
                        MessageBox.Show("데이터 삽입 오류!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        tb_PostName.Text = tb_PostNumber.Text = "";
                        cb_PostCompany.SelectedIndex = 0;
                        App.deliveryViewModel.LoadData(App.dbManager.DB_Select());
                        MessageBox.Show("택배가 등록 되었습니다.", "성공", MessageBoxButton.OK, MessageBoxImage.None);
                    }
                }
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+"); 
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
