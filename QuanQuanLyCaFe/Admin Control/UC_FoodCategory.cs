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
    public partial class UC_FoodCategory : UserControl
    {
        BindingSource CategoryList = new BindingSource();
        public UC_FoodCategory()
        {
            InitializeComponent();
            dgvCategory.DataSource = CategoryList;
            AddCategoryBinding();
            LoadCtegory();
        }
        void AddCategoryBinding()
        {
            TbCategoryId.DataBindings.Clear();
            tbCategoryName.DataBindings.Clear();

            TbCategoryId.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void LoadCtegory()
        {
            CategoryList.DataSource = CategoryDAO.Instance.GetCategory();
        }
        void AddCategory(int id, string categoryName)
        {
            if (CategoryDAO.Instance.InsertCategory(categoryName))
            {
                MessageBox.Show("Thêm loại món thành công");
            }
            else
            {
                MessageBox.Show("Thêm loại món thất bại");
            }
            LoadCtegory();
        }

        void EditCategory(int id, string categoryName)
        {
            if (CategoryDAO.Instance.UpdateCategory(id, categoryName))
            {
                MessageBox.Show("Cập nhật loại món thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật loại món thất bại");
            }
            LoadCtegory();
        }

        void DeleteCategory(int id)
        {
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xoá loại món thành công");
            }
            else
            {
                MessageBox.Show("Xoá loại món thất bại");
            }
            LoadCtegory();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoruShow_Click(object sender, EventArgs e)
        {
            LoadCtegory();
        }

        private void btnCategoruAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TbCategoryId.Text);
            string categoryName = tbCategoryName.Text;
            AddCategory(id, categoryName);
        }

        private void btnCategoruEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TbCategoryId.Text);
            string categoryName = tbCategoryName.Text;
            EditCategory(id, categoryName);
        }
        private void btnCategoruDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TbCategoryId.Text);
            DeleteCategory(id);
        }
    }
}
