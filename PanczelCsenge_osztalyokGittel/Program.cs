namespace PanczelCsenge_osztalyokGittel
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new Konyv("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500 );
			Konyv konyv2 = new ("Ez még készül", "Én" ); //ki lehet hagyni a konyv-classt, elég a new

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(100);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + "ennyi oldal maradt:" + konyv1.HanyOldalMaradt(20));


		}
	}
}
