using System;
using System.Threading; //Using for the thread

namespace FindTheNumber.ToolBox
{
    public static class ConsoleWritingUtils
    {
        public static void DisplayWriteline(string str, int speed = 0, int x = 0, int y = 0)
        {
            //Set a yellow color foreground in the console 
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Set the cursor placement in the console
            Console.SetCursorPosition(x,y);
            
            //Loop on every char of the str and make a sleep with the thread between each loop
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }

        }

        
    }
}
