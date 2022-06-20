using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class GoalieStick : ILaxStickTypes
    {
        public GoalieStick()
        {
            Console.WriteLine("You get a new goalie stick!");
        }
        public void StickType()
        {
            Console.WriteLine("Do not let the opposing team score.");
        }
    }
}
