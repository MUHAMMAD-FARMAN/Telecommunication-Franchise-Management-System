using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecommunication_Franchise_Management_System.BL
{
    public class sim
    {
        private string number;
        private string type;
        private int price;

        public string Number { get => number; set => number = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }

        public sim(string number , string type , int price)
        {
            this.number = number;
            this.type = type;
            this.price = price;
        }



    }
}
