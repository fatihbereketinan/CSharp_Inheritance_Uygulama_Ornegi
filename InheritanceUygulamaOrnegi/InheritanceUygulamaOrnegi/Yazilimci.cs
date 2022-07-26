using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceUygulamaOrnegi
{
    public class Yazilimci : Calisan //Yazilimci sınıfı Calisan sınıfından miras aldı.//SubClass
    {
        //base: miras alınan classın yapıcı metodunu temsil eder.
        //Yazilimci sınıfından alınan paremetler Calisan sınıfının yapıcı metoduna gönderildi.
        //Bu sayede Yazilimci sınıfından alından değerler Calisan sınıfının propertylerine atanmış olacak.

        private string diller; //property tanımlandı
        public Yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim)
        {
            this.diller = diller;
        }
        public void formatAt(string isletimSistemi) //metot tanımlandı.
        {
            Console.WriteLine(getIsim() + "şuanda"+" "+isletimSistemi+"işletim sistemi formatı atıyor..");
        }

    }
}
