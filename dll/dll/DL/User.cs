﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dll.DL
{
    public class User
    {

        static public DataTable GetAllUsers()
        {
            string query = "Select * From users";
            DataTable usersTable = DatabaseHelper.getDataTable(query);
            return usersTable;
        }

        static public bool DeleteUserFromDB(int UserId)
        {
            string query = "Delete From users Where UserID = {UserId}";
            int rowsAffected = DatabaseHelper.executeDML(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static get

         public static bool AddUsertoDB(string Password, string Username, string Email, string Phone,string Name , int roleID,string gender)
        {
            

            string insertusersquery = "$Insert into users (username , password ,role_id ,name,email,contact,Gender) Values ('{0}' , '{1}' ,'{2}' , '{3}','{4}','{5}','{6}')";
           insertusersquery = String.Format(insertusersquery ,Username ,Password ,roleID, Name,Email,Phone,gender);
            int rowsaffected2 = DatabaseHelper.executeDML(insertusersquery);
            return rowsaffected2 > 0;
            


        }
        public string GetUserRoleFromDB(string username, string Password)
        {
            string query = "Select RoleName From roles as r join users as u on r.role_id = u.role_id Where username = '{0}' AND password = '{1}'";
            query = String.Format(query, username, Password);
            object role = DatabaseHelper.ExecuteScalar(query);
            return role.ToString();
        }

        public int GetUserIDFromDB(string username, string Password)
        {
            string query = "Select UserID From users Where username = '{0}'AND password = '{1}'";
            query = String.Format(query, username, Password);
            object ID = DatabaseHelper.ExecuteScalar(query);
            return (int)ID;
        }

        static public bool UpdateUsertoDB(int UserID, string Password, string Username, string Email,string Phone, string Name)
        {
            string updateQuery = "UPDATE users SET password = '{0}',username = '{1}', password = '{2}' ,Email = '{3}', Phone = '{4}',Name = '{5}' Where UserID = {6}";
            updateQuery = String.Format(updateQuery, Username, Password, Email, Phone,  Name);
            int rowsAffected = DatabaseHelper.executeDML(updateQuery);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }



    }
}
