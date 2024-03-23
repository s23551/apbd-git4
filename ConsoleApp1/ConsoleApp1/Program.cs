// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Test2");

Console.WriteLine("Test3");

test();

static double Average(int[] ints)
{
    if (ints == null || ints.Length < 1)
    {
        throw new ArgumentException("Input array incorrect");
    }
    double sum = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        sum += ints[i];
    }

    return sum/ints.Length;
}

static double Max(int[] array)
{
    if (array == null || array.Length < 1)
    {
        throw new ArgumentException("Input array incorrect");
    }

    return array.Max();
}

static void test()
{
    int[] ints = { 1, 2, 3, 4, 5, };
    int[] ints1 = { 1, 2 };
    int[] ints2 = { 3 };
    int[] ints3 = { 4,5 };

    Console.WriteLine("Test 1 = " + (Average(ints) == 3));
    Console.WriteLine("Test 2 = " + (Average(ints1) == 1.5));
    Console.WriteLine("Test 3 = " + (Average(ints2) == 3));
    Console.WriteLine("Test 4 = " + (Average(ints3) == 4.5));
    Console.WriteLine("Test 5 = Should be FALSE: " + (Average(ints3) == 17));
    
    Console.WriteLine("Test 6 = " + (Max(ints) == 5));
    Console.WriteLine("Test 7 = " + (Max(ints1) == 2));
    Console.WriteLine("Test 8 = " + (Max(ints2) == 3));
    Console.WriteLine("Test 9 = " + (Max(ints3) == 5));
    Console.WriteLine("Test 10 = Should be FALSE: " + (Max(ints) == 1));
}
