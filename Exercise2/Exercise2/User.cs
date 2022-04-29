using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class User
    {
        protected string _name;
        protected int _age;


        public void SetName(string name)
        {
            _name = name;
        }

        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void GetAge()
        {
            Console.WriteLine(_age);

        }

    }
}
