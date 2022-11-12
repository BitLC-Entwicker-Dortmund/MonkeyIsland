using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
	class Kneipe {
		private Pirat pp;

		public void NimmMichAuf ( Pirat p ) {
			pp = p;
			p.GetInsel ( ).GetStrand ( ).SetNullPP ( );
            Console.WriteLine ("Ein Hallo aus der Kneipe von {0} von der {1}",p.GetName(), p.GetMeer().GetInseln()[0].GetName() );
		}

		public Pirat GetPP ( ) {
			return pp;
		}

		public void SetNullPP ( ) {
			pp = null;
		}
	}
}

