//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");

int length = int.Parse(Console.ReadLine());

double[] array = GenerateArray(length);

PrintArray(array);

Console.WriteLine($"Максимальный элемент массива равен {MaxNumber(array)}");

Console.WriteLine($"Минимальный элемент массива равен {MinNumber(array)}");

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MaxNumber(array) - MinNumber(array)}");

double[] GenerateArray(int length)
{
    double[] array = new double[length];

    Random random = new Random();

    for (int i = 0; i< length; i++) 
    {
        array[i] = random.Next(0, 10);
    }

    return array;
}

double MinNumber (double[] array)
{
    double min = 1;

    for(int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double MaxNumber (double[] array)
{
    double max = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

void PrintArray(double[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}