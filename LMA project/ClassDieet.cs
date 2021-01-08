using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMA_project
{
    class ClassDieet
    {
        public  enum Vlees {Lam = 300, kip = 250, vis = 219, kalf = 123 }
        private enum Groente{sla, komkommer, tomaat, aardappel }
        private enum Fruit {banaan, appel, druif, aardbei }
        private enum Dranken {water, melk, fruitsap, koffie }
    
        public int Eenheid (int eenheid, int  soorvlees)
        {
            int result = eenheid * soorvlees;

            return result;
        }
            



    }
}
