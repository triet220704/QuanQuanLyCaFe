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

namespace QuanQuanLyCaFe.Admin_Control
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
            
          /*  LoadAccountList();*/

        }

        /*void LoadAccountList()
        {
            string query = "EXEC USP_GetAccountByUserName @username";

            

            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"staff"});
        }*/

        private void UC_Account_Load(object sender, EventArgs e)
        {

        }
    }
}

