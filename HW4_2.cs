int Digits (int num)
{
    var result = 0;
     while (num > 0)
    {
         result = result + num%10;
         num = num/10;
    }
     return result;
}
Console.WriteLine ("Сумма цифр в числе N");
Console.WriteLine ("Введите число N");

if (int.TryParse(Console.ReadLine()!, out var number))
{
  if (number < 0)
        return;
    var result = Digits (number);
    Console.WriteLine (result);
}

 else {Console.WriteLine ("Введено не число!");}
