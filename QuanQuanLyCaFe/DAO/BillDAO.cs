﻿using QuanQuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanQuanLyCaFe.DAO
{
   public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }   
        }

        private BillDAO() { }

        public int GetUncheckBillByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id +" AND Status  = 0");
            if (data.Rows.Count > 0 )
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;

            }
            return -1;
         
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE Bill SET Status = 1 WHERE id = "+id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[]{id});
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(id) from Bill");
            }
            catch
            {
                return -1;
            }
        }
    }
}
