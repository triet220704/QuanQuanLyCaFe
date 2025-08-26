using QuanQuanLyCaFe.DAO;
using QuanQuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanQuanLyCaFe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
            ChangeAccount(acc);
        }
        void ChangeAccount(Account acc)
        {
            tbUserName.Text = loginAccount.UserName;
            tbDisplayName.Text = loginAccount.DisplayName;
        }
        void UpdateAccountInfo()
        {
            string displayName = tbDisplayName.Text;
            string password = tbPassword.Text;
            string newpass = tbNewPassword.Text;
            string reenterPass = tbEnterPassword.Text;
            string userName = tbUserName.Text;
            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Vui  lòng điền đúng mật khẩu");
                }
            }
        }
        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

     /*   private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

       /* private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }*/

        private void tbEnterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }

}
