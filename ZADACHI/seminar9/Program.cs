
/*
//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

void NumbersBefore (int n)
{

    Console.Write(n + " ");
    if (n > 1)
        NumbersBefore(n - 1); 
    
}
NumbersBefore(5);
*/
/*
//Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов
// в промежутке от M до N
int SumBetween(int m, int n)
{
    if (m == n) return m;
    if (n > m) return SumBetween(m, n - 1) + n ;
    else return SumBetween(n, m - 1) + m;
   
}
Console.WriteLine(SumBetween(1,3));
*/

/*
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int A (int m, int n)
{
if (m == 0) return n + 1;
if (m != 0 && n == 0) return A(m - 1, 1);
if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
return A(m,n);    
}
Console.Write(A(2,3));
*/