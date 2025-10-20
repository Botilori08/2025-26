using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga10._20
{
    internal class Darusauto:Teherauto
    {
        private string tipus;
        private bool terepes = true;

        public string marka;
        public string szin;
        public string rendszam;
        public Darusauto(string tipus, bool terepes, string marka,string szin, string rendszam) : base(tipus,terepes)
        {
            this.marka = marka;
            this.szin = szin;
            this.rendszam = rendszam;
        }

        public string Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }
        public bool Terepes
        {
            get { return terepes; }
            set { terepes = value; }
        }

        public override void elindul()
        {
            Console.WriteLine("Tütütütütütüütűűűűű!!!!!!");
        }

        public override string ToString()
        {
            string szoveg = $"{marka}-{rendszam}, színe: {szin} \n {Tipus}, Kerekek száma: {Kerekekszama}, Tömege: {Tomeg}";

            if (Terepes == true)
            {
                szoveg += "\n A teherautó terepes";
            }
            else
            {
                szoveg += "\n A teherautó nem terepes";
            }

            return szoveg;
        }

    }
}
