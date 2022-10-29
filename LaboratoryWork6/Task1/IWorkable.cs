using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal interface IWorkable<T>
    {
        public T this[int index] { get; set; }
        public int Count { get; }
        public void ForEach(Action<T> action);
        public void Add(T value);
    }
}
