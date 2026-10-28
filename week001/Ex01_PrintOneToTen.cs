static class Ex01_PrintOneToTen
{
    public static void Run()
    {
        // // int max = int.MaxValue;
        
        // //Main Task
        // //count forward
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // //Variation #1
        // //Odd numbers
        // for (int x = 0; x <= 20; x++)
        // {
        //     if (x % 2 == 1)
        //     // {
        //     //     Console.WriteLine($"{x} is even number");
        //     // }
        //     // else
        //     {
        //         Console.WriteLine($"{x} is odd number");
        //     }
        // }

        // //Variation #2
        // //count backwards
        // for (int s = 10; s >= 0; s--)
        // {
        //    Console.WriteLine(s); 
        // }

        //Variation #3
        Console.WriteLine("Enter the a number you want to multiply up to 10:");
        string? inputNumber = Console.ReadLine();
        if (int.TryParse(inputNumber, out int number))
        {
            for (int x = 1; x <= 10; x++) 
            {
                Console.WriteLine($"{number}*{x} = {number * x}");
            }
        }
        else
        {
            Console.WriteLine("Please input a number instead");
        }

    }
}