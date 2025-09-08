using System.Collections.Immutable;
using System;

namespace _12_000_szám
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();

			StreamWriter sr = new StreamWriter("22jegyuek.txt");
			
			string szam = "";

			for (int i = 0; i < 12000; i++)
			{
				for (int j = 0; j < 22; j++)
				{
					if(szam=="")
					{
                        szam += rand.Next(1, 10);
                    }
                    else
                    {
                        szam += rand.Next(0, 10);
                    }
                    
				}
				
				sr.WriteLine(szam);
				szam = "";
				
			}

            sr.Close();


            string[] beolvasottSzamok = File.ReadAllLines("22jegyuek.txt");

			List <string> szamok = new List <string>();



			for(int i = 0; i < beolvasottSzamok.Length;i++)
			{
				szamok.Add(beolvasottSzamok[i]);
			}

			var rendezett = beolvasottSzamok.ToImmutableSortedSet();

			string legnagyobb= rendezett[rendezett.Count-1];
			string legkisebb = rendezett[0];
			
			Console.WriteLine(legkisebb);
			Console.WriteLine(legnagyobb);

			int osszeg = 0;
			for(int i = 0;i < legkisebb.Length;i++)
			{
				for(int j = 0;j<legnagyobb.Length;j++)
				{
					osszeg = legkisebb[i] + legnagyobb[i];
				}
			}

            Console.WriteLine(osszeg);



			
		}
	}
}
