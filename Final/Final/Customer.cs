using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Customer
    {
        string name;

        public Customer()
        {
            name = "";
        }

        public Customer(string _name)
        {
            Name = _name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
    }
}
