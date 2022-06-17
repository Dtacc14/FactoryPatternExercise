using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class LongStick : ILaxStickTypes
    {
        public void StickType()
        {
            Console.WriteLine("You got a new long stick!");
        }
    }
}
