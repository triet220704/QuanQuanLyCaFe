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
    public partial class UC_Bill : UserControl
    {
        public UC_Bill()
        {
            InitializeComponent();
            LoadListBillByDate(dtpFromDate.Value, dtpTodate.Value);
            LoadDateTimePickerBill();
        }
        #region methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpTodate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillistByDate(checkIn, checkOut);
        }
        #endregion
        #region events
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpFromDate.Value, dtpTodate.Value);
        }
        #endregion
        private void UC_Bill_Load(object sender, EventArgs e)
        {

        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
