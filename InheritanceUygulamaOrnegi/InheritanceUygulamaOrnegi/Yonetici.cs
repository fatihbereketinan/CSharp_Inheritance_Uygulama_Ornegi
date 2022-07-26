using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceUygulamaOrnegi
{
    class Yonetici : Calisan //Yonetici sınıfı Calisan sınından miras aldı //SubClass
    {
        private int sorumluKisiSayisi; //property tanımlandı.
        //Yazilimci sınıfında yapılan işlemlerin aynısı yapıldı.
        public Yonetici(int id, string isim, string soyisim, int sorumluKisiSayisi) : base(id, isim, soyisim)
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void zamYap(int zamMiktari) //metod tanımlandı.
        {
            Console.WriteLine(getIsim()+" "+"çalışanlara"+" "+zamMiktari+" "+"TL zam yaptı.");
        }
    }
}
