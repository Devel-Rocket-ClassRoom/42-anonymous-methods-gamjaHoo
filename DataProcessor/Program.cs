using System;
using System.Collections.Generic;

namespace DataProcessor
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            DataProcessor processor = new DataProcessor(numbers);

            Console.WriteLine("=== 원본 배열 출력 ===");
            processor.ForEach(delegate (int n)
            {
                Console.Write(n + " ");
            });

            Console.WriteLine("\n");

            Console.WriteLine("=== 2배로 변환 ===");
            int[] doubled = processor.Transform(delegate (int n)
            {
                return n * 2;
            });

            foreach (var n in doubled)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("=== 짝수만 필터링 ===");
            List<int> evens = processor.Filter(delegate (int n)
            {
                return n % 2 == 0;
            });

            foreach (var n in evens)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("=== 합계 계산 ===");
            int sum = processor.Reduce(delegate (int acc, int n)
            {
                return acc + n;
            }, 0);

            Console.WriteLine("합계: " + sum);
        }
    }
}

