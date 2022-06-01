using Arrow_Factories;

string userArrowHead;
string userArrowFletching;
float userShaftLength;
int howManyArrows;
int customArrowCount;
int standardArrowCount;
float totalArrowOrderCost = 0f;
int standardArrowOrderedCount = 0;
int eliteArrowCount;
int marksmanArrowCount;
int beginnerArrowCount;


Dialogue.Greeting();

//initiates the veriable to contain a response for number of arrows. This will feed the Arrow Array to determine the array's length.
howManyArrows = Convert.ToInt16(Console.ReadLine());

Dialogue.AnyCustomArrows(howManyArrows);
customArrowCount = Convert.ToInt16(Console.ReadLine());
standardArrowCount = howManyArrows - customArrowCount;

//initializes Arrows based on the number customer going to purchase.
Arrow[] purchase = new Arrow[customArrowCount];

if (customArrowCount > 0)
{
    Dialogue.FirstCustomArrowOrdering();

    //initializes each of the arrows in the 'purchase' array
    //also contains the work that will be done to design the arrows.
    for (int i = 0; i < purchase.Length; i++)
    {
        purchase[i] = new Arrow();


        Menus.MenuPrint();

        //ask which arrow head the user wants.
        Dialogue.ArrowheadOrder();
        userArrowHead = Console.ReadLine();
        while (purchase[i].ArrowHeadInputVerify(userArrowHead) == false)
        {
            Menus.MenuPrint();
            Dialogue.ArrowHeadError();
            userArrowHead = Console.ReadLine();
        }

        //asks which fletching the user wants
        Dialogue.FletchingOrder();
        userArrowFletching = Console.ReadLine();
        while (purchase[i].ArrowFletchingInputVerify(userArrowFletching) == false)
        {
            Menus.MenuPrint();
            Dialogue.ArrowHeadError();
            userArrowFletching = Console.ReadLine();
        }

        //determines arrow shaft length
        Dialogue.ShaftOrder();
        userShaftLength = Convert.ToSingle(Console.ReadLine());
        purchase[i].ShaftLength = userShaftLength;
        //adds shaft length cost to arrow cost.
        purchase[i].AddShaftToCost();

        //calls the individual arrow's order summary with cost. 
        //Also adds the cost of the arrow to the variable that is holding that information
        purchase[i].SingleArrowOrderSummary();
        totalArrowOrderCost += purchase[i].AddArrowToTotal();
        Dialogue.dashedLine();

        if (i < purchase.Length - 1)
        {
            Dialogue.AnotherArrow();
        }
        else
            break;
    }
}

if (standardArrowCount > 0)
{
    Dialogue.StandardArrowsElite(standardArrowCount);
    Menus.MenuPrint();
    eliteArrowCount = Convert.ToInt16(Console.ReadLine());
    standardArrowCount -= eliteArrowCount;
    Arrow[] Elite = new Arrow[eliteArrowCount];

    if (eliteArrowCount > 0)
    {
        for (int i = 0; i < eliteArrowCount; i++)
        {
            Elite[i] = new Arrow();
            Elite[i].EliteArrowFactory();
            totalArrowOrderCost += Elite[i].AddArrowToTotal();
        }
    }
}

if (standardArrowCount > 0)
{
    Dialogue.StandardArrowsMarksman(standardArrowCount);
    marksmanArrowCount = Convert.ToInt16(Console.ReadLine());
    standardArrowCount -= marksmanArrowCount;
    if (marksmanArrowCount > 0)
    {
        for (int i = 0; i < marksmanArrowCount; i++)
        {
            Arrow[] marksman = new Arrow[marksmanArrowCount];
            marksman[i] = new Arrow();
            marksman[i].MarksmanArrowFactory();
            totalArrowOrderCost += marksman[i].AddArrowToTotal();

        }
    }

}


if (standardArrowCount > 0)
{
    Dialogue.StandardArrowsBeginner(standardArrowCount);
    beginnerArrowCount = standardArrowCount;

    for (int i = 0; i < beginnerArrowCount; i++)
    {
        Arrow[] beginnerArrow = new Arrow[standardArrowCount];
        beginnerArrow[i] = new Arrow();
        beginnerArrow[i].BeginnerArrowFactory();
        totalArrowOrderCost += beginnerArrow[i].AddArrowToTotal();
    }

}

//provides a total order summary
Console.WriteLine($"Sir, I really think that you have picked yourself up {howManyArrows} great arrows! And you got them for only {totalArrowOrderCost} " +
    $"\nGold...sounds like a steal to me!!!");
