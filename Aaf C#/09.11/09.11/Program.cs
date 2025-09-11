using System.Text;

namespace _09._11
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //1 fájl fiúnevek
            //1 fájl lánynevek
            //1 fájl vezetéknevek
            // 1 fájlba kiírni

            string[] fiunevek = File.ReadAllLines("fiuk.txt", Encoding.UTF8);
            string[] lanynevek = File.ReadAllLines("lanyok.txt", Encoding.UTF8);
            string[] vezeteknevek = File.ReadAllLines("vezeteknevek.txt", Encoding.UTF8);

            Random rand = new Random();
            StreamWriter sr = new StreamWriter("teljesNevek.txt");

            int valaszt = rand.Next(0,1);

            List <string> nevek = new List<string>();
            string teljesNev = "";

            for (int i = 0; i < 200; i++)
            {
                if (valaszt == 0)
                {
                    teljesNev += vezeteknevek[rand.Next(0, vezeteknevek.Length)]+ " ";
                    teljesNev += fiunevek[rand.Next(0, fiunevek.Length)];
                    nevek.Add(teljesNev);
                    teljesNev = "";
                }
                else
                {
                    teljesNev += vezeteknevek[rand.Next(0, vezeteknevek.Length)] + " ";
                    teljesNev += lanynevek[rand.Next(0, lanynevek.Length)];
                    nevek.Add(teljesNev);
                    teljesNev = "";
                }

                
            }

            for (int i = 0; i < nevek.Count; i++)
            {
                sr.WriteLine(nevek[i]);
            }
            sr.Close();







        }
	}
}
