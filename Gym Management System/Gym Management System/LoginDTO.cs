using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class LoginDTO
    {
        private int id;
        private string userType, password;
        public LoginDTO(string userType, int id, string password)
        {
            this.userType = userType;
            this.id = id;
            this.password = password;
        }
        public string USERTYPE
        {
            get { return userType; }
            set { userType = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
    }
}
