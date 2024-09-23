using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class DefaultConstructorExample
    {
        public int value;
        //default constructor
        public DefaultConstructorExample()
        {
            value = 15;

        }
        // create another
        public void Test()
        {
            Console.WriteLine("Test" + value);


        }

    }





    internal class defaultConstructor
    { 
        static void Main()
        {
            DefaultConstructorExample obj = new DefaultConstructorExample();
            Console.WriteLine(obj.value);
            obj.Test();
        }

    }
}
