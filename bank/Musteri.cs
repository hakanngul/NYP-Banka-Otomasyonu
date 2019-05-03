using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public abstract class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public long TCKimlik { get; set; }
        public int HesapNumarasi { get; set; }
        public string Tur { get; set; }
        public List<Hesap> Hesaplar = new List<Hesap>();
        public Musteri()
        {
        }
        public  void HesapKapatma(Hesap h)
        {
            Hesaplar.Remove(h);
        }
        
        public  void HesapAcma(Hesap h)
        {
            Hesaplar.Add(h);
        }
        public List<Hesap> HesapListele()
        {
            return Hesaplar;
        }


    }
}
