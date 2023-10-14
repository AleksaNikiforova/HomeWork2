double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max-min) + min; 
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double nRound = Math.Round(arr[i], 1);
        if(i < arr.Length - 1) Console.Write($"{nRound}, ");
        else Console.Write($"{nRound}");
    }
}

double FindMaxDigit(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i ++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double FindMinDigit(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i ++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(8, 1.22, 10.1);
Console.Write("[");
PrintArray(array);
Console.Write("] => ");

double maxDigit = FindMaxDigit(array);
double minDigit = FindMinDigit(array);
double diff = maxDigit - minDigit;

Console.WriteLine($"{maxDigit:F1} - {minDigit:F1} = {diff:F1}");
