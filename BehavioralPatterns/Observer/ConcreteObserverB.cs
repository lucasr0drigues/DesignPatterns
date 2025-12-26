using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("Concrete Observer B: Reacted to the event");
            }
        }
    }
}
