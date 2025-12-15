using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "Concrete Implementation A: The result in platform A \n";
        }
    }
}
