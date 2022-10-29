using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    internal class MyDictionary<TKey, TValue> : IInteractable<TKey, TValue>, IEnumerable<TKey, TValue>
    {
        int position = -1;
        private TKey[] keys;
        private TValue[] values;
        private int count = 0;
        TValue IInteractable<TKey, TValue>.this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (key.Equals(keys[i]))
                    {
                        index = i;
                    }
                }
                return values[index];
            }
        }
        public int Count
        {
            get { return count; }
        }
        public void Add(TKey key, TValue value)
        {
            count++;
            Array.Resize(ref keys, count);
            keys[count - 1] = key;
            Array.Resize(ref values, count);
            values[count - 1] = value;
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }
        IEnumerator IEnumerable<TKey, TValue>.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public bool MoveNext()
        {
            position++;
            return (position < keys.Length);
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
