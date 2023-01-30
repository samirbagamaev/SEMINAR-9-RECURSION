// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

const int numberSum = 453;

int SumNumber (int N)
{
    int sum = 0;
    if (N == 0) return 0;

    else
    {
        sum = N % 10 + SumNumber(N / 10);
    }
    return sum;
}

Console.WriteLine($"РЕЗУЛЬТАТ: {SumNumber(numberSum)}");