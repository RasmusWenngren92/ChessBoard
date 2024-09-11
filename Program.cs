namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hur stort schackbräde vill du skapa?");//asking how big board to create
            int number = Int32.Parse(Console.ReadLine());//converts from string to int
            Console.WriteLine("Hur ska vita rutor se ut?");
            string white = Console.ReadLine();//declares white squares
            Console.WriteLine("Hur ska svarta rutor se ut?");
            string black = Console.ReadLine();//declares black squares

            int rowSize = number; // declarates how many rows
            int colSize = number;// declarates how many columns

            for (int row = 0; row < rowSize; row++) //looping through declared amounts of rows
            {
                for (int col = 0; col < colSize; col++)//looping through declarede amounts of columns
                {
                    if ((row + col) % 2==0) // an equation to determit if the input is even or uneven
                    {
                        //Console.Write("◼︎");// if the number is even
                        Console.Write($" {white} ");
                    }
                    else
                    {
                        //Console.Write("◻︎");//if the number is uneven
                        Console.Write($" {black} ");
                    }
                }
                Console.WriteLine();//writes out the chessboard
                
            }
            Console.Read();// to give the user time to look at the chessboard
        }
    }
}
