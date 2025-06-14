using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanQuanLyCaFe.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count) 
        { 
            this.ID = id;
            this.BillId = billID;
            this.FoodID = foodID;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillId = (int)row["idbill"];
            this.FoodID = (int)row["idfood"];
            this.Count = (int)row["count"];
        }
        private int count;
        public int Count 
        {
            get { return count; }
            set { count = value; } 
        }
        private int foodID;
        public int FoodID {
            get { return foodID; }
            set { foodID = value; }
        }
        private int billId;
        public int BillId 
        {
            get { return billId; }
            set { billId = value; }
        }
        private int iD;

        public int ID 
        {
            get { return iD; }
            set { iD = value; } 
        }

        
    }
}
