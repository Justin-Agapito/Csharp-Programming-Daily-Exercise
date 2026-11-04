static class Ex04_GradeClassifier
{
    public static void Run()
    {
        Console.WriteLine("Enter your grade:");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Please enter a grade between 0 - 100");
            }
            else if (grade >= 100)
            {
                Console.WriteLine("Perfect Grade!");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("You have failed this semester, please take a remedial class.");
            }

        }else
            {
                Console.WriteLine("Please enter your exact grade that was given to you.");
            }
    }
}