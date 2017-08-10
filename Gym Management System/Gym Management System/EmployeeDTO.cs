using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class EmployeeDTO
    {
        private int employeeid, phone, salary;
        private string employeename,passw,joiningDate,position;


        public EmployeeDTO(string employeename,int employeeid, string passw,   int phone, string joiningDate, string position, int salary)
        {
            this.employeeid = employeeid;
            this.employeename = employeename;
            this.phone = phone;
            this.passw = passw;
            this.salary = salary;
            this.joiningDate = joiningDate;
             
            this.position = position;

        }
        public EmployeeDTO(int employeeid)
        {
            this.employeeid = employeeid;
        }

        public int Employeeid
        {
            get { return employeeid; }
            set { employeeid = value; }
        }



        public string NAME
        {
            get { return employeename; }
            set { employeename = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Pass
        {
            get { return passw; }
            set { passw = value; }
        }
        public int Salary
        {
             

            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }
        
    }
}
