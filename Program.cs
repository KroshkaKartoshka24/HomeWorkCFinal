// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

class Work
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Recurs(num);
    }
    public static void Recurs(int a)
    {
        if (a > 0)
        {
            Console.Write($"{a} ");
            a = a - 1;
            Recurs(a);
        }
    }
}

