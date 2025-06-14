﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanQuanLyCaFe.DTO
{
    public class Bill
    {
        private Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status) 
        { 
            this.ID=id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "") 
            this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["status"];
        }
        private int status;
        public int Status 
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }          
        }
        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; } 
            set { dateCheckOut = value; }
        }
        private int iD;
      

        public int ID
        {
            get { return iD; }
            set { iD = value; }

        }
    }
}
