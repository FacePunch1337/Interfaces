using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    internal class Book : Product, Classes_interfaces.IPrintable
    {
        public void Print() { Console.WriteLine($"The Book: {Name}"); }
    }
}
