using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State < 3)
            {
                Console.WriteLine("Concrete Observer A: Reacted to the event");
            }
        }
    }
}
