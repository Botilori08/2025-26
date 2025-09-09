namespace Otoslotto
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateOnly datum = new DateOnly();

			List<int> szamok = new List<int>();
			for (int i = 1; i < 91; i++)
			{
				szamok.Add(i);
			}

			Random rand = new Random();
			int szam = 0;

			List<int> sorsolt = new List<int>();

			rand.Next(0, szamok.Count);


			while(sorsolt.Count < 5)
			{
				sorsolt.Add(szamok[rand.Next(0,szamok.Count)]);
				szam = szamok[rand.Next(0, szamok.Count)];
				if (szamok[rand.Next(0, szamok.Count)] == )

            }

			for(int i = 0;i < sorsolt.Count;i++)
			{
				Console.WriteLine(sorsolt[i]);
			}

			
			
		}
	}
}
