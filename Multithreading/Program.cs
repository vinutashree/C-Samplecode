using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Program
    {
      // static method one
        public static void method1()
        {

            // It prints numbers from 0 to 10
            for (int I = 0; I <= 10; I++)
            {

                Console.WriteLine("Method1 is : {0}", I);

                // When the value of I is equal to 
                // 5 then this method sleeps for 
                // 6 seconds and after 6 seconds 
                // it resumes its working
                if (I == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }
        // static method two
        public static void method2()
        {

            // It prints numbers from 0 to 10
            for (int J = 0; J <= 10; J++)
            {

                Console.WriteLine("Method2 is : {0}", J);
            }
        }
        static void Main(string[] args)
        {
            // Calling static methods
            Program.method1();
            Program.method2();
            //Console.ReadLine();
            Console.WriteLine("\n");
            Thread thread1 = new Thread(method3);
            Thread thread2 = new Thread(method4);
            thread1.Start();
            thread2.Start();

        }

        // static method one
        public static void method3()
        {

            // It prints numbers from 0 to 10
            for (int I = 0; I <= 10; I++)
            {
                Console.WriteLine("Method1 is : {0}", I);

                // When the value of I is equal to 5 then
                // this method sleeps for 6 seconds
                if (I == 5)
                {
                    Thread.Sleep(3000);
                }
            }
        }
        // static method two
        public static void method4()
        {
            // It prints numbers from 0 to 10
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Method2 is : {0}", J);
            }
        }

    }
}
 
