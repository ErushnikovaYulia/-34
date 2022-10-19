// Задайте массив заполненный случайными положительными  трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int GetNum(int[] array)
{
    int get = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            get++;
        
        }
    }
    return get;
    
Console.WriteLine($"Количество четных элементов: {get}" );
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int N = Int16.Parse(Console.ReadLine()!);

int[] arr = GetArray(N);
GetNum(arr);
Console.WriteLine(String.Join(",", arr));


