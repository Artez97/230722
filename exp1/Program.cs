/*
Задача 64: Задайте значения M и N.
 Напишите программу, которая выведет все натуральные числа
  в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/

int M = InputNumbers("Введите M(от): ");
int N = InputNumbers("Введите N(до): ");
Console.Write("все натуральные числа в промежутке от M до N:");
Console.WriteLine();
int count = M + 1;
PrintNumber(M, N, count);



void PrintNumber(int M, int N, int count)
{
    while (M < N - 1)
    {
        Console.WriteLine(count);
        M++;
        count++;
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}