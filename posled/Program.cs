using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posled
{
    class Program
    {
        static void Main(string[] args)
        {
            int basicNumber = 5;
            int finishNumber = 96;
            int step = 7;

            for (int i = basicNumber; i <= finishNumber; i+=step)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
