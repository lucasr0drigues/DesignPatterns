using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;

namespace Strategy
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
