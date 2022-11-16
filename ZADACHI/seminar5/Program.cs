//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] RandomArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    
    }
   return array;
}

void ShowIntArray (int[] array)
{
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
*/
/*
void ShowEvenNumb (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    Console.WriteLine($"Четных чисел в этом массиве: {count}");
}


Console.Write("Введите количество элементов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[] someArray = RandomArray(n, min, max);
ShowIntArray(someArray);
ShowEvenNumb(someArray);
*/



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
void SumNotEvenNumbs (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1 || i == 1)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях: {sum}");
}

Console.Write("Введите количество элементов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[] someArray = RandomArray(n, min, max);
ShowIntArray(someArray);
SumNotEvenNumbs(someArray);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int DiffBetweenMinMaxNumbs (int[] array)
{
    int maxIndex = 0;
    int minIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxIndex]) maxIndex = i;
        if (array[i] < array[minIndex]) minIndex = i;
    }
    int diff = array[maxIndex] - array[minIndex];
    return diff;
}



Console.Write("Введите количество элементов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[] someArray = RandomArray(n, min, max);
ShowIntArray(someArray);
int result = DiffBetweenMinMaxNumbs(someArray);
Console.WriteLine($"Разница между максибальным и минимальным элементом массива: {result}");
*/