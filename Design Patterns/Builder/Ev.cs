using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    class Ev
    {
        private string il;
        private string ilce;
        private string mahalle;

        private int binaYili;
        private int odaSayisi;

        private bool isDublex;
        private bool hasHavuz;
        public Ev()
        {

        }

        public Ev(string il,string ilce,string mahalle,int binaYili,int odaSayisi,bool isDublex,bool hasHavuz)
        {
            this.il = il;
            this.ilce = ilce;
            this.mahalle = mahalle;
            this.binaYili = binaYili;
            this.odaSayisi = odaSayisi;
            this.isDublex = isDublex;
            this.hasHavuz = hasHavuz;
        }
        public override string ToString()
        {
            return "il: " + il + " ilçe: " + ilce + " mahalle: " + mahalle + " binaYili: " + binaYili + " odaSayisi: " + odaSayisi + " isDublex: " + isDublex + " hasHavuz " + hasHavuz;

        }

        public string getIl()
        {
            return il;
        }
        public void setIl(string il)
        {
            this.il = il;
        }
        public string getIlce()
        {
            return ilce;
        }
        public void setIlce(string ilce)
        {
            this.ilce = ilce;
        }
        public string getMahalle()
        {
            return mahalle;
        }
        public void setMahalle(string mahalle)
        {
            this.mahalle = mahalle;
        }
        public int getBinaYili()
        {
            return binaYili;
        }
        public void setBinaYili(int binaYili)
        {
            this.binaYili = binaYili;
        }
        public int getOdaSayisi()
        {
            return odaSayisi;
        }
        public void setOdaSayisi(int OdaSayisi)
        {
            this.odaSayisi = OdaSayisi;
        }
        public bool getIsDublex()
        {
            return isDublex;
        }
        public void setIsDublex(bool isDublex)
        {
            this.isDublex = isDublex;
        }
        public bool getHasHavuz()
        {
            return hasHavuz;
        }
        public void setHasHavuz(bool hasHavuz)
        {
            this.hasHavuz = hasHavuz;
        }

            
    }
}
