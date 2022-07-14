using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecommunication_Franchise_Management_System.BL
{
    public class MUser
    {
        private string name;
        private string password;
        private string role;
        private string phoneNum;
        private string cnic;
        private int balance;
        private int emoney;
        private List<sim> sims;


        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public int Balance { get => balance; set => balance = value; }
        public int Emoney { get => emoney; set => emoney = value; }
        internal List<sim> Sims { get => sims; set => sims = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Cnic { get => cnic; set => cnic = value; }

        public MUser(string name, string password, string role , string phoneNum , string cnic)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            this.phoneNum = phoneNum;
            this.cnic = cnic;
        }

        public MUser(string name, string password, string role, string phoneNum, string cnic , int balance , int emoney)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            this.phoneNum = phoneNum;
            this.cnic = cnic;
            this.balance = balance;
            this.emoney = emoney;
        }


        public MUser(string name, string password)
        {
            this.name = name;
            this.password = password;
            role = "NA";
           
        }

        public MUser(string name, string password , string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;

        }
        public bool isAdmin()
        {
            if (role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
