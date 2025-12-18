using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Subsystem1
    {
        public string Operation()
        {
            return "Subsystem1: Ready \n";
        }

        public string OperationN()
        {
            return "Subsystem1: Go \n";
        }
    }
}
