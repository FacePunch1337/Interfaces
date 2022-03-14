using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    class Product
    {
        private String _name;
        private float _price;

        public String Name 
        {
            set { _name = value; }
            get { return _name; }
        }
        public float Price 
        {
            set { _price = value; }
            get { return _price; }
        }

        public override string ToString() { return $"{_name} - {_price}$"; }
    }
}
