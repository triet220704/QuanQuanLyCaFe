using QuanQuanLyCaFe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanQuanLyCaFe.Admin_Control
{
    public partial class ucFood : UserControl
    {
        public ucFood()
        {
            InitializeComponent();
        }
        void LoadFoodtList()
        {
            string query = "select * from Account ";



            dgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {

        }

        private void ucFood_Load(object sender, EventArgs e)
        {

        }
    }
}
