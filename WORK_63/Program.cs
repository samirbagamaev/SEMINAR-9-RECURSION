// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 6;
void RecN (int number)

{
    if (number == 0) return;

    else RecN(number-1);
    Console.Write($"ЧИСЛО:{number} ");
}

RecN(n);

