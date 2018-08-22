using System.Threading; //Threads management
using static FindTheNumber.ToolBox.ConsoleWritingUtils; //using my toolboox like static class
using System; //using to use the Console object

namespace FindTheNumber.Display
{
    public static class ConsoleDisplay
    {

        /// <summary>
        /// Display the main menu of the game
        /// </summary>
        public static void MainMenu()
        {
            int speed = 0;
            int x = 0;
            int y = 0;
            DisplayWriteline("Welcome in the Find The Number Game ;-)", speed, x, y);
            DisplayWriteline("--------------------------------------", speed, x, ++y);
            DisplayWriteline("Rules:", speed, x, ++y);
            DisplayWriteline("------", speed, x, ++y);
            DisplayWriteline("I will choose a number between 0 and 100.", speed, x, ++y);
            DisplayWriteline("You have to find it by entering various numbers and i tell you if it's upper or lower.", speed, x, ++y);
            DisplayWriteline("", speed, x, ++y);
            DisplayWriteline("Are you ready ?", speed, x, ++y);
            Thread.Sleep(1000);//pause the thread for 1 sec.
            DisplayWriteline("Let's go !", speed, x, ++y);
            DisplayWriteline("", speed, x, ++y);
            Thread.Sleep(1000);//pause the thread for 1 sec.
            DisplayWriteline("Enter a number between 0 and 100:", speed, x, ++y);

        }
        /// <summary>
        /// Display an error message and ask to the user to enter a number again
        /// </summary>
        public static void ErrorMessage()
        {
            int speed = 20;
            int x = 0;
            int y = 0;
            Console.Clear();
            DisplayWriteline("Please, enter a number between 0 and 100: ", speed, x, y);
            Console.ReadKey();
        }

        public static void ErrorKeyEntryMessage()
        {
            int speed = 20;
            int x = 0;
            int y = 0;
            Console.Clear();
            DisplayWriteline("Wrong key, please retry with Y or N", speed, x, y);
            Thread.Sleep(1000);
            
        }



        public static void TooHighNumberDisplay(int numberEntered)
        {
            int speed = 0;
            int x = 0;
            int y = 0;
            Console.Clear();
            DisplayWriteline($"The number to find is smaller than {numberEntered} , please try again: ", speed, x, y);
        }

        /// <summary>
        /// Display the message that the number entered is to high
        /// </summary>
        /// <param name="numberEntered"></param>
        public static void TooLowNumberDisplay(int numberEntered)
        {
            Console.Clear();
            int speed = 0;
            int x = 0;
            int y = 0;
            Console.Clear();
            DisplayWriteline($"The number to find is higher than {numberEntered} , please try again: ", speed, x, y);

        }


        /// <summary>
        /// Display the winning message
        /// </summary>
        public static void WinDisplay()
        {
            Console.Clear();
            int speed = 10;
            int x = 5;
            int y = 0;
            DisplayWriteline("╔══════════════════╗", speed, x, y);
            DisplayWriteline("║     YOU WIN !    ║ ", speed, x, ++y);
            DisplayWriteline("╚══════════════════╝ ", speed, x, ++y);
            
        }

        /// <summary>
        /// display the try again message
        /// </summary>
        public static void TryAgainDisplay()
        {
            int y = 5; 
            int speed = 0;
            int x = 0;
            DisplayWriteline("Would you like to play again ? Y/N", speed, x, y);
        }

        /// <summary>
        /// display the exit message
        /// </summary>
        public static void ExitDisplay()
        {
            Console.Clear();
            DisplayWriteline("Have a nice day. Bye ! ;-)");
            Thread.Sleep(2000);


        }
    }
}
