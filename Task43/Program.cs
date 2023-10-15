double IntersectionPointX(double kk1, double kk2, double bb1, double bb2)
{
    double x = (bb2 - bb1) / (kk1 - kk2);
    return x;
}

double IntersectionPointY(double kk1, double kk2, double bb1, double bb2)
{
    double y = kk1 * (bb2 - bb1) / (kk1 - kk2) + bb1;
    return y;
}

Console.WriteLine("Введите первую переменную: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую переменную: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью переменную: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите четвёртую переменную: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double intersectionPointX = IntersectionPointX (k1, k2, b1, b2);
double intersectionPointY = IntersectionPointY (k1, k2, b1, b2);

Console.WriteLine($"Точка пересечения прямых -> ({intersectionPointX}; {intersectionPointY})");