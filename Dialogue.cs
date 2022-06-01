using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow_Factories
{

    class Dialogue
    {
        static public void Greeting()
        {
            Console.Write("Good day, fine sir. Thank you for choosing Vin Fletches' Arrows for your arrow needs. " +
                "\nHow many arrows will you be requiring today? ");
        }
        static public void AnyCustomArrows(int value)
        {

            Console.WriteLine($"\nHow many of the {value} arrows would you like to tailored?");
        }

        static public void FirstCustomArrowOrdering()
        {
            Console.WriteLine($"Let's get to work on the custom arrows. Here is our menu.");
        }

        static public void ShaftOrder()
        {
            string[] superlatives = { "amazing", "awesome", "marvelous", "stunning", "incredible", "wonderful", "stupendous" };
            Random rnd = new Random();
            int RandomNumber = rnd.Next(6);
            Console.Write($"\nOh my, I can tell this is going to be one of my {superlatives[RandomNumber]} What type of shaft would you like on this arrow? ");
        }

        static public void ArrowheadOrder()
        {
            Console.Write("\n What type of arrowhead would you like on this arrow? ");
        }

        static public void ArrowHeadError()
        {
            Console.WriteLine("\nI'm sorry, sir, but that material is not available to us. Please select anoter from the menu.");
        }

        static public void FletchingOrder()
        {
            string[] superlatives = { "amazing", "awesome", "marvelous", "stunning", "incredible", "wonderful", "stupendous" };
            Random rnd = new Random();
            int RandomNumber = rnd.Next(6);
            Console.Write($"\nWow, {superlatives[RandomNumber]} arrowhead choice! What type of fletching would you like on this arrow? ");
        }

        static public void AnotherArrow()
        {
            Console.WriteLine("Let's get to work selecting your next arrow.");
        }

        static public void dashedLine()
        {

            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }

        static public void StandardArrowsElite(int value)
        {
            if (value != 0)
                Console.WriteLine($"As you can see on the menu, we have three types of standard arrows. How many of your {value} arrows " +
                    $"would you like in our Elite configuration?");
        }
        static public void StandardArrowsMarksman(int value)
        {
            if (value != 0)
            {

                Console.WriteLine($"And how many of your would you like in our Marksman configuration?");
            }
        }
        static public void StandardArrowsBeginner(int value)
        {
            if (value != 0)
            {
                Console.WriteLine($"So that makes {value} Beginner arrows.");
            }

        }
    }



}