using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
    class Meer {
        private Pirat pp;
        private Schiff spp;
        private Insel [ ] inseln = new Insel [ 2 ];

        public Meer ( ) {
            inseln [ 0 ] = new Insel ( "Insel Nordeney" );
            inseln [ 1 ] = new Insel ( "Insel Helgoland");
        }

        public void NimmMichAuf ( Pirat p ) {
            pp = p;
            //p.GetInsel ( ).GetStrand ( ).SetNullPP ( );
        }

        public Pirat GetPP ( ) {
            return pp;
        }

        public void SetSchiff(Schiff s) {
            spp = s;
        }

        public Schiff GetSchiff() {
            return spp;
        }

        public Insel[] GetInseln() {
            return inseln;
        }
    }
}
