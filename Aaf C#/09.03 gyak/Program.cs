namespace _09._03_gyak
{
    internal class Program
    {
        static void elsotiztobbszoros(int szam)
        {
            int[] szorzok = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> tobbszorosok = new List<int>();
            for (int i = 0; i < szorzok.Length; i++)
            {
                tobbszorosok.Add(szam * szorzok[i]);
            }

            for (int i = 0; i < tobbszorosok.Count; i++)
            {
                Console.WriteLine(tobbszorosok[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot!: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            elsotiztobbszoros(szam);

            //piramis rajzolása

            Console.Write("Milyen magas legyen a piramis?");
            int magassag = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= magassag; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                /*for(int j = magassag; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();*/
            }

        }
    }
}
