using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_2
{
    class Sezione
    {
        public class Sezione
        {
            List<Sezione> sezioni = new List<Sezione>();
            List<Pagina> pagine = new List<Pagina>();

            internal Sezione() { }

            public string StampaSezione()
            {
                string testo = "Sezione\n";
                foreach (Sezione s in sezioni)
                {
                    testo += "- Sezione\n";
                    foreach (Pagina p in s.pagine)
                        testo += p.StampaPagina();
                    testo += "- Fine Sezione\n";
                }
                foreach (Pagina p in pagine)
                    p.StampaPagina();
                testo += "Fine Sezione\n";

                return testo;
            }
        }
    }
}