int degree(int a, int b)
{
    int resault = a;
    for (int i = 1; i < b; i++)
    {
        resault = resault * a;
    }
    return resault;
}

System.Console.WriteLine("3, 5 -> " + degree(3, 5));
System.Console.WriteLine("2, 4 -> " + degree(2, 4));