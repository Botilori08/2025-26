namespace _09._03_2nd
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Kérjünk be egy számot annyi 1-5 random számot , kiírni az átlagot

			List <string> tantargyak = new List <string> ();
			List <List <int>> jegyek = new List <List <int>> ();
			List <int> temp = new List <int> ();
			Random rand = new Random();
			int darab = 0;
			string tantargy = "barack";
			while( tantargy != "")
			{
				Console.Write("Kérek egy számot!: ");
				darab = Convert.ToInt32(Console.ReadLine());
				Console.Write("Kérek egy tantárgynevet!: ");
				tantargy = Console.ReadLine();
				for (int i = 0; i < darab; i++)
				{
					temp.Add(rand.Next(1, 6));
				}
				jegyek.Add(temp);
				tantargyak.Add(tantargy);
			}


			for(int i = 0;i < jegyek.Count;i++)
			{
				for(int j = 0; j < jegyek[i].Count;j++)
				{
					Console.WriteLine(jegyek[i][j]);
				}
			}
			for(int i = 0;i < tantargyak.Count;i++)
			{
				Console.WriteLine(tantargyak[i]);
			}
			
			/*
			 * 
			Console.Write("Kérek egy számot!: ");
			int darab = Convert.ToInt32(Console.ReadLine());
			Random rand = new Random();

			List <int> jegyek = new List<int>();
			for (int i = 0; i < darab; i++)
			{
				jegyek.Add(rand.Next(1,6));
			}
			
			for(int i = 0;i < jegyek.Count;i++)
			{
				Console.WriteLine(jegyek[i]);
			}

			Console.WriteLine();

			
			double jegyosszeg = 0;
			for(int i = 0;i < jegyek.Count;i++)
			{
				jegyosszeg += jegyek[i];
			}

			double atlag = jegyosszeg/jegyek.Count;

			Console.WriteLine(Math.Round(atlag,2));*/
			
			//Console.WriteLine(Math.Round(jegyek.Average(),2));


		}
	}
}
