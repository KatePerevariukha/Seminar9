int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int SumNbr (int m, int n)
{
    Console.WriteLine($"{m}, {n}");
    if (m == n) return n;
    else n += SumNbr (m, n-1);
    return n;
}

int m = InputNum ("Введите число M: ");
int n = InputNum ("Введите число N: ");
Console.Write ($"Сумма чисел от {m} до {n} = {SumNbr (m, n)}");