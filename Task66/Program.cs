// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void RecursionNum(int m, int n, int summ)
{
    summ = summ + n;
    if (m >= n)
    {
        Console.WriteLine(summ);
        return;
    }
    RecursionNum (m, n - 1, summ);
}

int m = GetNumber("Введите начальное число: ");
int n = GetNumber("Введите конечное число: ");
RecursionNum(m, n, 0);