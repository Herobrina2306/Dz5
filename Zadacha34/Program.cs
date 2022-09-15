// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(10, 100, 999);

int EvenNumbers(int[] array1)
{
    int kol = 0;
    foreach(int el in array1)
    {
        if (el%2 == 0)
        kol++;
    }

    return kol;
}

Console.Write($" -> {EvenNumbers(array)}");