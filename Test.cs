using System;
namespace GuessMyNumber
{
    public class Test
    {

        public static void TestMet(bool z)

        {
            if (z == false)
            {
                Console.WriteLine("Please, enter an integer.");
                z = int.TryParse(Console.ReadLine(), out int a);
                //had to re-initialize int a
                Test.TestMet(z);
                //testing for an integer, if so it's outputted as a

                Random rnd = new Random();
                int newnum = rnd.Next(1, 11);
                //I'm not sure why this does not generate a new random number (or maybe it does)
                //but it was the only way I could assign n here

                GuessAgain.TryAgain(a, n: newnum);
                //Now that we surely have an integer, we can run our if... else loop
                //I think "n:" is not necessary here, but it doesn't hurt either
            }
        }
    }
}
