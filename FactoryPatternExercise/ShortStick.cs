using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class ShortStick : ILaxStickTypes
    {
        public ShortStick()
        {
            Console.WriteLine("You get a new short stick!");
        }
        public void StickType()
        {
            Console.WriteLine("Score a lot of goals.");
        }
    }
}
