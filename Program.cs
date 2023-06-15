using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть число B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Висновок:");

        for (int i = A; i <= B; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
