using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanQuanLyCaFe.DAO;
using QuanQuanLyCaFe.DTO;

namespace QuanQuanLyCaFe.Admin_Control
{
    public partial class UC_Account : UserControl
    {
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public UC_Account()
        {
            InitializeComponent();
            dgvAccount.DataSource = accountList;
            AddAccountBinding();
            LoadAccount();

            /*  LoadAccountList();*/

        }

        /*void LoadAccountList()
        {
            string query = "EXEC USP_GetAccountByUserName @username";

            

            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"staff"});
        }*/
        void AddAccountBinding()
        {
            tbAccountUsername.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            tbAccountDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nprAcount.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {

        }

        private void btnAccountShow_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void AddAccount(string userName, string displayName, int Type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, Type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }
        void EditAccount(string userName, string displayName, int Type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, Type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }
        void DEleteAccount(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xoá tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại");
            }
            LoadAccount();
        }
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassWord(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
            
        }
        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            string userName = tbAccountUsername.Text;
            string displayName = tbAccountDisplayName.Text;
            int type = (int)nprAcount.Value;
            AddAccount(userName, displayName, type);
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            string userName = tbAccountUsername.Text;
            DEleteAccount(userName);
        }

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            string userName = tbAccountUsername.Text;
            string displayName = tbAccountDisplayName.Text;
            int type = (int)nprAcount.Value;
            EditAccount(userName, displayName, type);
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = tbAccountUsername.Text;
            ResetPass(userName);
        }
    }
}

