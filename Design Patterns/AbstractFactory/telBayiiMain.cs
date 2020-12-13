using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    class telBayiiMain
    {
        static void Main(string[] args)
        {
            gm5PlusFactory _gm5 = new gm5PlusFactory();
            Telefon gm5 =_gm5.getTelefon("Gm5 Plus", "3100mah", 6, 7);
            gm20ProFactory _gm20 = new gm20ProFactory();
            Telefon gm20 = _gm20.getTelefon("Gm20 Pro", "4000mah", 8, 9);

            Console.WriteLine(gm5);
            Console.WriteLine(gm20);

            Console.ReadKey();
        }
    }
}
