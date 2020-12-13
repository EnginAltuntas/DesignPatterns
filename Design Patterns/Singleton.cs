using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Singleton
    {
        private static Singleton singleton = new Singleton();
        private static int sayi = 0;
        public Singleton()
        {
            Console.WriteLine("Constructor girildi");
        }
        public static Singleton getSıngleton()
        {
            if(singleton==null)
            {
                lock (singleton) //Multi Thread
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }
            }

            sayi++;
            Console.WriteLine(sayi);
            return singleton;
        }

    }
}
