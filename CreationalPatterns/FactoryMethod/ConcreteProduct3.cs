using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ConcreteProduct3 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct3}";
        }
    }
}
