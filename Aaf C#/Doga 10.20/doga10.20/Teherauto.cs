using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace doga10._20
{
    abstract internal class Teherauto:IGepjarmu
    {
        private string tipus;
        private bool terepes = true;
        public Teherauto(string tipus, bool terepes)
        {
            this.tipus = tipus;
            this.terepes = terepes;
        }

        public bool Terepes
        { 
            get { return terepes; } 
            set { terepes = value; }
        }
        public string Tipus
        {
            get { return tipus; }
        }


        private string tomeg;
        public string Tomeg
        {
            get { return tomeg; }
            set { tomeg = value; }
        }

        private int kerekekszama;
        public int Kerekekszama
        {
            get { return kerekekszama; }
            set { kerekekszama = value; }
        }

        abstract public void elindul();


    }
}
