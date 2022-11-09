
/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void NumbInDegree (int num, int degree)
{
    for (int i = 1; i < degree; i++)
    {
        num = num * num;
    }
    Console.WriteLine(num);
}
Console.WriteLine("Введите число, которое будет возводится в степень ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
int b = Convert.ToInt32(Console.ReadLine());
NumbInDegree(a,b);
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void SumOfNumsInNum (int number)
{
    int a = 0;
    while (number != 0)
    {
    a = a + number % 10;
    number = number /10;
    }    
    Console.WriteLine(a);
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
SumOfNumsInNum(number);
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int i = 0;
int[] array = new int [8];
while (i != 8)
{
     array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
i = 0;
Console.WriteLine("Вы создали массив:");
while (i != 8)
{
     Console.Write($"{array[i]} ");
     i++;
}
*/
