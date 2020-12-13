using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory
{
    class telefonFabrikasi
    {
        public static Telefon getTelefon(string model,string batarya,int en,int boy)
        {
            Telefon telefon;
            if("gm5Plus"==model)
            {
                telefon = new gm5Plus(model, batarya, en, boy);
            }
            else if("gm20Pro"==model)
            {
                telefon = new gm20Pro(model, batarya, en, boy);
            }
            else
            {
                throw new Exception("Geçersiz marka telefon");
            }


            return telefon;

        }
        


    }
}
