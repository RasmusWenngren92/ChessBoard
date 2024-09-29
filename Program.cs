namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programmer   : Rasmus Wenngren
            // Program      : Fullstack .NET
            // Course       : Programmering med C# och .NET
            // Lab 2        : ChessBoard

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Declaring default value for squares, number of rows and a bool for the program to run
            string white = "◻";
            string black = "◼";
            int number = 0;
            bool endGame = false;
            Console.WriteLine("Hur stort schackbräde vill du skapa?");//asking how big board to create

            while (!endGame)
            {
                bool success = (Int32.TryParse(Console.ReadLine(), out number));// checking input value and converting from string to int
                Console.Clear();
                if (success)
                {
                    int rowSize = number; // declarates how many rows
                    int colSize = number;// declarates how many columns

                    for (int row = 0; row < rowSize; row++) //looping through declared amounts of rows
                    {
                        for (int col = 0; col < colSize; col++)//looping through declarede amounts of columns
                        {
                            if ((row + col) % 2 == 0) // an equation to determit if the input is even or uneven
                            {
                                Console.Write($" {white} ");
                                Thread.Sleep(25);//making it look like someone actually is typing out the board
                            }
                            else
                            {
                                Console.Write($" {black} ");
                                Thread.Sleep(25);//making it look like someone actually is typing out the board
                            }
                        }
                        Console.WriteLine();// printing a new line each time the loop has gone thruogh the input from the user
                    }
                    
                    Thread.Sleep(2000);
                    Console.WriteLine("Snyggt jobbat! Tack för idag :) ");
                    endGame = true;// bool to end the loop and end the program
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Var god mata in en siffra!");
                    
                }
            }
        }
        
    }
}
