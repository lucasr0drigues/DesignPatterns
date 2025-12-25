using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetState()
        {
            return _state;
        }

        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)}...)";
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}
