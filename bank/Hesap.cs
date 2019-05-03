using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class Hesap
    {
        public string HesapNo { get; set; }
        public decimal gunlukParaLimiti = 750;
        public int HesapBakiyesi { get; set; }
        public string HesapOzeti { get; set; }
        public int EkHesap { get; set; }
        public Bakiye bakiye = new Bakiye();
        public Hesap()
        {
            HesapBakiyesi = bakiye.Balance;
            EkHesap = 1000;
            Random r = new Random();
            HesapNo = r.Next(100, 1000000000).ToString();

        }


    }
}
