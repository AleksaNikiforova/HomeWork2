void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) NaturalNumbers(n);
else Console.WriteLine("Ошибка ввода");