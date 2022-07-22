/*Задайте значения M и N.
 Напишите программу, которая найдёт сумму 
 натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/

int M = InputNumbers("Введите M(от): ");
int N = InputNumbers("Введите N(до): ");
Console.Write("все натуральные числа в промежутке от M до N:");
Console.WriteLine();
int count = M + 1;
int sum = 0;
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
SumNumber(M, N, count);



void SumNumber(int M, int N, int count)
{
    while (M < N)
    {
        sum = sum + M;
        M++;
        count++;

    }
    Console.WriteLine($"Cумма= {sum - 1}");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}