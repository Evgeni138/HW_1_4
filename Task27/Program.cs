int sum(int number)
{   
    int resault = 0;
    while (number > 0) 
    {
        resault = resault + number % 10;
        number /= 10;
    }
    return resault;
}
System.Console.WriteLine("452 -> " + sum(452));
System.Console.WriteLine("82 -> " + sum(82));
System.Console.WriteLine("9012 -> " + sum(9012));