
/*int EvenCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 == 0)
            count++;
        n /= 10;
    }
    return count;
}

int OddCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 != 0)
            count++;
        n /= 10;
    }
    return count;
}

int DigitCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    return count;
}

int SumDigit(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Even:" + EvenCount(n));
System.Console.WriteLine("Odd:" + OddCount(n));
System.Console.WriteLine("Digit:" + DigitCount(n));
System.Console.WriteLine("Sum:" + SumDigit(n));*/



/*int Add(int a, int b)
{
    return a + b;
}
int Subtract(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}

int Division(int a, int b)
{
    return a / b;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Add:" + Add(a, b));
System.Console.WriteLine("Subtract:" + Subtract(a, b));
System.Console.WriteLine("Multiply:" + Multiply(a, b));
System.Console.WriteLine("Division:" + Division(a, b));*/


/*int MinDigit(int n)
{
    int minn = 9;
    for (int i = n; i > 0; i /= 10)
    {
        int digit = i % 10;
        if (digit < minn)
        {
            minn = digit;
        }
    }
    return minn;
}

int MaxDigit(int n)
{
    int maxx = 0;
    for (int i = n; i > 0; i /= 10)
    {
        int digit = i % 10;
        if (digit > maxx)
        {
            maxx = digit;
        }
    }
    return maxx;
}

int n = Convert.ToInt32(Console.ReadLine());
int sum = MinDigit(n) + MaxDigit(n);
System.Console.WriteLine(MinDigit(n) + " " + "+" + " " + MaxDigit(n) + " " + "=" + " " + sum);*/



/*int Pow(int x, int y)
{
    int sum = 1;
    for (int i = 0; i < y; i++)
    {
        sum *= x;
    }
    return sum;
}
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Pow(x,y));*/