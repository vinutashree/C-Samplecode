using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 3, index =>
            {
                int start = 1;
                int end = 101;

                if (index == 1)
                {
                    start = 200;
                    end = 301;
                }
                else if (index == 2)
                {
                    start = 300;
                    end = 401;
                }
                for (int i = start; i < end; i++)
                {
                    Console.WriteLine($"Loop {index + 1}: {i}");
                }
            });
            Console.WriteLine("All loops completed.");
            Console.ReadKey();
        }
    }

}