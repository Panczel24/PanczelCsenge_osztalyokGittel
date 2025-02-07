namespace PanczelCsenge_osztalyokGittel
{
	internal class Program
	{
		static void Main(string[] args)
		{

            //Konyves();
            //Filmes();
            //Jatekkarakterek();
            //Urhajozas();
            Kemkedes();

            
        }



		static void Konyves()
		{
			Konyv konyv1 = new Konyv("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Konyv konyv2 = new("Ez még készül", "Én"); //ki lehet hagyni a konyv-classt, elég a new

			Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(100);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + "ennyi oldal maradt:" + konyv1.HanyOldalMaradt(20));

		}

		static void Filmes()
		{
            Console.WriteLine();
            Console.WriteLine("Film");

            Film film1 = new Film("Életrevalók", "Olivier Nakache", 108, "életrajzi dráma", true);
            Film film2 = new Film("Az élettörténetem", "Én");
            Console.WriteLine(film1.ToString() + "\n" + film2.ToString());
            Console.WriteLine();
            Console.WriteLine($"ELezdődött-e a film?:  \n  {film1.Cim} - {film1.Jatszas()}, {film2.Cim} - {film2.Jatszas()} ");
            Console.WriteLine("\n" + film1.ToString() + "\n" + "új hossz:" + film1.HosszNovelese(20) + ", új műfaj:" + film1.MufajModositas("komédia"));

        }

		static void Jatekkarakterek()
		{
            Console.WriteLine();
            Console.WriteLine("Videojatek karakter");
            VideojatekKarakter karakter1 = new("Zebra", 20, 100, 50);
            VideojatekKarakter karakter2 = new("Tigris", 70);
            Console.WriteLine(karakter1.ToString() + "\n" + karakter2.ToString());
            Console.WriteLine();
            Console.WriteLine("\n" + karakter1.ToString() + "\n" + karakter1.Tamadas() + ",ennyi életereje van:" + karakter1.Gyogyulas(20));
            Console.WriteLine(karakter1.Nev + "," + karakter1.Szintlepes());

        }

        static void Urhajozas()
        {
            Console.WriteLine();
            Console.WriteLine("Űrhajózás");
            Urhajo urhajo1 = new("Comet", 50, 6, 70);
            Urhajo urhajo2 = new("Star", 10);
            Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());
            Console.WriteLine();
            Console.WriteLine(urhajo2.ToString() + "\n az indulás után " + urhajo2.Indulas() + ",tankolás után:" + urhajo2.Tankolas(20) +", landoláskor ekkora a sebessége: " + urhajo2.Landolas());
        }

        static void Kemkedes()
        {
            Console.WriteLine();
            Console.WriteLine("Kémküldetés");
            KemKuldetes kem1 = new("SlimSloth", "Magyaroszág", 60, 40);
            Console.WriteLine(kem1.ToString() );
            kem1.SikerEselyNovelese(30);
            KemKuldetes kem2 = new("SadFish", "Horvátország");
            Console.WriteLine($"{kem1.Kodnev} esélye, miután növekedett: {kem1.SikerEsely}");
            Console.WriteLine();
            Console.WriteLine(kem2.ToString());
            Console.WriteLine("Elindult-e a küldetés?" + kem2.KuldetesInditasa() + kem2.ToString() + "\n ekkora lett a veszélyszintje " + kem2.VeszelySzintNovelese(20)  +"%" );
        }

    }
}
