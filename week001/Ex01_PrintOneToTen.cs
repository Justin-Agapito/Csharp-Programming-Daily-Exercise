static class Ex01_PrintOneToTen
{
    public static void Run()
    {
        // int max = int.MaxValue;
        
        //Main Task
        //count forward
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        //Variation #1
        //Odd numbers
        for (int x = 0; x < 20; x++)
        {
            if (x % 2 == 1)
            // {
            //     Console.WriteLine($"{x} is even number");
            // }
            // else
            {
                Console.WriteLine($"{x} is odd number");
            }
        }

        //Variation #2
        //count backwards
        for (int s = 10; s >= 0; s--)
        {
           Console.WriteLine(s); 
        }

        //Variation #3



    }
}