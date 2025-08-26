using QuanQuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanQuanLyCaFe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; } 
        }

        public static int Tablewidth { get; internal set; }

        public static int TableWidth = 110;
        public static int TableHeight = 110;
        private TableDAO() { }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public DataTable GetListTable()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from TableFood");
        }
        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("UPS_GETTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }

            return tablelist;
        }
        public bool InsertTableFood(int id, string name)
        {
            string query = string.Format("INSERT INTO TableFood (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateTableFood(int id, string name)
        {
            string query = string.Format("UPDATE TableFood SET name = N'{0}' WHERE id = {2}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTableFood(int id)
        {
            string query = string.Format("DELETE FROM TableFood WHERE id = {0}", id );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
