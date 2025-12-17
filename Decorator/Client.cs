using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("Result: " + component.Operation());
        }
    }
}
