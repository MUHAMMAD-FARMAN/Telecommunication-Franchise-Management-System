using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecommunication_Franchise_Management_System.BL
{
    internal class Admin : MUser
    {
        public Admin(string name , string password) : base(name, password, "Admin")
        {}
            
        
    }
}
