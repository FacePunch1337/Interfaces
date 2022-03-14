using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    internal class OldBook : Product, Classes_interfaces.IPrintable, Classes_interfaces.IDiscont
    {
        public float Discont { get; set; }

        public float OperationDiscount(float x) { return Price - (Price * (x / 100)); }
        public void Print() { Console.WriteLine($"{Name} - {Price} together with {Discont}%  and that ===> [{OperationDiscount(Discont)}]$"); }
    }
}
