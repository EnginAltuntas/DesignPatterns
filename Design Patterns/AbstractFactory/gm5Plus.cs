using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory
{
    class gm5Plus : Telefon
    {
        private string model;
        private string batarya;
        private int en;
        private int boy;
        public gm5Plus(string model,string batarya,int en,int boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
        }

        public override string ToString()
        {
            return "model: " + model + " batarya kapasitesi: " + batarya + " en:" + en + " boy: " + boy;
        }

        public string getBatarya()
        {
            return batarya;
        }

        public int getBoy()
        {
            return boy;
        }

        public int getEn()
        {
            return en;
        }

        public string getModel()
        {
            return model;
        }
    }
}
