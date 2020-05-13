using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public class flys:Insects
    {
        public override int Age => 1;
        public override decimal Weight => 1m;

        public override int Id => 065589657;

        public override string Wings => "two";


        public override bool fly()
        {
            Console.WriteLine("flys fly!!");
            return true;

        }
        public override string Sound()
        {
            return "the flys zzzzz";
        }

        public override string Sleep()
        {
            return "the flys sleep ";
        }
        public override string Eat()
        {
            return "flys eat trash ";
        }
    }
}
