/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int funA = A(m, n);

Console.Write($"Функция Аккермана A(m,n)= {funA} ");

int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}