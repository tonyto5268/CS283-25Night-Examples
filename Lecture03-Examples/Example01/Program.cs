using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator A = new Calculator();
            
            Console.WriteLine(A.Add(2,3));
            for (int i = 1; i < 5; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
