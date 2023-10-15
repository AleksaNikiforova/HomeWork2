int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int PosNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write("Сколько Вы хотите ввести чисел? ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayInt(number);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int posNumbers = PosNumbers(array);
Console.WriteLine($"Количество чисел больше 0: {posNumbers}");