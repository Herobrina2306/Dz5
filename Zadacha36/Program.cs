// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int[] array = GetArray(10, -20, 20);

int SumOddNambers(int[] array1)
{
    int sum = 0;
    for(int i = 1; i < array1.Length; i = i+ 2)
    {
        sum = sum + array1[i];
    }
    return sum;
}

Console.Write($" -> {SumOddNambers(array)}");