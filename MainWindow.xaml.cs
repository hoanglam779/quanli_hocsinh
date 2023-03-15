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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> taikhoan_hs = new Dictionary<string, string>();
            taikhoan_hs.Add("21522274", "123456");
            taikhoan_hs.Add("hocsinh", "hocsinh");
            Dictionary<string, string> taikhoan_gv = new Dictionary<string, string>();
            taikhoan_gv.Add("giaovien", "giaovien");
            Dictionary<string, string> taikhoan_cb = new Dictionary<string, string>();
            taikhoan_cb.Add("canbo", "canbo");

            string tk = txtUsername.Text;
            string mk = txtPassword.Text;

            string tryvalue;
            if (taikhoan_hs.TryGetValue(tk, out tryvalue))
            {
                if (taikhoan_hs[tk] == mk)
                {
                    //MessageBox.Show("HOcsinh");
                    new MenuHocSinh().Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu, vui lòng nhập lại");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            else if (taikhoan_gv.TryGetValue(tk, out tryvalue))
            {
                if (taikhoan_gv[tk] == mk)
                {
                    MessageBox.Show("Giaovien");
                    new MenuGiaoVien().Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu, vui lòng nhập lại");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            else if (taikhoan_cb.TryGetValue(tk, out tryvalue))
            {
                if (taikhoan_cb[tk] == mk)
                {
                    //MessageBox.Show("canbo");
                    new MenuCanBo().Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu, vui lòng nhập lại");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại, vui lòng nhập lại");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }

        }

     
    }
    
}
