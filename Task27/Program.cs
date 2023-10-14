int SumDigitInNumber(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigitInNumber = SumDigitInNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sumDigitInNumber}");