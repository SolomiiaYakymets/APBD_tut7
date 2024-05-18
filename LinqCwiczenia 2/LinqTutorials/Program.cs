using System;
using System.Runtime.InteropServices;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = LinqTasks.Task1();
            Console.WriteLine("Task 1");
            foreach (var emp in t1)
            {
                Console.WriteLine(emp);
            }

            var t2 = LinqTasks.Task2();
            Console.WriteLine("Task 2");
            foreach (var emp in t2)
            {
                Console.WriteLine(emp);
            }
            
            var t3 = LinqTasks.Task3();
            Console.WriteLine("Task 3");
            Console.WriteLine(t3);
            
            var t4 = LinqTasks.Task4();
            Console.WriteLine("Task 4");
            foreach (var emp in t4)
            {
                Console.WriteLine(emp);
            }
            
            var t5 = LinqTasks.Task5();
            Console.WriteLine("Task 5");
            foreach (var emp in t5)
            {
                Console.WriteLine(emp);
            }
            
            var t6 = LinqTasks.Task6();
            Console.WriteLine("Task 6");
            foreach (var emp in t6)
            {
                Console.WriteLine(emp);
            }
            
            var t7 = LinqTasks.Task7();
            Console.WriteLine("Task 7");
            foreach (var emp in t7)
            {
                Console.WriteLine(emp);
            }
            
            var t8 = LinqTasks.Task8();
            Console.WriteLine("Task 8");
            Console.WriteLine(t8);
            
            var t9 = LinqTasks.Task9();
            Console.WriteLine("Task 9");
            Console.WriteLine(t9);
            
            var t10 = LinqTasks.Task10();
            Console.WriteLine("Task 10");
            foreach (var emp in t10)
            {
                Console.WriteLine(emp);
            }
            
            var t11 = LinqTasks.Task11();
            Console.WriteLine("Task 11");
            foreach (var emp in t11)
            {
                Console.WriteLine(emp);
            }
            
            var t12 = LinqTasks.Task12();
            Console.WriteLine("Task 12");
            foreach (var emp in t12)
            {
                Console.WriteLine(emp);
            }
            
            int[] numbers = [1,1,1,1,1,1,10,1,1,1,1];
            var t13 = LinqTasks.Task13(numbers);
            Console.WriteLine("Task 13");
            Console.WriteLine(t13);
            
            var t14 = LinqTasks.Task14();
            Console.WriteLine("Task 14");
            foreach (var dep in t14)
            {
                Console.WriteLine(dep.Dname);
            }
            
            var t15 = LinqTasks.Task15();
            Console.WriteLine("Task 15");
            foreach (var emp in t15)
            {
                Console.WriteLine(emp);
            }
            
            var t16 = LinqTasks.Task16();
            Console.WriteLine("Task 16");
            foreach (var result in t16)
            {
                Console.WriteLine(result);
            }

        }
    }
}
