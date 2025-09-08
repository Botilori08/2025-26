namespace _12_000_szám
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();

			List <long> szamok = new List<long>();

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

			for (int i = 0; i < beolvasottSzamok.Length; i++)
			{
				szamok.Add(long.Parse(beolvasottSzamok[i]));
			}

			long legnagyobb= 0;
			long legkisebb = szamok[0];

			for (int i = 0; i < szamok.Count; i++)
			{
				if
			}


			
		}
	}
}
