//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");

int length = int.Parse(Console.ReadLine());

int[] array = GenerateArray(length);

PrintArray(array);

Console.WriteLine($"Количество четных чисел в масиве равно {count(array)}");

int[] GenerateArray(int length)
{
    int[] array = new int[length]; 
    
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
     return array;
}

int count (int[] array)
{
    int a = 0;

    for(int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2 == 0)
         {
            a = a + 1;
         }
    }
    return a;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}