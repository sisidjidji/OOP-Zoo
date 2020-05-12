using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
    abstract class Fishes:Animals
    {
        public override int Age => 2;
        public override decimal Weight => 100m;

        public override int Id => 09;

  
        public virtual bool Breath()
        {
            Console.WriteLine("does All Fishes Breath out of the water ! ");
            return false;
        }
    }
}
