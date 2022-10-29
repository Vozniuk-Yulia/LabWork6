using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IEnumerator<TKey, TValue>
    {
        public bool MoveNext();
        public object Current();
        public void Reset();
    }
}
