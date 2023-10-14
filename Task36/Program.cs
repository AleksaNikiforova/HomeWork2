int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

// int SumOddElemInArray(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i ++)
//     {
//         if (i % 2 != 0) sum += arr[i];
//     }
//     return sum;
// }

int SumOddElemInArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i +=2)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(8, 0, 10);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int sumOddElemInArray = SumOddElemInArray(array);
Console.WriteLine($"Сумма нечётных элементов -> {sumOddElemInArray}");
