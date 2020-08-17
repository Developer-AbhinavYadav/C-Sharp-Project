using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int TotalCoffeeCost = 0;
        select:
        Console.WriteLine("Please select one coffee: 1 - Small, 2 - Medium, 3 - Large");
       int UserChoice = int.Parse(Console.ReadLine());

       switch(UserChoice)
        {
            case 1:
                TotalCoffeeCost += 15;
                break;
            case 2:
                TotalCoffeeCost += 30;
                break;
            case 3:
                TotalCoffeeCost += 45;
                break;
            default:
                    Console.WriteLine("Invalid Entry! Please select correct options");
                    goto select;
                
        }
        Decide:
        Console.WriteLine("Do you want to buy another coffee - Yes or No");
        string UserDecision = Console.ReadLine();

        switch(UserDecision.ToUpper())
        {
            case "YES":
                goto select;
            case "NO":
                break;
            default:
                Console.WriteLine($"Your choice {UserDecision} is invalid! Please select a valid option");
                goto Decide;
        }

        Console.WriteLine($"Thank you for shopping with us");
        Console.WriteLine($"Bill Amount: {TotalCoffeeCost}");
    }
}

