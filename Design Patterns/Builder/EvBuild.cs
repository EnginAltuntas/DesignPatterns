using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    class EvBuild
    {
        private string il;
        private string ilce;
        private string mahalle;

        private int binaYili;
        private int odaSayisi;

        private bool isDublex;
        private bool hasHavuz;

        public static EvBuild NormalEvBuild(string il,string ilce,int odaSayisi)
        {
            EvBuild evbuild = new EvBuild();
            evbuild.il = il;
            evbuild.ilce = ilce;
            evbuild.odaSayisi = odaSayisi;

            return evbuild;
        }
        public static EvBuild DublexEvBuild(string il, string ilce, int odaSayisi)
        {
            EvBuild evbuild = new EvBuild();
            evbuild.il = il;
            evbuild.ilce = ilce;
            evbuild.odaSayisi = odaSayisi;
            evbuild.isDublex = true;

            return evbuild;
        }
        public Ev build()
        {
            Ev ev = new Ev();
            ev.setIl(il);
            ev.setIlce(ilce);
            ev.setMahalle(mahalle);
            ev.setBinaYili(binaYili);
            ev.setOdaSayisi(odaSayisi);
            ev.setIsDublex(isDublex);
            ev.setHasHavuz(hasHavuz);

            return ev;
        }


        public EvBuild setMahalle(string mahalle)
        {
            this.mahalle = mahalle;
            return this;
        }
        public EvBuild setBinaYili(int binaYili)
        {
            this.binaYili = binaYili;
            return this;
        }
        public EvBuild setIsDublex(bool isDublex)
        {
            this.isDublex = isDublex;
            return this;
        }
        public EvBuild setHasHavuz(bool hasHavuz)
        {
            this.hasHavuz = hasHavuz;
            return this;
        }


    }
}
