static class Ex03_FizzBuzz
{
    public static void Run()
    {
        Console.WriteLine("Enter any amount of number:");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
           int fizzcount = 0;
           int buzzcount = 0;
           int fizzbuzzcount = 0; 
            for (int i = 1; i <= number; i++ )
            {
                if (i % 5 == 0 && i % 3 == 0)
                { fizzbuzzcount++;
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                { fizzcount++;
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                { buzzcount++;
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
                Console.WriteLine($"Total Fizz: {fizzcount}");
                Console.WriteLine($"Total Buzz: {buzzcount}");
                Console.WriteLine($"Total FizzBuzz: {fizzbuzzcount}");
        }
    }
}