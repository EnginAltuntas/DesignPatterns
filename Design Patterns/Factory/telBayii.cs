using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory
{
    class telBayii
    {
        static void Main(string[] args)
        {
            Telefon gm5 = telefonFabrikasi.getTelefon("gm5Plus", "3100mah", 6,8);
            Telefon gm20 = telefonFabrikasi.getTelefon("gm20Pro", "5000mah", 7, 9);

            Console.WriteLine("Gm5 Plus: " + gm5);
            Console.WriteLine("Gm20 Pro: " + gm20);

            Console.ReadKey();
        }
    }
}
