using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukraszda
{
    public class Sutemeny
    {
        public string nev;
        public int ar;

        public Sutemeny(string sor)
        {
            string[] adatok = sor.Split(';');

            nev = adatok[0];
            ar = int.Parse(adatok[1]);
        }
    }
}
