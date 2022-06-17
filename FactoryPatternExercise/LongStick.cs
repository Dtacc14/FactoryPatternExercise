using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class LongStick : ILaxStickTypes
    {
        public void StickType()
        {
            Console.WriteLine("You get a new long stick!");
        }
    }
}
