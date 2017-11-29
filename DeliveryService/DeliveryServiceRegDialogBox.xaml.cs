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
            String message = "";

            String postCompany = ((ComboBoxItem)combo_PostCompany.SelectedItem).Content.ToString();

            if (tb_PostName.Text.Equals("") || postCompany.Equals("---택배사를 선택해주세요---") || tb_PostNumber.Text.Equals(""))
            {
                int cnt = 0;

                if (tb_PostName.Text.Equals(""))
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
                MessageBoxResult result;
                result = MessageBox.Show("택배 명칭 : '" + tb_PostName.Text + "'\n" 
                                         + "택배사 : '" + postCompany + "'\n" 
                                        + "운송장 번호 : '" + tb_PostNumber.Text + "'",
                    "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("YES", "YES");
                }
            }
        }
    }
}
