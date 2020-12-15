using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    class EmlakciMain
    {
        static void Main(string[] args)
        {
            Ev ev1 = EvBuild.NormalEvBuild("İstanbul","Kadıköy",3)
                .setBinaYili(1980)
                .build();

            printEv(ev1);

            Ev ev2 = EvBuild.DublexEvBuild("İzmir", "Karşıyaka", 5)
                .setHasHavuz(true)
                .build();
            printEv(ev2);

            Console.ReadLine();
        }
        private static void printEv(Ev ev)
        {
            Console.WriteLine(ev.ToString());
        }
    }
}
