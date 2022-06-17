using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class GoalieStick : ILaxStickTypes
    {
        public void StickType()
        {
            Console.WriteLine("You got a new goalie stick!");
        }
    }
}
