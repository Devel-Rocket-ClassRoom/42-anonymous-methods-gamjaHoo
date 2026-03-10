using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor
{
    internal class DataProcessor
    {
        private int[] data;

        public DataProcessor(int[] source)
        {
            data = source;
        }

        public void ForEach(Action<int> action)
        {
            foreach (int item in data)
            {
                action(item);
            }
        }

        public int[] Transform(Func<int, int> transformer)
        {
            int[] result = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = transformer(data[i]);
            }

            return result;
        }

        public List<int> Filter(Func<int, bool> predicate)
        {
            List<int> result = new List<int>();

            foreach (int item in data)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public int Reduce(Func<int, int, int> reducer, int initialValue)
        {
            int result = initialValue;

            foreach (int item in data)
            {
                result = reducer(result, item);
            }

            return result;
        }
    }
}
