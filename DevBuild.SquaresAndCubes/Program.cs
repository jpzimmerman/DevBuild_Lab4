using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevBuild.SquaresAndCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;
            bool parseSuccessful = false;
            bool userWantsToQuit = false;
            bool userGaveValidContinueResponse = false;
            string userContinueResponse;

            Console.Write("***********************************************************\n" +
                           "*     Dev.Build(2.0) - Squares and Cubes                  *\n" +
                           "***********************************************************\n");
            Console.WriteLine(StringTable.TitleString + "\n");
            while (!userWantsToQuit)
            {
                userGaveValidContinueResponse = false;
                Console.Write(StringTable.EnterNumberString + " ");
                while (!parseSuccessful)
                {
                    parseSuccessful = int.TryParse(Console.ReadLine(), out userNumber);
                    if (parseSuccessful) { break; }
                    else
                    {
                        Console.Write(StringTable.IntegerParseFailMessage + " ");
                    }
                }
                parseSuccessful = false;
                ShowCubesAndSquaresTable(userNumber);

                //now that we've displayed the table, let's reset the variable that holds the user's number and ask user if they'd like to enter another number
                userNumber = 0;
                Console.Write(StringTable.ContinueString + " ");
                while (!userGaveValidContinueResponse)
                {
                    userContinueResponse = Console.ReadLine();
                    switch (userContinueResponse)
                    {
                        case "y":
                        case "yes":
                            userGaveValidContinueResponse = true;
                            break;
                        case "n":
                        case "no":
                            userGaveValidContinueResponse = true;
                            userWantsToQuit = true;
                            Console.WriteLine(StringTable.GoodbyeMessage);
                            break;
                        default:
                            userGaveValidContinueResponse = false;
                            Console.WriteLine(StringTable.ContinueInputFailMessage);
                            //userWantsToQuit = true;
                            break;
                    }
                }
            }

            Thread.Sleep(3000);
        }
        /// <summary>
        /// This function accepts a given integer, and displays a table of squares and cubes from 1 to given integer
        /// </summary>
        /// <param name="userNumber">Table will display squares and cubes from 1 to this number.</param>
        public static void ShowCubesAndSquaresTable(float userNumber)
        {
            Console.WriteLine("\n" + StringTable.CubesAndSquaresTableHeader);
            Console.WriteLine("Number".PadRight(10) + "Squared".PadRight(10) + "Cubed".PadRight(10));
            for (int i = 0; i < 3; i++)
            {
                Console.Write("=======".PadRight(10));
            }
            Console.Write("\n");

            //Print the initial number, plus the squared and cubed values for that number, from one to user's number
            for (int i = 1; i <= Math.Abs(userNumber); i++)
            {
                Console.WriteLine(i.ToString().PadRight(10) +
                                    ((int)Math.Pow(i, 2)).ToString().PadRight(10) +
                                    ((int)Math.Pow(i, 3)).ToString().PadRight(10));

            }
        }

    }
}
