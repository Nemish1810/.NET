using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  */

namespace Pareshsir
{
    internal class Q2
    {
        /// <summary>
        /// change the value of all parameters
        /// </summary>
        /// <param name="x">this is a first parameters</param>
        /// <param name="y">this is a second parameters</param>
        /// <param name="z">this is a third parameters</param>
        static void Change(out int x, out int y , out int z)
        {
            //value of x assigned - single line comment
            x = 100;
            y = 200;
            z = 300;

        }
        static void Main()
        {
            int a, b , c ;

            a = 10;
            b = 20;
            c = 30;

            Console.WriteLine("befor change");
            Console.WriteLine(".............");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("c : " + c);
            Change(out a , out b , out c); // passing a as a refernce and b as value
            Console.WriteLine("after change");
            Console.WriteLine(".............");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("c : " + c);
        }
    }
}
