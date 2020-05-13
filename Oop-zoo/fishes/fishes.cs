using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public  abstract class Fishes:Animals
    {
     

  
        public virtual bool Breath()
        {
            Console.WriteLine("does All Fishes Breath out of the water ! ");
            return false;
        }
    }
}
