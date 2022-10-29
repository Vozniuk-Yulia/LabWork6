using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IInteractable<TKey, TValue>
    {
        public void Add(TKey key, TValue value);
        public TValue this[TKey index]
        {
            get;
        }
        public int Count { get; }
    }
}
