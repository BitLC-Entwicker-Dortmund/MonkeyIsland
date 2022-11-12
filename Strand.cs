using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
	class Strand {
		private Pirat pp;

		public void NimmMichAuf ( Pirat p ) {
			pp = p;
			p.GetInsel ( ).GetKneipe ( ).SetNullPP ( );
		}

		public Pirat GetPP ( ) {
			return pp;
		}

		public void SetNullPP ( ) {
			pp = null;
		}
	}

}
