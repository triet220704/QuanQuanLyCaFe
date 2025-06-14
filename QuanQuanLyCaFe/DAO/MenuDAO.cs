﻿using QuanQuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanQuanLyCaFe.DAO
{
    public class MenuDAO
    {
        private static  MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null)instance =new MenuDAO(); return MenuDAO.instance;}
            private set { MenuDAO.instance = value; } 
        }
        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.name, bi.count, f.Price, f.Price*bi.count AS totalPrice FROM BillInfo AS bi, Bill AS b, Food AS f \r\nWHERE bi.idBill = b.id AND bi.idFood = f.id AND b.Status= 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
