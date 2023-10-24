using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR EACH
            string[] students = { "Ali", "Veli", "Can" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //DO WHILE
            int numberx = 10;
            do
            {
                Console.WriteLine(numberx);
                numberx--;
            } while (numberx >= 1);
           


            //WHILE
            int number = 100;
            while(number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }


            //FOR
           for (int i = 100; i >= 0; i=i-2) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!!");
            Console.ReadLine();
        }
    }
}
