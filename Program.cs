using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Please enter a number a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number b");
            b = Convert.ToInt32(Console.ReadLine());
            /*if (a%b == 0) // ex.1
            {
                Console.WriteLine("a dividing by b");
            }
            else
            {
                Console.WriteLine("a not dividing by b");

            }*/
            /*int sum = a + b; //ex.2
            double avr = sum / 2.0;
            Console.Write("sum: ");
            Console.WriteLine(sum);
            Console.Write("average: ");
            Console.WriteLine(avr);*/

            /*int sum = 0; //ex.3
            while (a>0)
            {
                sum += a;
                a = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("sum: ");
            Console.WriteLine(sum);*/

            /*int m = 2;//ex.4
            while (a % m != 0 && m<a)
            {
                m= m+1;
            }
            if (m < a)

            {
                Console.WriteLine("not first");
            }
            else
            {
                Console.WriteLine("first");
            }*/
            /*int mul = 1;//ex.6
            while (a>= 1)
            {
                mul *= a;
                a--;

            }
            Console.WriteLine(mul);*/
            /*int sum = 0; //ex.7
            while (b>=1)
            {
                sum += a;
                b--;

            }
            Console.WriteLine(sum);*/

        }
    }
}
