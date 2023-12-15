using kolkoikrzyzyk.Class;
using System;

namespace kolkoikrzyzyk
{
    class Program
    {
        
        static void Main(string[] args)
        {   string userInput;
            Console.WriteLine("Podaj większość planszy");
            userInput=Console.ReadLine();
            var validSize=ChangeUserInput(userInput);
            Board board = new Board(validSize);
            while (true)
            {
                Console.Clear();
               board.DrawBoard();
                board.ReadPlayerMovement();
            } 
        }

        public static int ChangeUserInput(string input)
        {
            var valid = int.TryParse(input, out int result); 
            if (valid != true)
            {
                Console.WriteLine("Zła wartość");
            }
            return result;
        }
    }
}
