using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public class Vertebrates : Animals
    {
        protected string _bloodType;
        public Vertebrates(string name, int nrLegs, string blood)
        {
            base._name = name;
            base._numberOfLegs = nrLegs;
            _bloodType = blood;
        }

        public string GetBloodType()
        {
            return _bloodType;
        }



    }
}
