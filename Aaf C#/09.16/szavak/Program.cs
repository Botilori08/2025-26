namespace szavak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//bekérni szavakat amiben csak betű lehet
			// A jó szavakat tegyük bele listába, amíg be nem írja valaki hogy vége
			//hosszúság szerint állítsuk sorrendbe, majd hosszúságon belül ABC sorrendbe
			//file-ba kiírva

			string szo = "";

			List <string> szavak = new List<string>();

			StreamWriter sr = new StreamWriter("szavak.txt");

			while(szo != "vége")
			{
                Console.WriteLine("Kérek egy szót! ");
				szo = Console.ReadLine();

				if(szo.All(char.IsLetter) && szo.Length !=0)
				{
					szavak.Add(szo);
				}
                else
                {
                    Console.WriteLine("Csak betűkből álló szavakat fogadok el!");
                }
            }

			for(int i = 0; i < szavak.Count; i++)
			{
				int szama = i;
				for (int j = i+1; j < szavak.Count; j++)
				{
					if (szavak[i].Length > szavak[j].Length)
					{
						i = j;
					}
				}
				string legrovidebb = szavak[i];
				szavak[i] = szavak[szama];
                szavak[szama] = legrovidebb;

            }




		}
	}
}
