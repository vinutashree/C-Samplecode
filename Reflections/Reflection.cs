using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    internal class Reflection
    {
        static void Main(string[] args)
        {
            String studentName = "Jack";

            // get the current type of studentName
            Type studentNameType = studentName.GetType();

            Console.WriteLine("Type is: " + studentNameType);

            Reflection reflection = new Reflection();
            reflection.Reftogetassembly();

            Reflection refl = new Reflection();
            refl.RefwithEnumr();

            Reflection ref2 = new Reflection();
            ref2.Refwithstring();
            Console.ReadLine();
        }

        //Reflection to get Assembly
        public void Reftogetassembly()
        {
            Console.WriteLine("-------------------------");
            // get typeof the Program class and load it to Type variable t     
            Type t = typeof(Reflection);

            // get Assembly of variable t using the Assembly property
            Console.WriteLine(t.Assembly);
        }

        //Reflection with Enumerable
        public void RefwithEnumr()
        {
            Console.WriteLine("-------------------------");
            // get typeof Enumerable and load it to Type variable t     
            Type t = typeof(Enumerable);

            // the Type class properties return information about the Enumerable Type 
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);
        }

        //Reflection with string
        public void Refwithstring()
        {
                Console.WriteLine("-------------------------");
                // get typeof String and load it to Type variable t     
                Type t = typeof(String);

                // the Type class properties return information about the String Type 
                Console.WriteLine("Name : {0}", t.Name);
                Console.WriteLine("Namespace : {0}", t.Namespace);
                Console.WriteLine("Base Type : {0}", t.BaseType);
        }

    }
}
