int[,] CreateRandom2dArray (int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
             array[i,j] = new Random().Next( min, max + 1);
        }
    }
    return array;
}
void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.

void DescendingSort (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1 ; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
  Show2dArray(array);
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] some2dArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(some2dArray);
DescendingSort(some2dArray);
*/
/*
//Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
int LowestSumRow (int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int[] sum = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            int count = 0;
            for(int j = 0; j < array.GetLength(1); j++)
            {
                count += array[i,j];
            }
            sum[i] = count;
            Console.WriteLine($"сумма строки {i} = {count} ");
        }
        int minSumIndex = 0;
        for (int i = 0; i < sum.Length - 1; i++)
        {
            if (sum[i] > sum[i + 1])
                minSumIndex = i + 1; 
        }
        return minSumIndex;
    }
    else Console.WriteLine("ERROR"); return 0;  
}




Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] some2dArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(some2dArray);
int result = LowestSumRow(some2dArray);
Console.WriteLine(result);
*/
/*
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
int[,,] Crate3dArray (int x, int y, int z, int min, int max)
{
    int[,,] array3d = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3d[i,j,k] = new Random().Next(min,max);
            }
        }
    }
    return array3d;
}
void Show3dArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Write("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальое значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,,] myArray = Crate3dArray(x,y,z,minValue,maxValue);
Show3dArray(myArray);
*/

//Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] Create2dSperalArray (int rowsNcolumns)
{
    int[,] array = new int [rowsNcolumns,rowsNcolumns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= rowsNcolumns * rowsNcolumns)   
    {
        array[i,j] = temp;
        temp++;
        if (i<= j + 1 && i + j < rowsNcolumns - 1)
            j++;
        else if (i < j && i + j >= rowsNcolumns - 1)
            i++;
        else if (i >= j && i + j > rowsNcolumns - 1)
        j--;
        else i--;
    }
    return array;
}

Console.Write("ВВедите число столбцов и колонок ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] my2dArray = Create2dSperalArray(n);
Show2dArray(my2dArray);