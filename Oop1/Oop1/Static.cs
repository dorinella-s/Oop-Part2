using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public static class Static
    {
        static string name = "Intern Dorina";

        public static void PrintStaticMethod()
        {
            Console.WriteLine("____________________Static________________");
        }

        public static void VertebrExtended(this Vertebrates element)
        {
            element.PrintInfo();
            Console.WriteLine(name);
        }
    }
}
