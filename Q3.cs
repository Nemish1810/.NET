using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pareshsir
{
    internal class Q3
    {
        private int ID;
        private string FIrstName;
        private string LastName;

        public string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
           
            return this.ID;
        }

        class PropertyDemo
        {
            static void Main()
            {
                Q3 obj1 = new Q3();
                //obj1.ID = 1001;
                obj1.setID(1001);
                Console.WriteLine(obj1.getID());
                obj1.FirstName = "Ramesh";
                Console.WriteLine(obj1.FirstName);
            }
        }
    }
}
