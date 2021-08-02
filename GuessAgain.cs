using System;
using System.Threading; //to use Thread.Sleep
namespace GuessMyNumber
{
    public class GuessAgain
    {
        static public void TryAgain(int a, int n)
        {
            if (a < n)
            {
                Console.WriteLine("Too low");
                bool z = int.TryParse(Console.ReadLine(), out a);
                Test.TestMet(z);
                //testing new input for an integer/string again
                TryAgain(a, n);
                //if...else statement again with new input
            }
            else if (a > n)
            {
                Console.WriteLine("Too high");
                bool z = int.TryParse(Console.ReadLine(), out a);
                Test.TestMet(z);
                TryAgain(a, n);
            }
            else if (a == n)
            {
                Console.WriteLine("You are correct!");
                Console.WriteLine("Play again.");
                Thread.Sleep(1000); //wait 1000 milliseconds
                Console.WriteLine();
                Console.WriteLine();
                Program.Main(null);
                //works to restart the game but not great to call Main
            }
            else
            {
                Console.Write("Error"); //yet to see this write
            }
        }
    }
}
