//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");

int length = int.Parse(Console.ReadLine());

int[] array = GenerateArray(length);

PrintArray(array);

Console.WriteLine($"Сумма не четных элементов массива равна {Summa(array)}");

int[] GenerateArray(int length)
{
    int[] array = new int[length]; 
    
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 10);
    }
     return array;
}

int Summa (int[] array)

{
    int a = 0;

    for (int i = 0; i < array.Length; i = i + 2)
    {
        a = a + array[i];
    }
    return a;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}

