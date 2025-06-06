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

namespace QuanQuanLyCaFe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            
        }
       
        
            

           
        
        private void fAdmin_Load(object sender, EventArgs e)
        {
            uC_Bill1.Visible = false;
            ucFood1.Visible = false;
            uC_FoodCategory1.Visible = false;
            ucFood1.Visible = false;
            uC_Account1.Visible = false;
            uC_Spending1.Visible = false;
            uC_Warehouse1.Visible = false;
            btnBill.PerformClick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managercs manager = new Managercs();
            manager.ShowDialog();
            this.Close();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnBill.Left + 20;
            uC_Bill1.Visible = true;
            uC_Bill1.BringToFront();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnFood.Left + 30;
            ucFood1.Visible = true;
            ucFood1.BringToFront();
        }

        private void uC_Bill1_Load(object sender, EventArgs e)
        {

        }

        private void btnFoodeCategory_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnFoodeCategory.Left + 30;
            uC_FoodCategory1.Visible = true;
            uC_FoodCategory1.BringToFront();
        }

        private void panelMoving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnTable.Left + 30;
            uC_Table1.Visible = true;
            uC_Table1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnAccount.Left + 30;
            uC_Account1.Visible = true;
            uC_Account1.BringToFront();
        }

        private void uC_Account1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panelMoving.Left = btnSp.Left + 30;
            uC_Spending1.Visible = true;
            uC_Spending1.BringToFront();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnWarehouse.Left + 30;
            uC_Warehouse1.Visible = true;
            uC_Warehouse1.BringToFront();
        }
    }
}
