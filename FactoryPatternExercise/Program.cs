using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What position fo you play: Defense, Short stick, or Goalie?");
            string playerAnswer = Console.ReadLine();

            ILaxStickTypes player1 = StickFactory.GetStick(playerAnswer);
            player1.StickType();
        }
    }
}
