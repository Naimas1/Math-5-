using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int number2 = int.Parse(Console.ReadLine());
        int start = Math.Min(number1, number2);
        int end = Math.Max(number1, number2);

        Console.WriteLine("Парні числа у вказаному діапазоні:");

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
