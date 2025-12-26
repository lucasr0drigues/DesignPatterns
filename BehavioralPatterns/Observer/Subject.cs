using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Subject : ISubject
    {
        public int State {  get; set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers");

            _observers.ForEach(observer => observer.Update(this));
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important");

            State = new Random().Next(0,10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + State);
            Notify();
        }
    }
}
