using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class new_feature
    {
        static public void cycle()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Вывожу 10 раз одно и то же");
                int count = cycle_counter(i);
                Console.WriteLine(count.ToString() + "-ый раз цикл");
            }
        }
        static int cycle_counter(int i)
        {
            return i + 1;
        }
    }
}
