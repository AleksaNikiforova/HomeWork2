int RaiseToDegree (int num, int deg)
{
    int count = 0;
    int multiple = 1 * num;
    while (count < deg - 1)
    {
        multiple = multiple * num;
        count ++;
    }
    return multiple;
}    

Console.WriteLine("Введите целое число, которое надо возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число, которое обозначает степень, в которую надо возвести предыдущее число: ");
int degree = Convert.ToInt32(Console.ReadLine());

int raiseToDegree = RaiseToDegree (number, degree);
Console.WriteLine($"Число {number}, возведённое в степень {degree} равно {raiseToDegree}");

