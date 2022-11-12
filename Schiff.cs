using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
    class Schiff {
        private Pirat pp;
        private string name;

        public Schiff(string n) {
            name = n;
        }

        public string GetSchiffsname() {
            return name;
        }

        public Pirat GetPP ( ) {
            return pp;
        }

        public void NimmMichAuf ( Pirat p ) {
            pp = p;
            //p.GetInsel ( ).GetStrand ( ).SetNullPP ( );
        }

    }
}
