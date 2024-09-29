public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 17; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine());
            // Todo: Implement the correct conditionals inside the while loop.
            break;
        }
            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

            while (Guess != returnValue)
    {
            Guess = Convert.ToInt32(Console.Read());

             (Guess < returnValue)
        {
            Console.WriteLine("No, the number I am thinking of is higher than " + Guess + " .  Can you guess what it is?");
            Console.ReadLine();

        }
            while (Guess > returnValue)
        {
            Console.WriteLine("No, the number I am thinking of is lower than " + Guess + " .  Can you guess what it is");
            Console.ReadLine();
        }
    }
             while (Guess == returnValue)
    {
            Console.WriteLine("Well done! The answer was " + returnValue);
            Console.ReadLine();
    }
    }

    public void Fibonacci(int n)  // Todo: Write out the Fibonacci sequence, tips: use a for loop.
    {
        int a = 0, b = 1, c;
        Console.WriteLine($"{a} + {b} + ");

        {
        int[] a = new int[numElement];
        a[0] = 0;
        a[1] = 1;
        
        for (int i = 2; i < numElement; i++)
    {
        a[i] = a[i - 2] + a[i - 1];
    }

    return a;
}
        // c = a + b;
        // a = b;
        // b = c;
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        
        Console.WriteLine("Enter your number : ");
        string number = Console.ReadLine();
        Int32.Parse(number);

        if(number % 2 == 0)
    {
        Console.WriteLine("Your number is even.");
        }
        else
        {
        Console.WriteLine("Your number is odd.");
    }
        
    Console.WriteLine("");
    }
}