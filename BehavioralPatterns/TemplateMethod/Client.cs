using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Client
    {
        public static void ClientCode(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }
}
