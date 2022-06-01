using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow_Factories
{
    class Menus
    {
        //menu
        static private string _menu = "------------------------------------------------------------------------------------------------" +
                               "\n|      Arrow Heads          |          Arrow Fletchings          |          Shaft Lenth        |" +
                               "\n|**********************************************************************************************|" +
                               "\n|      Steel - 10 Gold      |           Plastic - 10 Gold        |                             |" +
                               "\n|     Obsidian - 5 Gold     |        Turkey Feathers - 5 Gold    |        0.05 Gold per cm     |" +
                               "\n|       Wood - 3 Gold       |         Goose Feathers - 3 Gold    |                             |" +
                               "\n|----------------------------------------------------------------------------------------------|" +
                               "\n|                                      Standarnd Arrows                                        |" +
                               "\n|**********************************************************************************************|" +
                               "\n|     The Elite Arrow - Steel Arrow Head, plastic fletching, and a 95cm shaft - 24.75 Gold     |" +
                               "\n|- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |" +
                               "\n|The Marksman Arrow - Steel arrowhead, goose feather fletching, and a 65cm shaft - 16.25 - Gold|" +
                               "\n|- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |" +
                               "\n|      The Beginner Arrow - Wood arrowhead, goose feathers, and a 75cm shaft - 9.75 Gold       |" +
                               "\n------------------------------------------------------------------------------------------------";


        //calls menu
        static public void MenuPrint()
        {
            Console.WriteLine(_menu);
        }
    }
}
