// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// class Work
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         Recurs(num);
//     }
//     public static void Recurs(int a)
//     {
//         if (a > 0)
//         {
//             Console.Write($"{a} ");
//             a = a - 1;
//             Recurs(a);
//         }
//     }
// }

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

class Work
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (m < n)
        Console.WriteLine($"Сумма всех натуральных чисел в промежутке от {m} до {n} равна: {SumBetween(m, n)}");
        else 
        Console.WriteLine($"Сумма всех натуральных чисел в промежутке от {m} до {n} равна: {SumBetween(n, m)}");
    }
    public static int SumBetween(int a, int b)
    {
        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
        return sum;
    }
}