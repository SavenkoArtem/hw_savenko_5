// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

Console.Clear();

void FillArray(decimal[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
}

void PrintArray(decimal[] array)
{
    foreach (decimal item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

decimal DifferenceMaxMin(decimal[] array)
{
    decimal max = array[0];
    decimal min = array[0];
    decimal difference = 0;

    foreach (decimal item in array)
    {
        if (item > max)
        {
            max = item;
        }

        if (item < min)
        {
            min = item;
        }
    }

    difference = max - min;
    return difference;
}




decimal[] array = new decimal[4];
FillArray(array);
PrintArray(array);
Console.WriteLine(DifferenceMaxMin(array));