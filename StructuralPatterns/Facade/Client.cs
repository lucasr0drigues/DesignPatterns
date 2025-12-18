using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}
