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
            Console.Write("請輸入數字1:");
            int num1 = 0;
            int.TryParse(Console.ReadLine(),out num1);
            Console.Write("請輸入數字2:");
            int num2 = 0;
            int.TryParse(Console.ReadLine(),out num2);
            Console.WriteLine("{0}+{1}={2}",num1,num2,num1+num2);
        }
    }
}
