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
    public partial class UC_Table : UserControl
    {
        BindingSource TableList = new BindingSource();
        public UC_Table()
        {
            InitializeComponent();
            dgvTable.DataSource = TableList;
            AddTableBinding();
            LoadTable();
        }
        void AddTableBinding()
        {
            tbTableid.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbNameTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void LoadTable()
        {
            TableList.DataSource = TableDAO.Instance.GetListTable();
        }

        private void UC_Table_Load(object sender, EventArgs e)
        {

        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
        void AddTable(int id, string name)
        {
            if (TableDAO.Instance.InsertTableFood(id, name))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
            LoadTable();
        }

        void EditTable(int id, string name )
        {
            if (TableDAO.Instance.UpdateTableFood(id, name))
            {
                MessageBox.Show("Cập nhật bàn thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại");
            }
            LoadTable();
        }

        void DeleteTable(int id)
        {
            if (TableDAO.Instance.DeleteTableFood(id))
            {
                MessageBox.Show("Xoá bàn thành công");
            }
            else
            {
                MessageBox.Show("Xoá bàn thất bại");
            }
            LoadTable();
        }


        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableid.Text);
            string name = tbNameTable.Text;
            AddTable(id, name);
        }

       

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableid.Text);
            string name = tbNameTable.Text;
           
            EditTable(id, name);
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableid.Text);
            DeleteTable(id);
        }
    }
}
