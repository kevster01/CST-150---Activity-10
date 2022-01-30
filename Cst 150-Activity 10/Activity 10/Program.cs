
//Corrected by Kevin Reynoso
//Kevin Reynoso//CST 150//1/29/22//This is my own work
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I found a fundamental error when creating a set object. It is necessary
            //to attach a namespace from where to pull the information from. 
            //"make some sets"
            //Set A = new Set();
            //Set B = new Set();
            CST117_IC08_console.Set A = new CST117_IC08_console.Set();
            CST117_IC08_console.Set B = new CST117_IC08_console.Set();
            
            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}




