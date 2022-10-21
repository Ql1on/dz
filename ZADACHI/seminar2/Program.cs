
/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void SecondDigitOfThreeDigitNumber(int a)
{
    int result = a % 100 /10;
    Console.WriteLine($"Вторая цифра из трехзначного числа: {result}");
} 
Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
SecondDigitOfThreeDigitNumber(threeDigitNumber);
*/


/*
void ThirdNumb(int a)
{
    if ( a > 99 && a < 1000)
    {
        int result = a % 10;
        Console.WriteLine(result);
    }
    else if (a > 999 && a < 10000)
    {
        int result = a / 10 % 10;
        Console.WriteLine(result);
    }
    else Console.WriteLine("ERROR");
    
}
int number = Convert.ToInt32(Console.ReadLine());
ThirdNumb(number);
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string DaysOfWeek(int number)
{
    if (number > 0 && number < 6) return "не выходной";
    else if (number > 5 && number < 8) return "выходной)";
    else return "ERROR";
}


int a = Convert.ToInt32(Console.ReadLine());
string result = DaysOfWeek(a);
Console.WriteLine(result);
*/