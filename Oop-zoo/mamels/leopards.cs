using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public class leopards:mamels
    {
        public override int Age => 15;
        public override decimal Weight => 100m;

        public override int Id => 0847822;


        public override string Hair => "black";


        public override string Sound()
        {
            return "the leopard hgjg";
        }

        public override string Sleep()
        {
            return "the leopards sleep the night";
        }
        public override string Eat()
        {
            return "leopards hunt";
        }
    }
}
