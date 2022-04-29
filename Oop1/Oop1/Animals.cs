using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public class Animals
    {
        protected string _name;
        protected int _numberOfLegs;

        public void PrintInfo()
        {
            Console.WriteLine("The name of animal is - " + _name + " and the number of legs is: " + _numberOfLegs);
        }

        public int GetNumberOfLeg()
        {
            return _numberOfLegs;
        }

        public string GetName()
        {
            return _name;
        }

    }
}
