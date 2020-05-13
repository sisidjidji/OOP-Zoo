using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
    public abstract class Insects : Animals
    {

        public override int Age => 1;
        public override decimal Weight => 10m;

        public override int Id => 07;

        public abstract string Wings { get; }


        public virtual bool fly()
        {
            Console.WriteLine("can all the insects fly!!");
            return false;

        }
    }
}
