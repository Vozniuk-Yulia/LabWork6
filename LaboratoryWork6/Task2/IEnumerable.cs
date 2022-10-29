using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IEnumerable<TKey, TValue>
    {
        IEnumerator GetEnumerator();
    }
}
