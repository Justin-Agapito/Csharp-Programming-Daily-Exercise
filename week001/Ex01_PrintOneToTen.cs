static class Ex01_PrintOneToTen
{
    public static void Run()
    {
        // int max = int.MaxValue;
        
        //count forward
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        //count backwards
        for (int s = 10; s >= 0; s--)
        {
           Console.WriteLine(s); 
        }
    }
}