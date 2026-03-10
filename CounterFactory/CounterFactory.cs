using System;
using System.Collections.Generic;
using System.Text;

namespace CounterFactory
{
    internal class CounterFactory
    {
        public static Func<int> CreateSimpleCount()
        {
            int count = 0;
            return delegate { return count++; };
        }
        public static Func<int> CreateStepCounter(int step)
        {
            int count = 0;
            return delegate { return count += step; };
        }

        public static Func<int> CreateBoundedCounter(int min, int max)
        {
            int count = min;
            return delegate
            {
                if(count > max)
                {
                    count = min;
                }
                return count++;
            };
        }

        public static void CreateResettableCounter(out Func<int> counter, out Action reset)
        {
            int count = 0;

            counter = delegate
            {
                return ++count;
            };

            reset = delegate
            {
                count = 0;
            };
        }
    }
}
