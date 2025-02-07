using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanczelCsenge_osztalyokGittel
{
	internal class VideojatekKarakter
	{//ezt kell kijelölni
		private string nev;
		private int szint;
		private int eletero;
		private int ero;


		//konstruktor
		public VideojatekKarakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}
		public VideojatekKarakter(string nev, int ero)
		{
			this.nev = nev;
			szint = 1;
			eletero = 100;
			this.ero = ero;
		}

		//property
		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }


		//metódus
		public string Tamadas()
		{
			return ($"a karakter támad, ennyi erővel: {ero}");
		}


		public int Gyogyulas(int mennyiseg)
		{
			return eletero += mennyiseg;
		}

		public string Szintlepes()
		{
           return $"Az életerőd ennyi lett: {eletero+=30}, szintet léptél eggyel, új szint: {szint+=1}"; 
		}

		//tostring
		public override string? ToString()
		{
			return $"{nev} , szint: {szint} / eleterő: {eletero} / ero: {ero} "; ;
		}
	}
}
