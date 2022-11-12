using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
	class Insel {
		private string name;
		private Pirat pp;
		private Strand strand = new Strand ( );
		private Kneipe kneipe = new Kneipe ( );

		public Insel ( string s) {
			name = s;
        }

		public void SetName ( string s ) {
			name = s;
		}

		public string GetName ( ) {
			return name;
		}

		public void SetPirat ( Pirat p ) {
			pp = p;
		}

		public Pirat GetPP ( ) {
			return pp;
		}

		public void SetStrand ( Strand s ) {
			strand = s;
		}

		public Strand GetStrand ( ) {
			return strand;
		}

		public void SetKneipe ( Kneipe k ) {
			kneipe = k;
		}

		public Kneipe GetKneipe ( ) {
			return kneipe;
		}
	}

}
