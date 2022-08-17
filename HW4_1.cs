Console.Clear();
Console.WriteLine ("Возведение числа A в натуральную степень B");

Console.WriteLine ("Введите число A");
int A = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Введите число B");
int B = int.Parse(Console.ReadLine ()!);

var result = Math.Pow (A, B);
Console.WriteLine ("{0:0.00.000}", result);