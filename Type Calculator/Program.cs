class TypeCalculator
{
    static void Main(string[] args)
    {
        int decision;
        double num1, num2, sum = 0;
        string word;
        string equal = " is equal to ";
        Console.Title = "Type Calculator";
        Console.Write("\nWelcome to Type Calculator!");
    Loop:
        try
        {
            Console.Write("\nType \"1\" for addiction, \"2\" for substraction, \"3\" for multiplication, \"4\" for division, \"5\" for square root and \"6\" for grading. \nEnter here: ");
            decision = int.Parse(Console.ReadLine());
            if (decision == 1 || decision == 2 || decision == 3 || decision == 4)
            {
                Console.Write("\nEnter your first number: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter your second number: ");
                num2 = double.Parse(Console.ReadLine());
            }
            else if (decision == 6)
            {
                Console.Write("\nEnter your number: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the grade: ");
                num2 = double.Parse(Console.ReadLine());
                for (int i = 0; i < num2; i++)
                {
                    sum += num1 * num1;
                }
            }
            else if(decision == 5)
            {
                Console.Write("\nEnter your number: ");
                num1 = int.Parse(Console.ReadLine());
                num2 = 0;
            }
            else
            {
                Console.WriteLine("You didn\'t enter a valid number.");
                num1 = 0; num2 = 0;
            }
            switch (decision)
            {
                case 1:
                    sum = num1 + num2;
                    word = " plus ";
                    Console.WriteLine(num1 + word + num2 + equal + sum);
                    Console.WriteLine($"{num1} + {num2} = {sum}");
                    break;
                case 2:
                    sum = num1 - num2;
                    word = " minus ";
                    Console.WriteLine(num1 + word + num2 + equal + sum);
                    Console.WriteLine($"{num1} - {num2} = {sum}");
                    break;
                case 3:
                    sum = num1 * num2;
                    word = " multiplied by ";
                    Console.WriteLine(num1 + word + num2 + equal + sum);
                    Console.WriteLine($"{num1} x {num2} = {sum}");
                    break;
                case 4:
                    sum = (num1 / num2);
                    word = " divided by ";
                    Console.WriteLine(num1 + word + num2 + equal + sum);
                    Console.WriteLine($"{num1} / {num2} = {sum}");
                    break;
                case 5:
                    sum = Math.Sqrt(num1);
                    Console.WriteLine("The square root of " + num1 + " is " + sum);
                    break;
                case 6:
                    word = " graded by ";
                    Console.WriteLine(num1 + word + num2 + equal + sum);
                    Console.WriteLine($"{num1} ^ {num2} = {sum}");
                    break;
            }
            goto Loop;
        }
        catch
        {
            Console.WriteLine("You didn\'t enter a valid number.");
            goto Loop;
        }
    } 
}