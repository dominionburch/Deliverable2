using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables to count water and sodas ordered and people
            int num, num2, person = 1, water = 0, soda = 0;
            string choice;
            //Declaring more vairable for pricing
            double total, buffet, waterPrice, sodaPrice;

            //Greeting and asking the patron(s) for party size
            Console.WriteLine("Hello! Welcome to our Buffet. ");
            Console.WriteLine("All you can eat for $9.99! We only charge extra for water and soda.");
            Console.WriteLine("How many people are in your group? Please, parties of 6 or lower.");
            num = int.Parse(Console.ReadLine());

            //Checking user input for a party greater than 6
            if(num > 6 || num == 0)
            {
                Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day!");
                return;
            }else
            {
                Console.WriteLine("A table for " + num + ", Please follow me and take a seat.");
                Console.WriteLine("Lets get everyone started with some drinks! We've got water or soda");
            }

            //copying value from num to num2 to print out size of party at end of program.
            num2 = num;

            //Running Loop to collect orders
            while (num <= 6 && num != 0)
            {
                Console.WriteLine("Alright, person number " + person + ", water or soda?");
                choice = Console.ReadLine();

                if (choice == "water" || choice == "Water")
                {
                    Console.WriteLine("Water, good choice!");
                    water++;
                }else if (choice == "soda" || choice == "Soda")
                {
                    Console.WriteLine("Soda, good choice!");
                    soda++;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not an option.");
                }

                num--; //decrement num to loop the number of times according to party size
                person++; //increment person for waiter or waitress to address each member of the party
            }

            //calculating totals
            buffet = person * 9.99;
            waterPrice = water * 1.25;
            sodaPrice = soda * 1.75;
            total = buffet + waterPrice + sodaPrice;

            //Displying the details and order of the party members
            Console.WriteLine();
            Console.WriteLine("So we have: ");
            Console.WriteLine(num2 + " buffets at $9.99 each.");
            Console.WriteLine(water + " orders of water at $1.25 each.");
            Console.WriteLine(soda + " orders of soda at $1.75 each.");
            Console.WriteLine("Total: $" + total);
        }
    }
}
