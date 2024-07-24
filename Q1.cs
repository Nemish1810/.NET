using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pareshsir
{
    internal class Q1
    {
        /// <summary>
        /// swap the valu of all parameter
        /// </summary>
        /// <param name="x">this is a first parameter</param>
        /// <param name="y">this is a second parameter</param>
        static void Swap(ref int x, int y )
        {
            //x = 100;
            //y = 200;
            
        }
        static void Main()
        {
            int a, b;
            
            a = 10;
            b = 20;
            
            Console.WriteLine("befor change");
            Console.WriteLine(".............");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Swap(ref a, b); // passing a as a refernce and b as value
            Console.WriteLine("after change");
            Console.WriteLine(".............");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }
    }
}
