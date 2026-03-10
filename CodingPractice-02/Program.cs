using System;

////1
//Calculator calc = delegate (int x) { return x * x; };
//Console.WriteLine(calc(5));

//delegate int Calculator(int i);



////2
//int factor = 3;
//Func<int, int> multiplier = delegate (int n) {  return n * factor; };
//Console.WriteLine(multiplier(10));



////3
//int factor = 2;
//Func<int, int> multiplier = delegate (int n) { return n * factor; };
//Console.WriteLine($"factor = 2일 때: {multiplier(5)}");
//factor = 10;
//Console.WriteLine($"factor = 10일 때: {multiplier(5)}");



////4
//int counter = 0;
//Action increment = delegate { counter++; Console.WriteLine($"현재 카운터: {counter}"); };
//increment();
//increment();
//increment();
//Console.WriteLine($"최종 카운터: {counter}");



////5
//var counter1 = CreateCounter();
//var counter2 = CreateCounter();
//Console.WriteLine($"counter1: {counter1()}");
//Console.WriteLine($"counter1: {counter1()}");
//Console.WriteLine($"counter1: {counter1()}");
//Console.WriteLine($"counter2: {counter2()}");
//Console.WriteLine($"counter2: {counter2()}");
//static Func<int> CreateCounter()
//{
//    int count = 0;
//    return delegate
//    {
//        count++;
//        return count;
//    };
//}