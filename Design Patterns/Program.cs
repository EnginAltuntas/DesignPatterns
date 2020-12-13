using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Singleton s = Singleton.getSıngleton();
            }


            Console.ReadKey();
        }
        
    }
}
