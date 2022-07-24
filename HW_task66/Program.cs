// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M - начало списка: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N - конец списка: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int first, int last)
{
    if (first == last) return first;
    else
    {
        return (first + SumNumbers(first+1, last));
    }

}
Console.WriteLine("сумма чисел вашего диапазона = " + SumNumbers(M, N));