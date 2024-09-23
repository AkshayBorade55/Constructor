using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   
    public class CopyConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //Parametriesed constructor
        public CopyConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //copy constructor
        public CopyConstructorExample(string name, int age)
        {
            NameNew = name;
            AgeNew = age;
        
        
        }
           
        public void DisplayInfo()
        { 
         Console.WriteLine($"Name: {Name}, Age:{Age}");
        
        }

            
    
    
    }

    internal class CopyConstructor
    {

        static void Main()
        {
            //creating object with pass the value for parameterized constructor

            CopyConstructorExample obj = new CopyConstructorExample("Akshay", 25);
            obj.DisplayInfo();

            //creating another object using copy constructor
            CopyConstructorExample obj2 = new CopyConstructorExample();
            obj2.DisplayInfo();
        }

    }

}
