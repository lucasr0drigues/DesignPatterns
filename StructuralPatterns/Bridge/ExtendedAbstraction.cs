using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
            
        }

        public override string Operation()
        {
            return "Extended Abstraction: Extended operation with: \n" + _implementation.OperationImplementation();
        }
    }
}
