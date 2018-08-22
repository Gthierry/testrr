using FindTheNumber.Display;
using FindTheNumber.Models;
using static FindTheNumber.Display.ConsoleDisplay;//using a static instance of Display Class

using System;

namespace FindTheNumber.MainGame
{
    /// <summary>
    /// Static class core containing the main code
    /// </summary>
    public static class Core
    {
        

        /// <summary>
        /// Running the game
        /// </summary>
        public static void Run()
        {
            Number randomNumber = new Number();
            
            bool input;
            int numberEntered;
            do
            {
                Console.Clear();
                MainMenu();
                input = int.TryParse(Console.ReadLine(), out numberEntered);
                if (input == false || numberEntered < 0 || numberEntered > 100)
                {
                    do
                    {
                        ErrorMessage();
                        input = int.TryParse(Console.ReadLine(), out numberEntered);
                    } while (input == false || numberEntered < 0 || numberEntered > 100);

                }
            } while (input == false || numberEntered < 0 || numberEntered > 100);

            CheckNumber(numberEntered, randomNumber.NumberToFind);
        }

        /// <summary>
        /// Check if the number entered == the number of the class number
        /// </summary>
        /// <param name="numberEntered"></param>
        private static void CheckNumber(int numberEntered, int randomNumber)
        {
            bool checkNumber = true;
            do
            {
       
                if (numberEntered > randomNumber)
                {
                    TooHighNumberDisplay(numberEntered);
                    checkNumber = int.TryParse(Console.ReadLine(), out numberEntered);
                }
                else if (checkNumber == false)
                {
                    ErrorMessage();
                    checkNumber = int.TryParse(Console.ReadLine(), out numberEntered);
                }
                else 
                {
                    TooLowNumberDisplay(numberEntered);
                    checkNumber = int.TryParse(Console.ReadLine(), out numberEntered);
                }
            } while (numberEntered != randomNumber);


            //If it's the good number, win message appears
            if (numberEntered == randomNumber)
            {
                WinDisplay();
                Console.ReadKey();

                ConsoleKeyInfo _key;
                Console.CursorVisible = false;
                do
                {
                    TryAgainDisplay();
                    _key = Console.ReadKey();
                    if (_key.Key != ConsoleKey.Y && _key.Key != ConsoleKey.N)
                    {
                        ErrorKeyEntryMessage();
                                             
                    }

                } while (_key.Key != ConsoleKey.Y && _key.Key != ConsoleKey.N);


                switch (_key.Key)
                {
                    case ConsoleKey.Y:
                        Run();
                        break;
                    case ConsoleKey.N:
                        ExitDisplay();
                        Environment.Exit(1);
                        break;
                }
            }

        

          
        }
    }
}
