/* Напишите цикл, который принимает на
 вход два числа (A и B) и возводит
  число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Input First number = > ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Second number = > ");
int number2 = Convert.ToInt32(Console.ReadLine());

int MakeStepen = (int)Math.Pow(number1 , number2);

Console.WriteLine($"при возведение {number1} в степень {number2} будет {MakeStepen}");





