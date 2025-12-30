using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
