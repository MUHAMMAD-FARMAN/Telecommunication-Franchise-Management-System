using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecommunication_Franchise_Management_System.BL
{
    public class ComplainClass
    {
        private string complain;
        private string action;

        public string Complain { get => complain; set => complain = value; }
        public string Action { get => action; set => action = value; }

        public ComplainClass()
        {
            Action = "No Action Taken Yet";
        }
        public ComplainClass(string Complan)
        {
            complain = Complan;
            action = "No Action Taken Yet";
        }
        public ComplainClass(string Complan , string Acton)
        {
            complain = Complan;
            action = Acton;
        }

    }
}
