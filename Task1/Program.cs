Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstsecondDigit = number / 10;
int secondDigit = firstsecondDigit % 10;


Console.WriteLine($"Вторая цифра -> {secondDigit}");