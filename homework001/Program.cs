/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/

Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a ;
int min = b ;

if (a > b ) 
  {
    Console.WriteLine("большее число : " + max);
    Console.WriteLine("Меньшее число : " + min);
  }
  else 
  {
  max = b ;
  min = a ;
  Console.WriteLine("большее число : " + max);
  Console.WriteLine("Меньшее число : " + min);
  }

