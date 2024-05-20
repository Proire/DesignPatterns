using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class Employee
    {
        public required string Name { get; set; }
        public required string Department { get; set; }

        public Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to Employee type
            return (Employee)this.MemberwiseClone();
        }
    }
}
