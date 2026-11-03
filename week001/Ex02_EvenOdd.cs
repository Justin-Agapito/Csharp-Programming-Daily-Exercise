static class Ex02_EvenOdd
{
    public static void Run()
    {
        //Main task ODD and EVEN
        //1-20
        // for (int x = 1; x <= 20; x++)
        // {
        //     if (x % 2 == 0)
        //     {
        //         Console.WriteLine($"{x} is even number");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{x} is odd number");
        //     }
        // }

        // //Variation #1
        Console.WriteLine("Enter a number:");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int output))
        {
            if (output % 2 == 0)
            {
                Console.WriteLine($"{output} is even number"); 
            }
            else
            {
                Console.WriteLine($"{output} is odd number");
            }
        }
        else
        {
            Console.WriteLine("your input is not a number, please try again.");
        }

    }
}