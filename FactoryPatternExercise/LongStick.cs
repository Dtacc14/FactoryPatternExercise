using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class LongStick : ILaxStickTypes
    {
        public LongStick()
        {
            Console.WriteLine("You get a new long stick!");
        }
        public void StickType()
        {
            Console.WriteLine("Do not let the opposing team score.");
        }
    }
}
