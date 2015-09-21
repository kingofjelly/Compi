using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compi
{
    public enum userChoice { createGrid = 1, runTranslator = 2, exit = 3 }

    class Program
    {


        static void Main(string[] args)
        {
            //ito ay isang compilation na lahat na gawa na ginawa ako, habang nagaaral ako ang wika ng c# para aking trabaho.
            //Mag include ako mga switch statements, enums, at maraming OOP principles, E.g classes, objects, inheritance, constructors, baka structs and ibang bigay.

            //nagadd na ako ang exception class sa bagong project ko
            runProgram();
        }

        static void runProgram()
        {
            string userInput;
            int userSelection;
            //main app ran through this
            Console.WriteLine("Ano gusto mo gawain ngayon? 1 = Naglaro. 2 = Salin. 3 = Alis");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userSelection))
            {
                //switch dito
                switch (userSelection)
                {
                    case (int)userChoice.createGrid:
                        grid();
                        break;
                    case (int)userChoice.runTranslator:
                        Translate();
                        break;
                    case (int)userChoice.exit:
                        Exit();
                        break;
                    default:
                        Exit();
                        break;
                }

            }
            //switch case insert dito
            else
            {
                //do nothing or re-run run program?
                runProgram();//re-run if wrong data entered.
            }
            
        }
        static void grid()
        {
            Console.WriteLine("You chose 1");
        }
        static void Translate()
        {
            Console.WriteLine("You chose 2");
        }
        static void Exit()
        {
            Console.WriteLine("You chose 3");
        }
    }
}
