using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class UGC
    {
        string[] rules = { "Dress", "Indentity Card" };
        public virtual void RulesMethod()
        {
            foreach(var r in rules)
            {
                Console.WriteLine("Rule:{0}", r);
            }
        }
    }
    class MIT:UGC
    {
        string mitrule = "No mobile";
        public override void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("MIT Rule: {0}",mitrule);
        }
    }
    class annaUniversit:UGC
    {
        string annarules = "Only Formals";
        public new void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("Annauniversity Rules:{0}", annarules);
        }
    }
    class VirtualEgcs
    {
        static void Main()
        {
            UGC uGC = new UGC();
            Console.WriteLine("UGC RULES");
            uGC.RulesMethod();
            Console.WriteLine("MIT RULES");
            MIT mIT = new MIT();
            mIT.RulesMethod();
        }
    }
}
