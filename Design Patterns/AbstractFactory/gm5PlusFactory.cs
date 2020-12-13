using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    class gm5PlusFactory : telFactory
    {
        public Telefon getTelefon(string model, string batarya, int en, int boy)
        {
            return new gm5Plus(model, batarya, en, boy);
        }
    }
}
