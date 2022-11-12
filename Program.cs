using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland {
    class Program {
        static void Main ( string [ ] args ) {
            //Insel island = new Insel ( );
            //island.SetName ( "BitLC island" );
            //Pirat p = new Pirat ( "Rami" , island );
            //p.GehInDieKneipe ( );
            //p.GehZumStrand ( );
            Meer einesMehr = new Meer ( );

            //einesMehr.GetInseln ( )[0];
            Console.WriteLine ( einesMehr.GetInseln ( )[0].GetName());
            Console.WriteLine ( einesMehr.GetInseln ( )[1].GetName());

            Schiff meinSchiff = new Schiff ( "The black Selim" );
            einesMehr.SetSchiff ( meinSchiff );
            Console.WriteLine ( einesMehr.GetSchiff().GetSchiffsname());

            Pirat p = new Pirat ( "Rami" , einesMehr, einesMehr.GetInseln()[0] );
            p.GehInDieKneipe ( );
            p.GehZumStrand ( );

            Console.Read ( );
        }
    }
}
