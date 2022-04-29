using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("John", 25, 1000);
            Worker worker2 = new Worker("Ivan", 25, 1000);
            Worker worker3 = new Worker("Vasya", 26, 2000);
            Student st1 = new Student("Amelie", 21, 300, "Computer Science");


            //worker3.SetName("Vasya");
            //worker3.SetAge(26);
            //worker3.SetSalary(2000);

            Console.WriteLine("The sum of Ivan and Vasya salaries: " + (worker2.GetSalary() + worker3.GetSalary()));
            Console.WriteLine("_________________");
            st1.PrintStudentInfo();
        }
    }
}
