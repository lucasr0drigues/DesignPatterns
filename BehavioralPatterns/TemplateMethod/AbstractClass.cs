using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperations2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("Abstract Class: I'm doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("Abstract Class: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("Abstract Class: But I'm doing the bulk of the work anyway");
        }

        protected abstract void RequiredOperations1();

        protected virtual void Hook1()
        {

        }

        protected virtual void Hook2()
        {

        }

        protected abstract void RequiredOperations2();
    }
}
