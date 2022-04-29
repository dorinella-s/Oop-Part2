using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {

            Vertebrates dog = new Vertebrates("Dog",4,"Warm Blooded");
            Vertebrates cat = new Vertebrates("Cat",4, "Warm Blooded");
            Invertebrates spider = new Invertebrates("Spider",4,8);
            Invertebrates ladybug = new Invertebrates("Ladybug", 3, 6);

            spider.CalculateNumberOfLeg(spider.GetPairOfLeg());
            dog.GetName();

            cat.PrintInfo();
            //static method
            Static.PrintStaticMethod();
            dog.VertebrExtended();

            
        }


    }
   
}
