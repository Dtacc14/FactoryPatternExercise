using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What position do you play?");
            string playerAnswer = Console.ReadLine();

            ILaxStickTypes player1 = StickFactory.GetStick(playerAnswer);
            player1.StickType();
        }
    }
}
