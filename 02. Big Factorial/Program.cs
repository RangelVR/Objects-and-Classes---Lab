using System.Numerics;

int n = int.Parse(Console.ReadLine());

BigInteger factorial = 1;

while (n > 0)
{
    factorial *= n;
    n--;
}

Console.WriteLine(factorial);

