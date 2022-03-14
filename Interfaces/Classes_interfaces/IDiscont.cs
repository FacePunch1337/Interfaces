using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes_interfaces
{
    internal interface IDiscont
    {
        float Discont { get; set; }
        
        float OperationDiscount(float x);
        void Print();
    }
}
