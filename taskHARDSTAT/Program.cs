// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс,
// минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
// вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что 
// для этого дополнительно выполнить.

//Console.Clear();

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

void SelectSort(decimal[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min_index = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[min_index])
            {
                min_index = j;
            }
        }

        if (array[min_index] == array[i])
            continue;
        
        decimal temp = array[i];
        array[i] = array[min_index];
        array[min_index] = temp;
    }        
}

decimal[] MaxMinAvr(decimal[] array)
{
    decimal max = array[0];
    int max_index = 0;
    decimal min = array[0];
    int min_index = 0;    
    decimal sum = 0;
    decimal avr = 0;
    decimal median = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            max_index = i;
        }

        if (array[i] < min)
        {
            min = array[i];
            min_index = i;
        }

        sum += array[i];
    }

    avr = sum / array.Length;

    SelectSort(array);

    if (array.Length % 2 == 0)
    {
        median = (array[(array.Length / 2) - 1] + array[(array.Length/2)])/2;
    }
    else
    {
        median = array[array.Length / 2];
    }

    decimal[] res = {max, max_index, min, min_index, avr, median};
    return res;
}





decimal[] array = new decimal[6];
FillArray(array);
PrintArray(array);
decimal[] res = MaxMinAvr(array);
PrintArray(array);
Console.WriteLine($"Max element: {res[0]} and his index {res[1]}");
Console.WriteLine($"Min element: {res[2]} and his index {res[3]}");
Console.WriteLine($"Average: {res[4]}");
Console.WriteLine($"Median: {res[5]}");