using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class MemRegDTO
    {
        private int memberid,phone,paid,due;
        private string name,pass,payment,package,validity;

         
        public MemRegDTO(int memberid,string pass, string name, int phone, string payment,string package,int paid,int due,string validity)
        {
            this.memberid = memberid;
            this.name = name;
            this.phone = phone;
            this.pass = pass;
            this.payment = payment;
            this.package = package;
            this.due = due;
            this.paid = paid;
            this.validity = validity;

        }
        public MemRegDTO(int memberid)
        {
            this.memberid = memberid;
        }

        public int memberID
        {
            get { return memberid; }
            set { memberid = value; }
        }
         


        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Payment
        {  
          /* if(Package == 'One Month')
                {
                    set{ payment = 1000; }
                } */

           get { return payment; }
           set { payment = value; }
        }
        
        public string Package
        {
            get { return package; }
            set { package = value; }
        }

        public string Validity
        {
            get { return validity; }
            set { validity = value; }
        }
        public int Paid
        {
            get { return paid; }
            set { paid = value; }

        }
        public int Due
        {
            get { return due; }
            set { due = value; }
        } 
    }
}


    