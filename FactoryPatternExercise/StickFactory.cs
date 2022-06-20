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
                case "goal keeper":
                case "keep":
                case "keeper":
                    return new GoalieStick();
                case "short stick":
                case "shortie":
                case "short stick middie":
                case "attack":
                case "defensive middie":
                    return new ShortStick();
                case "defense":
                case "lsm":
                case "long stick middie":
                case "close d":
                    return new LongStick();
                default:
                    return new LongStick ();
            }
        }
    }
}
