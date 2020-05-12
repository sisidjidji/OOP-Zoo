using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
    abstract class mamels:Animals
    {
        public override int Age => 7;
        public override decimal Weight => 100m;

        public override int Id => 08;

        public abstract string Hair { get; }


        public virtual bool Nurse()
        {
            Console.WriteLine("does All Mamels nurse! ");
            return false;
        }
    }
}
