using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("\nSelect an application to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunGradeCalculator();
                    break;
                case "2":
                    // To be implemented in the next step
                    Console.WriteLine("Ticket Price Calculator is not yet implemented.");
                    break;
                case "3":
                    // To be implemented later
                    Console.WriteLine("Triangle Type Identifier is not yet implemented.");
                    break;
                case "4":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

   // Task 1: Grade Calculator [cite: 4]
    static void RunGradeCalculator()
    {
        Console.WriteLine("\n--- Grade Calculator ---");
        Console.Write("Enter a numerical grade between 0 and 100: ");

        // Read and parse input
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letterGrade;
            if (grade >= 90)
            {
                letterGrade = "A"; // 90 and above: A [cite: 6]
            }
            else if (grade >= 80)
            {
                letterGrade = "B"; // 80-89: B [cite: 7]
            }
            else if (grade >= 70)
            {
                letterGrade = "C"; // 70-79: C [cite: 8]
            }
            else if (grade >= 60)
            {
                letterGrade = "D"; // 60-69: D [cite: 9]
            }
            else
            {
                letterGrade = "F"; // Below 60: F [cite: 10]
            }
            Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }

    }

    // Task 2: Ticket Price Calculator [cite: 5]
    static void RunTicketPriceCalculator()
    {
        Console.WriteLine("\n--- Ticket Price Calculator ---");
        Console.Write("Please enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
        {
            int price;
            // Discount for senior (age 65+) or child (age 12 and below) [cite: 12]
            if (age >= 65 || age <= 12)
            {
                price = 7; // Discounted price is GHC7 [cite: 12]
            }
            else
            {
                price = 10; // Standard price is GHC10 [cite: 12]
            }
            Console.WriteLine($"Your ticket price is: GHC{price}"); // [cite: 14]
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}


