using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecommunication_Franchise_Management_System.BL
{
    public class Customer : MUser
    {

       
       
        public Customer(string name , string password) : base(name , password , "Customer")
        {
    
        }
       
        public Customer(string name, string password, string phoneNum , string cnic): base(name , password , "Customer")
        {
            this.PhoneNum = phoneNum;
            this.Cnic = cnic;

        }
        public Customer(string name, string password, string phoneNum, string cnic, int balance, int emoney) : base(name, password, "Customer", phoneNum, cnic, balance, emoney)
        {
            this.PhoneNum = phoneNum;
            this.Cnic = cnic;
            this.Balance = balance;
            this.Emoney = emoney;
        }
      

    }
}
