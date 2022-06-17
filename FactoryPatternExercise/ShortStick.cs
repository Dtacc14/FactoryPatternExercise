using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class ShortStick : ILaxStickTypes
    {
        public void StickType()
        {
            Console.WriteLine("You get a new short stick!");
        }
    }
}
