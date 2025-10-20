namespace doga10._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Darusauto d1 = new Darusauto("teherautó", true, "Volvo", "piros", "EOS-230");
            d1.Tomeg = "10 t";
            d1.Kerekekszama = 6;
            Darusauto d2 = new Darusauto("teherautó", true, "Rába MAN", "piros", "AVG-210");
            d2.Tomeg = "9 t";
            d2.Kerekekszama = 6;
            Darusauto d3 = new Darusauto("teherautó", true, "Mercedes", "kék", "EGS-200");
            d3.Tomeg = "6 t";
            d2.Kerekekszama = 6;

            Console.WriteLine(d1);
        }
    }
}
