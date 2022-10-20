void Task66()

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
{
    Console.Clear();
    Console.Write("Введите m ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SummNaturalElements(m, n));
}

int SummNaturalElements(int m, int n, int summ = 0)
{
    if (m == n + 1)
    {
        return summ;
    }
    summ = summ + m;
    m++;
    return SummNaturalElements(m, n, summ);
}
