using System;

////1
//Calculator calc = Square;
//Console.WriteLine(calc(5));
//static int Square(int x)
//{
//    return x * x; 
//}

//delegate int Calculator(int a);



////2
//Transformer Square = delegate (int x) {  return x * x; };
//Transformer Cube = delegate (int x) { return x * x * x; };

//Console.WriteLine($"3의 제곱: {Square(3)}");
//Console.WriteLine($"3의 세제곱: {Cube(3)}");

//delegate int Transformer(int i);



////3
//Printer printer = delegate (string message) { Console.WriteLine($"[메시지] {message}"); };
//printer("안녕하세요!");
//printer("익명 메서드를 사용 중입니다.");
//delegate void Printer(string s);



////4
//Func<int, int> f = delegate (int x) { return x * 2; };
//Action<string> a = delegate (string msg) { Console.WriteLine($"[LOG] {msg}"); };
//Console.WriteLine(f(10));
//a("작업 시작");



////5
//SimpleDelegate handler = delegate { Console.WriteLine("매개변수를 사용하지 않습니다."); };
//handler(100, "테스트");

//delegate void SimpleDelegate(int i, string s);



////6
//EventHandler onClick = delegate { Console.WriteLine("클릭 이벤트 발생!"); };
//onClick(null, EventArgs.Empty);

//delegate void EventHandler (object sender, EventArgs e);