using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
    public class lions:mamels
    {
        public override int Age => 7;
        public override decimal Weight => 10m;

        public override int Id => 09257822;


        public override string Hair => "brown";


        public override string Sound()
        {
            return "the lion grrrr";
        }

        public override string Sleep()
        {
            return "the lion sleep the night";
        }
        public override string Eat()
        {
            return "lion hunt";
        }
    }
}
