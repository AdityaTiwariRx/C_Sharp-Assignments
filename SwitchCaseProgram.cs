using System;

class Program
    {
        static void Main()
        {

        int TotalCoffeeCost = 0;

        Start:
            Console.WriteLine("1- small, 2- medium, 3- large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;

            case 2:
                TotalCoffeeCost += 2;
                break;

            case 3:
                TotalCoffeeCost += 3;
                break;

            default:
                Console.WriteLine("Your Choice {0} is invalid", UserChoice);
                break;
        }
    Decide:
        Console.WriteLine("Do you want another coffee - yes or no ?");
        string UserDecision = Console.ReadLine();

        
        switch (UserDecision.ToUpper())
        { case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid. Plz try again", UserDecision);
                goto Decide;

        }
        Console.WriteLine("Thank you for shopping");
        Console.WriteLine("Bill Amount ={0}",TotalCoffeeCost);
       
        }
    }

