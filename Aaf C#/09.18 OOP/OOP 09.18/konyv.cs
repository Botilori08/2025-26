using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_09._18
{
	internal class konyv
	{

		public string cim;
		public string szerzo;

		public konyv(string cim, string szerzo) 
		{
			this.cim = cim;
			this.szerzo = szerzo;

		}

        public override string ToString()
        {
            return this.cim + "("+this.szerzo+")";
        }
	}
}
