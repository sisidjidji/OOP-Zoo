using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public  abstract class Animals
    {
        public abstract int Age { get; }
        public abstract decimal Weight { get; }

        public abstract  int Id { get; }

        public virtual bool Hasfure { get; }

        public abstract string Eat();

        public abstract string Sound();
         public virtual string Sleep()
        {
            return "all animals close there eyes to sleep";
        }

    }
}
