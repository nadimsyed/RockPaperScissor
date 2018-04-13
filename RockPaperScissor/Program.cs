using System;

namespace RockPaperScissor
{
    class Program
    {

        static void Main(string[] args)
        {
            RunGame();
        }
        
        static void RunGame()
        {
            while (true)
            {

                Console.WriteLine("Player1, please enter from the selection: Rock, Paper, Scissor");
                string firstPlayer = Console.ReadLine().ToLower();

                Console.WriteLine("Player2, please enter from the seletion: Rock, Paper, Scissor");
                string secondPlayer = Console.ReadLine().ToLower();

                if (firstPlayer == "rock")
                {
                    if (secondPlayer == "rock")
                    {
                        Console.WriteLine("tied");
                    }
                    else if (secondPlayer == "paper")
                    {
                        Console.WriteLine("Second Player is the winner!");
                    }
                    else if (secondPlayer == "scissor")
                    {
                        Console.WriteLine("First Player is the winner!");
                    }
                    else
                    {
                        Console.WriteLine("Try again again! Wrong input!");
                        continue;
                    }
                }
                if (firstPlayer == "paper")
                {
                    if (secondPlayer == "rock")
                    {
                        Console.WriteLine("First Player is the winner!");
                    }
                    else if (secondPlayer == "paper")
                    {
                        Console.WriteLine("Tied");
                    }
                    else if (secondPlayer == "scissor")
                    {
                        Console.WriteLine("Second Player is the winner");
                    }
                    else
                    {
                        Console.WriteLine("Try again again! Wrong input!");
                        continue;
                    }
                }
                if (firstPlayer == "scissor")
                {
                    if (secondPlayer == "rock")
                    {
                        Console.WriteLine("Second Player is the winner!");
                    }
                    else if (secondPlayer == "paper")
                    {
                        Console.WriteLine("First Player is the winner!");
                    }
                    else if (secondPlayer == "scissor")
                    {
                        Console.WriteLine("Tied");
                    }
                    else
                    {
                        Console.WriteLine("Try again again! Wrong input!");
                        continue;
                    }

                }
                /*if (firstPlayer != "rock" || firstPlayer != "paper" || firstPlayer != "scissor")
                {
                    Console.WriteLine("Try again again! Wrong input!");
                    continue;
                }*/

            }
        }
   
           
    }
}
