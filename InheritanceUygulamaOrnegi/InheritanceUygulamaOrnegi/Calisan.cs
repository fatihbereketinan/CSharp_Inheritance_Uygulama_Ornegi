using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceUygulamaOrnegi
{
    public class Calisan //SuperClass //BaseClass
    {
        private int id;  //propertyler private erişim belleyicisi ile tanımlandı. 
        private string isim;
        private string soyisim;

        public Calisan(int id, string isim, string soyisim) //Yapıcı metot ile propertylere atama yaptık.
        {
            this.id = id;     //this: şuan üzerinde çalışan classı temsil ediyor.
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public int getId()   //Encapsulation ile get-set bloklar kullanılarak private propertylere dışarıdan ulaşılabildi.
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public void bilgileriGoster() //Çalışan bilgilerini gösteren metot tanımlandı.
        {
            Console.WriteLine("İd : "+this.id);
            Console.WriteLine("İsim : "+this.isim);
            Console.WriteLine("Soyisim : "+this.soyisim);
        }
    }
}
