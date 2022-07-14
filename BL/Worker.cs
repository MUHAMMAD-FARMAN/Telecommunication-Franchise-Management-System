using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecommunication_Franchise_Management_System.BL
{
    public class Worker : MUser
    {
        private int requestedBalanceAmount;
        private int requestedEmoneyAmount;
        public Worker(string name, string password) : base(name , password )
        {
            Role = "Worker";
            requestedBalanceAmount = 1000;
            requestedEmoneyAmount = 1000;
        }
        public Worker(string name , string password , string phoneNum , string cnic) : base(name , password , "Worker" , phoneNum , cnic)
        {
            requestedBalanceAmount = 1000;
            requestedEmoneyAmount = 1000;
        }
        public Worker(string name, string password, string phoneNum, string cnic , int balance ,int emoney) : base(name, password, "Worker", phoneNum, cnic , balance ,emoney)
        {
            requestedBalanceAmount = 1000;
            requestedEmoneyAmount = 1000;

        }

        public int RequestedBalanceAmount { get => requestedBalanceAmount; set => requestedBalanceAmount = value; }
        public int RequestedEmoneyAmount { get => requestedEmoneyAmount; set => requestedEmoneyAmount = value; }
    }
}
