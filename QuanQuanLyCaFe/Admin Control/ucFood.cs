using QuanQuanLyCaFe.DAO;
using QuanQuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanQuanLyCaFe.Admin_Control
{
    public partial class ucFood : UserControl
    {
        BindingSource foodList = new BindingSource();
        private decimal priceFromDatabase;

        public ucFood()
        {

            InitializeComponent();
            dgvFood.DataSource = foodList;
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
        }
        /*
         * void LoadFoodtList()
         {
             string query = "select * from Account ";



             dgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }*/

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SeachFoodByName(name);

            return listFood;
        }

        private void ucFood_Load(object sender, EventArgs e)
        {

        }
        void AddFoodBinding()
        {
            tbFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            tbFoodid.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            nmFoodPrice.Maximum = 1000000; // 1 triệu
            nmFoodPrice.Value = priceFromDatabase;

        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
           foodList.DataSource = SearchFoodByName(tbSearchFoodName.Text);
        }

        private void tbFoodid_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (dgvFood.SelectedCells.Count > 0)
            {
                    // int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    // Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    object value = dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    if (value != null && int.TryParse(value.ToString(), out int id))
                    {
                        Category category = CategoryDAO.Instance.GetCategoryByID(id);


                        cbFoodCategory.SelectedItem = category;
                        int index = -1;
                        int i = 0;
                        foreach (Category item in cbFoodCategory.Items)
                        {
                            if (item.ID == category.ID)
                            {
                                index = i;
                                break;
                            }
                            i++;

                        }
                        cbFoodCategory.SelectedIndex = index;
                    }
            }
            }
            catch { }
        }



        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = tbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            string name = tbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(tbFoodid.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbFoodid.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá món thành công");
                LoadListFood();
               
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá thức ăn");
            }
        }

        
    }
}
