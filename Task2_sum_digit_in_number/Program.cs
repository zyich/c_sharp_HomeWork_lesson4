/* Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber (string description)
    {
        int number;
        Console.WriteLine($"{description} => ");
        while (true)
        {
            string temp = Console.ReadLine();
            if(int.TryParse(temp, out number))
            {
                return number;
            }
            Console.Write($"This number \"{temp}\" is not correct. Try again =>");
        }
    }

int SumDigit (int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + (num%10);
        num = num / 10;
    }
    return result;
    }
int number = GetNumber("input number");
Console.WriteLine($"{SumDigit(number)}");
