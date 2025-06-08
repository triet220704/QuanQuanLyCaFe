﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanQuanLyCaFe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
           private set { instance = value; } 
        }
        private AccountDAO() { }
        public bool login(string username, string password)
        {
            string query = "USP_Login @userName , @password ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});

            return result.Rows.Count >0;
        }
    }   
}
