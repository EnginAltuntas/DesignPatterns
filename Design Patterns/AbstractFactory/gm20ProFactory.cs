using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    class gm20ProFactory : telFactory
    {
        public Telefon getTelefon(string model, string batarya, int en, int boy)
        {
            return new gm20Pro(model, batarya, en, boy);
        }
    }
}
