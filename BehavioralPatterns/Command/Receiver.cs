using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Receiver
    {
        public void DoSomething(string objectA)
        {
            Console.WriteLine($"Receiver: Working on ({objectA})");
        }

        public void DoSomethingElse(string objectB)
        {
            Console.WriteLine($"Receiver: Also working on ({objectB})");
        }
    }
}
