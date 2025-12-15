using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "Concrete Implementation B: The result in platform B \n";
        }
    }
}
