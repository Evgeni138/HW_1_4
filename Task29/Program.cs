Console.WriteLine("Введите количество элементов массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите по очереди {a} элементов массива");
void createArray(int[] array)
{
    for (int i = 0; i < a; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void printArray(int[] array1)
{
    for (int j = 0; j < a; j++)
    {
        Console.Write($"{array1[j]} ");
    }
}
int[] arr = new int[a];
createArray(arr);
Console.WriteLine("Массив:");
printArray(arr);