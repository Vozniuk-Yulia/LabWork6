using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MyList<T> : IWorkable<T>
    {
        private T[] array = new T[1];
        private int count = 0;
        private int pos = -1;
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public int Count
        {
            get { return count; }
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }
        public void Add(T item)
        {
            count++;
            Array.Resize(ref array, count);
            pos++;
            array[pos] = item;
        }
        public T[] GetArray(MyList<T> list)
        {
            T[] arr = new T[count];
            Array.Copy(array, arr, count);
            return array;
        }
    }
}
