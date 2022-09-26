/* Напишите программу, которая принимает на вход число и выдаёт 
количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

// (!) ВАРИАНТ 1 

/* Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр числа {num} = {GetLength(num)}");

int GetLength(int length)
{
    int count = 0;
    for(int temp = length; temp > 0; )
    {
        temp = temp / 10;
        count++;
    }
    return count; 
} */ 

// (!) ВАРИАНТ 2

/* Console.WriteLine("Введите число: ");
string num = Console.ReadLine()!;
Console.WriteLine($"Количество цифр числа {num} = {GetLength(num)}");

int GetLength(string y)
{
    int length = y.Length;
    return length;
} */ 

// (!) ВАРИАНТ 3

Console.WriteLine("Введите число: ");
string num2 = Console.ReadLine()!;
Console.WriteLine($"Количество цифр числа {num2} = {GetLength2(int.Parse(num2))}");

int GetLength2(int x)
{
    return (int)Math.Log10(x)+1;
}