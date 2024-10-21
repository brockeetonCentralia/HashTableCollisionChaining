using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableCollisionChaining
{
    internal class HashTable<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>>[] buckets;
        private int size;

        public HashTable(int size)
        {
            this.size = size;
            buckets = new List<KeyValuePair<TKey, TValue>>[size];

            for (int i = 0; i < size; i++)
            {
                buckets[i] = new List<KeyValuePair<TKey, TValue>>();
            }
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }

        public void Insert(TKey key, TValue value)
        {
            int hash = GetHash(key);
            buckets[hash].Add(new KeyValuePair<TKey, TValue>(key, value));
        }
        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Bucket " + i + ": ");
                foreach (var pair in buckets[i])
                {
                    Console.Write($"[{pair.Key}, {pair.Value}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
