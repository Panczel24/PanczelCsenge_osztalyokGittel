namespace PanczelCsenge_osztalyokGittel
{
	internal class Program
	{
		static void Main(string[] args)
		{

            //Konyves();
            //Filmes();
            Jatekkarakterek();

            

            
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

    }
}
