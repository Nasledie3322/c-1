
/*task1
int EvenCount(int n)
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



/*task2
int Add(int a, int b)
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


/*task3
int MinDigit(int n)
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



/*task4
int Pow(int x, int y)
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


/*task5
 void swap (ref int a, ref int b)
{
     int cnt = 0;
    cnt = a;
     a = b;
        b = cnt;
    System.Console.WriteLine($"x = {a}");
    System.Console.WriteLine($"y = {b}");
 }

 
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 swap(ref a, ref b);*/



/*task6
void div(int a)
{
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0)
        {
            System.Console.Write(i + " ");
        }
    }   
}
int a = Convert.ToInt32(Console.ReadLine());
div(a);*/




/*task8
int MinNumber(int a, int b, int c, int d)
{
    int minn = a;
    if (b < minn)
        minn = b;
    if (c < minn)
        minn = c;
    if (d < minn)
        minn = d;
    return minn;
}

int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
int c = Convert.ToInt16(Console.ReadLine());
int d = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine(MinNumber(a, b, c, d));*/


/*Task9

void mn(int a, int b)
{
    if (a > b)
        System.Console.WriteLine(b);
    else
        System.Console.WriteLine(a);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
mn(a, b);*/


/*task10
int Max(int a, int b)
{
    int maxx = a;
    if (b > maxx)
        maxx = b;
    return maxx;
}

int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine(Max(a, b));*/