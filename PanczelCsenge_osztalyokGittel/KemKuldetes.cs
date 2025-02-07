using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanczelCsenge_osztalyokGittel
{
    internal class KemKuldetes
    {
        private string kodnev;
        private string orszag;
        private int veszelySzint;
        private double sikerEsely;


        //konstruktor
        public KemKuldetes(string kodnev, string orszag, int veszelySzint, double sikerEsely)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsely = sikerEsely;
        }
        public KemKuldetes(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            veszelySzint = 5;
            sikerEsely = 50;
        }

        //property
        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public double SikerEsely { get => sikerEsely; set => sikerEsely = value; }


        //metódusok
        public string KuldetesInditasa()
        {
            return(" A küldetés elkezdődött vele: "); 
        }

        public double VeszelySzintNovelese(int mennyiseg)
        {
            return veszelySzint += mennyiseg;
        }

        public void SikerEselyNovelese(double szazalek)
        {
            
            sikerEsely += sikerEsely*(szazalek/100);
        }

        //tostring
        public override string? ToString()
        {
            return $"név: {kodnev}, ország: {orszag}, veszélyszint: {veszelySzint}, sikerének esélye: {SikerEsely}%";
        }
    }
}
