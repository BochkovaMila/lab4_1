using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }

}
