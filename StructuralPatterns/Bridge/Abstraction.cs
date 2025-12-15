using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Bridge
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + _implementation.OperationImplementation(); 
        }
    }
}
