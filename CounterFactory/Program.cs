using System;
namespace CounterFactory
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("=== 단순 카운터 ===");
            var simpleCounter = CounterFactory.CreateSimpleCount();
            for(int i = 0; i < 5; i++)
            {
                Console.Write(simpleCounter() + " ");
            }
            Console.WriteLine();

            var stepCounter = CounterFactory.CreateStepCounter(3);
            Console.WriteLine("=== 스텝 카운터  (step = 3) ===");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(stepCounter() + " ");
            }
            Console.WriteLine();

            var boundedCounter = CounterFactory.CreateBoundedCounter(1,3);
            Console.WriteLine("=== 범위 카운터 (1~3) ===");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(boundedCounter() + " ");
            }  
            Console.WriteLine();

            Console.WriteLine("=== 리셋 가능 카운터 ===");

            CounterFactory.CreateResettableCounter(out Func<int> counter, out Action reset);

            Console.Write("호출: ");
            for (int i = 0; i < 3; i++)
                Console.Write(counter() + " ");

            reset();

            Console.Write("\n리셋 후: ");
            for (int i = 0; i < 2; i++)
                Console.Write(counter() + " ");
        }
    }
}
