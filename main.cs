using System;

class Program
{
    public static void Main(string[] args)
    {
        const int TicketPrice = 25;

        // Display Greenville motto
        Console.WriteLine("**********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("**********************************\n");

        // Display menu
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Calculate Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit\n");

        // Get user's choice
        Console.Write("Please enter your choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.Write("Invalid choice. Please enter 1 or 2: ");
        }

        if (choice == 1)
        {
            // Get number of contestants for this year and last year
            int thisYearContestants = GetContestants("this year");
            int lastYearContestants = GetContestants("last year");

            // Calculate expected revenue
            int expectedRevenue = thisYearContestants * TicketPrice;
            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
            Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");

            // Compare number of contestants
            if (thisYearContestants >= 2 * lastYearContestants)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
            else if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
            else if (thisYearContestants < lastYearContestants)
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }
            else
            {
                Console.WriteLine("This year's competition has the same number of contestants as last year.");
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
        }
    }

    // Loop to ensure input is between 0 and 30.
    static int GetContestants(string year)
    {
        int contestants;
        while (true)
        {
            Console.Write($"Enter the number of contestants {year} (0-30): ");
            if (int.TryParse(Console.ReadLine(), out contestants) && contestants >= 0 && contestants <= 30)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
            }
        }
        return contestants;
    }
}
