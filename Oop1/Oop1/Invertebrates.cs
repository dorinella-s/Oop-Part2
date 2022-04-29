using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    class Invertebrates : Animals
    {
        protected int _pairOfLeg;
        public Invertebrates(string name, int pairLeg, int nrLegs)
        {
            base._name = name;
            base._numberOfLegs = nrLegs;
            _pairOfLeg = pairLeg;
        }

        public int GetPairOfLeg()
        {
            return _pairOfLeg;
        }
        public void CalculateNumberOfLeg(int pairLeg)
        {
            int sum = pairLeg * 2;
            Console.WriteLine(_name + " has " + _pairOfLeg + " number of leg pair, and the total number of leg is " + sum);
        }
    }
}
