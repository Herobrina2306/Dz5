// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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

Console.Write("[");
int[] array = GetArray(10, 1, 50);
Console.Write("]");

int Difference(int[] array1)
{
    int i = 0;
    int diff = 0;
    int max = array1[i];
    int min = array1[i];
    foreach(int el in array1)
    {
        if(el > max)
        max = el;

        if(el < min)
        min = el;
    }
    Console.WriteLine();
    Console.Write($"{max} - {min} = ");
    diff = max - min;

    return diff;
}

Console.Write(Difference(array));