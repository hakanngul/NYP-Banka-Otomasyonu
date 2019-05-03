using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class BireyselMusteri : Musteri
    {
        public Banka Banka;

        public BireyselMusteri()
        {
        }

        public BireyselMusteri(Banka Banka)
        {
            this.Banka = Banka;
        }

    }
     
    
}
