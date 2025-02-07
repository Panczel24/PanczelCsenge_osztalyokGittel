using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanczelCsenge_osztalyokGittel
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int oldalszam;
		private int ar;
		
		
		//konstruktor

		//kijelölés, jobbklikk, quick actions, generate condtructor
		public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
		{
			this.cim = cim;  //a this.cim az a private string cim
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.oldalszam = oldalszam;
			this.ar = ar;
		}

		//alt+enter , generaTE CONSTRUCTOR, ÉS OTT KIVÁLASZTANI AMI KELL
		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEve = DateTime.Now.Year;
			oldalszam = 200;
			ar = 3000;
		}


		//property

		//kijelölés, jobbklikk, quick actions, encapsulate field (but still use field)
		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }
		public int Ar { get => ar; set => ar = value; }


		//metodusok

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			int csokkentes = Convert.ToInt32(ar * (szazalek / 100));
			ar -= csokkentes;
		}

		public int HanyOldalMaradt(int elolvasott)
		{
			return oldalszam - elolvasott;
		}


		//Tostring

		// jobbklikk üres sorra, quick actions, generate overrides, és ott kiválasztjuk hogy csak tostring
		public override string? ToString() //kérdőjel azért van ott, ha lenne NULL érték akkor se hal meg, visszaad valamit
		{
			return $"{cim} - {szerzo} / oldalszám: {oldalszam} / kiadás éve: {kiadasEve} - ára: {ar}";
		}


		




	}
}
