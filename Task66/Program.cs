int SumElemInInterval(int num1, int num2)
{
    if(num1 == num2)
    {
        return num1;
    }
    else if(num1 > num2)
    {
        if(num1 == num2) return 0;
        else return num1 + SumElemInInterval(num1 - 1, num2);
    }
    else
    {
        if(num1 == num2) return 0;
        else return num1 + SumElemInInterval(num1 + 1, num2);     
    }
} 

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumElemInInterval(m, n));