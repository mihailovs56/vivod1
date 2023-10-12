using System;
using System.Runtime.InteropServices;

class programm
{
    static void Main()
    {
        Console.WriteLine("Введите число до 1000: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= a; i++)
        {
            Console.WriteLine(i);
        }
    }
}