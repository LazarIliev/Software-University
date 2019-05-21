using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExerciseCSharp
{
    class Program
    {
        static void Main()
        {
            //new change
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",new string('*',n));

            for (int row = 0; row <n-2; row++)
            {
                Console.WriteLine("*{0}*",new string(' ',n-2));
            }

            Console.WriteLine("{0}",new string('*',n));
        }
    }
}
