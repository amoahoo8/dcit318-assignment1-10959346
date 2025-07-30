using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            // Clear console for a cleaner menu appearance
            Console.WriteLine("\n=================================");
            Console.WriteLine("  C# Assignment 1 Main Menu");
            Console.WriteLine("=================================");
            Console.WriteLine("Select an application to run:");
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
                    RunTicketPriceCalculator();
                    break;
                case "3":
                    RunTriangleIdentifier(); // Updated
                    break;
                case "4":
                    keepRunning = false;
                    Console.WriteLine("Exiting application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
             Console.WriteLine("\nPress any key to return to the menu...");
             Console.ReadKey();
        }
    }

    //[cite_start] Task 1: Grade Calculator [cite: 4]
    static void RunGradeCalculator()
    {
        Console.WriteLine("\n--- Grade Calculator ---");
        Console.Write("Enter a numerical grade between 0 and 100: ");
        
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letterGrade;
            if (grade >= 90) { letterGrade = "A"; } // [cite: 6]
            else if (grade >= 80) { letterGrade = "B"; } // [cite: 7]
            else if (grade >= 70) { letterGrade = "C"; } // [cite: 8]
            else if (grade >= 60) { letterGrade = "D"; } // [cite: 9]
            else { letterGrade = "F"; } // [cite: 10]
            Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }

    //[cite_start] Task 2: Ticket Price Calculator [cite: 11]
    static void RunTicketPriceCalculator()
    {
        Console.WriteLine("\n--- Ticket Price Calculator ---");
        Console.Write("Please enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
        {
            int price;
            if (age >= 65 || age <= 12) { price = 7; } // [cite: 12]
            else { price = 10; } // [cite: 12]
            Console.WriteLine($"Your ticket price is: GHC{price}"); // [cite: 14]
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }

    // [cite_start] Task 3: Triangle Type Identifier [cite: 15]
    static void RunTriangleIdentifier()
    {
        Console.WriteLine("\n--- Triangle Type Identifier ---");

        // [cite_start] Prompt user to enter three sides of a triangle [cite: 16]
        Console.Write("Enter the length of side 1: ");
        bool isSide1Valid = double.TryParse(Console.ReadLine(), out double side1);
        
        Console.Write("Enter the length of side 2: ");
        bool isSide2Valid = double.TryParse(Console.ReadLine(), out double side2);

        Console.Write("Enter the length of side 3: ");
        bool isSide3Valid = double.TryParse(Console.ReadLine(), out double side3);

        if (isSide1Valid && isSide2Valid && isSide3Valid && side1 > 0 && side2 > 0 && side3 > 0)
        {
            // Check triangle inequality theorem
            if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
            {
                string triangleType;
                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral"; // All three sides are equal [cite: 18]
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    triangleType = "Isosceles"; // Two sides are equal [cite: 18]
                }
                else
                {
                    triangleType = "Scalene"; // No sides are equal [cite: 19]
                }
                Console.WriteLine($"The triangle is: {triangleType}"); // [cite: 17]
            }
            else
            {
                 Console.WriteLine("Invalid input. The given side lengths do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid positive numbers for all sides.");
        }
    }
}