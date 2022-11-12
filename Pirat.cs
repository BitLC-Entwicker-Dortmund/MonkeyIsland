using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
	class Pirat {
		private Insel insel;
		private string name;
		private Meer meer;

        public Pirat ( string name , Meer meer, Insel insel ) {
            this.name = name;
            this.insel = insel;
			this.meer = meer; // meine kleine Landkartenwelt ;-)
        }

        //public Pirat ( string name, Meer meer) {
        //	this.name = name;
        //	this.meer = meer;
        //      }

		public Meer GetMeer ( ) {
			return meer;
        }

        public Insel GetInsel ( ) {
			return insel;
		}

		public string GetName ( ) {
			return name;
		}

		public void GehInDieKneipe ( ) {
			insel.GetKneipe ( ).NimmMichAuf ( this );
		}

		public void GehZumStrand ( ) {
			insel.GetStrand ( ).NimmMichAuf ( this );
		}
	}

}
