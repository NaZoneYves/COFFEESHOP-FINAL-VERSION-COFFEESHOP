using PROJECT.DB;
using PROJECT.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                Home hm = new Home();
                this.Hide();
                hm.ShowDialog();
                //khi gọi phương thức Showdialog(), ngưng thực hiện đoạn lệnh sau đó cho đến khi đóng form này
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc Mật khẩu của bạn không đúng! Vui lòng thử lại!");
            }
        }
        bool Login(string userName, string passWord)
        {
            return ProcessLogin.Instance.Login(userName, passWord);
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
