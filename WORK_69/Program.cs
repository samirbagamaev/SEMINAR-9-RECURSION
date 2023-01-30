// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int n = 3;
int m = 2;

int Exponentiation(int n, int m)
{
if (m <= 1) return n;

else 
return n * Exponentiation(n, m - 1);

}

Console.WriteLine($"РЕЗУЛЬТАТ: {Exponentiation ( n, m )}");

Exponentiation(m, n);