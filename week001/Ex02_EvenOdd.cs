static class Ex02_EvenOdd
{
    public static void Run()
    {
        //Main task ODD and EVEN
        //1-20
        for (int x = 0; x < 20; x++)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even number");
            }
            else
            {
                Console.WriteLine($"{x} is odd number");
            }
        }

        //Variation #1
        Console.WriteLine("Enter a number:");
        string? input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal output))
        {
            Console.WriteLine($"{output}");
        }
        else
        {
            Console.WriteLine("your input is not a number, please try again.");
        }
    }
}