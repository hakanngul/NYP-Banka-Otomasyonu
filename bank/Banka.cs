using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace bank
{
    public class Banka
    {
        public List<Musteri> Musteriler = new List<Musteri>();
        public void MusteriEkle(TicariMusteri t)
        {
            Musteriler.Add(t);

        }
        public void MusteriEkle(BireyselMusteri b)
        {
            Musteriler.Add(b);

        }
        public List<Musteri> MusteriListele()
        {
            return Musteriler;
        }

    }
}
