namespace Béla
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List <string> szavak = new List <string> ();

			string szo = "alma";
			StreamWriter ir = new StreamWriter("szavak.txt");

			List <char> jokarakterek = new List<char>() { 'a','á','b','c','d','e','é','f','g','h','i','í','j','k','l','m','n','o','ó','ö','ő','p','q','r','s','t','u','ú','ü','ű','v','w','x','y','z'
			, 'A','Á','B','C','D','E','É','F','G','H','I','Í','J','K','L','M','N','O','Ó','Ö','Ő','P','Q','R','S','T','U','Ú','Ü','Ű','V','W','X','Y','Z'};

			while(szo != "")
			{
				Console.Write("Kérek egy szót: ");
				szo = Console.ReadLine();
				if (szo.All(jokarakterek.Contains))
				{
					szavak.Add(szo);
				}
				else
				{
					Console.WriteLine("Nem megfelelő szó!");
				}

			}



			szavak.Sort();
			szavak.Reverse();

			for (int i = 0; i < szavak.Count; i++)
			{
				ir.WriteLine(szavak[i]);
			}
			ir.Close();

			string[] beolvasott = File.ReadAllLines("szavak.txt");

			string fele = "";

			if(beolvasott.Length %2 != 0)
			{
				fele = beolvasott[beolvasott.Length/2];
			}
			else
			{
				fele = beolvasott[Convert.ToInt32(beolvasott.Length/2 - 0.5)];
			}

            Console.WriteLine("A lista közepe:"+fele);

			
		}
	}
}
