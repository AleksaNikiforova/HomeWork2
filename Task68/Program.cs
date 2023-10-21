int FunctionAkkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return FunctionAkkerman(num1 - 1, 1);
    else return FunctionAkkerman(num1 - 1, FunctionAkkerman(num1, num2 - 1));
}

Console.WriteLine(FunctionAkkerman(3, 11));