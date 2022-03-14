using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    internal class OldRefrigerator : Product, Classes_interfaces.IDiscont
    {
        public float Discont { set; get; }

        public float OperationDiscount(float x) { return Price - (Price * (x / 100)); }
        public void Print() { Console.WriteLine($"{Name} - {Price} together with {Discont}%");}
        
        public override string ToString() { return $"{Name} - {Price} together with {Discont}%"; }
    }
}
