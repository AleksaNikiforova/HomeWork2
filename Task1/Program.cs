Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >=1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста, повторите ввод");
    return;
}

Console.WriteLine($"Введённое число -> {number}");

int firstsecondDigit = number / 10;
int secondDigit = firstsecondDigit % 10;


Console.WriteLine($"Вторая цифра -> {secondDigit}");