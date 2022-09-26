/* Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.*/

// (!) ВАРИАНТ 1 

/* int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    for(int pos = 0; pos < count; pos++)
    {
        Console.Write($"{coll[pos]} ");
    }
}


FillArray(array);
PrintArray(array); */ 


// (!) ВАРИАНТ 2

int[] array = GetArray(8); // Задали массив, обозначили функцией с 8 элементами
Console.WriteLine($"[{String.Join(",", array)}]"); // новая функция вывода (просто ЗАПОМНИТЬ) 

int[] GetArray(int size) // обозначили функцию и её размер
{
    int[] result = new int[size]; // ввела новую переменную-массив, куда буду записывать значения элементов 
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}