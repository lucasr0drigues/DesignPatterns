using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
