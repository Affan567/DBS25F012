using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll.BL
{
    public class Login
    {
        protected int user_id;
        protected string username;
        protected string password;
        protected int role_id;

        public string GetUserRole(string query)
        {
            object role = DatabaseHelper.ExecuteScalar(query);
            return role.ToString();
        }

        public int GetUserID(string query)
        {
            object ID = DatabaseHelper.ExecuteScalar(query);
            return (int)ID;
        }



    }
}
