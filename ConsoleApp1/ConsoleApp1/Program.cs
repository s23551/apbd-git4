// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Test2");

Console.WriteLine("Test3");

test();

static double Average(int[] array)
{
    if (array == null || array.Length < 1)
    {
        throw new ArgumentException("Input array incorrect");
    }
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum/array.Length;
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
}
