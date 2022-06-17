using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class StickFactory
    {
        public static ILaxStickTypes GetStick (string stickType) 
        {
            switch(stickType.ToLower())
            {
                case "goalie":
                    return new GoalieStick();
                case "short stick":
                    return new ShortStick();
                case "defense":
                    return new LongStick();
                default:
                    return new LongStick ();
            }
        }
    }
}
