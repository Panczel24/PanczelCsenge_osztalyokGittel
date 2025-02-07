using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanczelCsenge_osztalyokGittel
{
	internal class Film
	{
		//ezt kell kijelölni
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;
				

		//konstruktor
		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;  
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			hosszPercekben = 120;
			mufaj = "Ismeretlen";
			megjelent = false;
		}

		//property
		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }

		//metodus
		public string Jatszas()
		{
			if (megjelent == true)
			{
                return ("A film elkezdődött");
			}
			else
			{
				return ("A film nem kezdődött el");
			}
		}

		public string MufajModositas(string ujMufaj)
		{
			return mufaj = ujMufaj;
		}

		public int HosszNovelese(int percek)
		{
			return hosszPercekben += percek;
		}

		public override string? ToString()
		{
			 return $"{cim} - {rendezo} / hossz: {hosszPercekben} / műfaj: {mufaj} - megjelent: {megjelent}";;
		}


		//tostring


	}
}
