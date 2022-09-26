/* Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4  -> 24
5  -> 120*/


Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до N = {MultiplyNum(N)}");

int MultiplyNum(int limit)
{
    int multiply = 1;
    for(int i = 1; i <= limit; i++)
    {
        multiply = multiply * i;
    }
    return multiply;
}

