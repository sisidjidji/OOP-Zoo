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

        public abstract void Eat();

        public abstract void Sound();
         public virtual void Sleep()
        {

        }

    }
}
