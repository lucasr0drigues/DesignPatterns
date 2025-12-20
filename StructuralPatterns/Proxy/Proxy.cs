using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject subject)
        {
            _realSubject = subject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();

                LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Loggin the time of the request");
        }
    }
}
