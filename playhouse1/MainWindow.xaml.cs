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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace playhouse1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            out1.ItemsSource = new string[] { "1","2","3","4","5","6","7" };
            out1.SelectedIndex = 0;
            out2.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out2.SelectedIndex = 0;
            out3.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out3.SelectedIndex = 0;
            out4.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out4.SelectedIndex = 0;
            out5.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out5.SelectedIndex = 0;
            out6.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out6.SelectedIndex = 0;
            out7.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out7.SelectedIndex = 0;
            out8.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out8.SelectedIndex = 0;
            out9.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out9.SelectedIndex = 0;
            out10.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out10.SelectedIndex = 0;
            out11.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out11.SelectedIndex = 0;
            out12.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out12.SelectedIndex = 0;
            out13.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out13.SelectedIndex = 0;
            out14.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out14.SelectedIndex = 0;
            out15.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out15.SelectedIndex = 0;
            out16.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out16.SelectedIndex = 0;
            out17.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out17.SelectedIndex = 0;
            out18.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out18.SelectedIndex = 0;
            out19.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out19.SelectedIndex = 0;
            out20.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            out20.SelectedIndex = 0;

            cmb_rand_range.ItemsSource = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            cmb_rand_range.SelectedIndex = 3;
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {

        }

        private void randomandsend_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            int rand_num;
            int rand_range = cmb_rand_range.SelectedIndex;
            rand_num = r.Next(rand_range);        // 0～7の乱数を取得
            out1.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);       
            out2.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out3.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out4.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out5.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out6.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out7.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out8.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out9.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);       
            out10.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);      
            out11.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);      
            out12.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);      
            out13.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);     
            out14.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);    
            out15.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);      
            out16.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);     
            out17.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);     
            out18.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);
            out19.SelectedIndex = rand_num;
            rand_num = r.Next(rand_range);    
            out20.SelectedIndex = rand_num;

        }
    }
}
