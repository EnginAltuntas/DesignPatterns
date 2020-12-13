using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    interface telFactory
    {
        Telefon getTelefon(string model, string batarya, int en, int boy);
    }
}
