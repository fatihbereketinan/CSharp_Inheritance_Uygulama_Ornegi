using System;

namespace InheritanceUygulamaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz...Lütfen bir işlemi seçiniz.");

            while (true)
            {
                Console.WriteLine("1- Yazılımcı işlemleri ");
                Console.WriteLine("2- Yönetici İşlemleri ");
                Console.WriteLine("Çıkış için Q tuşuna basınız");
                string secilenİslem = Console.ReadLine();

                if (secilenİslem == "Q")
                {
                    Console.WriteLine("Programdan çıkış yapılıyor...");
                    break;
                }
                else if (secilenİslem=="1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "Fatih", "İnan", "Java, C#");

                    while (true)
                    {
                        Console.WriteLine("Yazılımcı işlemini seçiniz: ");
                        Console.WriteLine("1- Format at");
                        Console.WriteLine("2- Yazılımcı bilgilerini göster");
                        Console.WriteLine("Çıkış için Q tuşuna basınız");
                        string yazilimciİslem = Console.ReadLine();

                        if (yazilimciİslem=="Q")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if (yazilimciİslem=="1")
                        {
                            Console.Write("İşletim sistemini giriniz: ");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if (yazilimciİslem=="2")
                        {
                            yazilimci.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz ! ");
                        }
                    }
                }
                else if (secilenİslem=="2")
                {
                    Yonetici yonetici = new Yonetici(2, "Fatih", "İnan", 50);

                    while (true)
                    {
                        Console.WriteLine("Yönetici işlemini seçiniz: ");
                        Console.WriteLine("1- Zam Yap");
                        Console.WriteLine("2- Yönetici bilgilerini göster");
                        Console.WriteLine("Çıkış için Q tuşuna basınız");
                        string yoneticiİslem = Console.ReadLine();

                        if (yoneticiİslem=="Q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if (yoneticiİslem=="1")
                        {
                            Console.Write("Zam miktarını giriniz: ");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zamMiktari);
                        }
                        else if (yoneticiİslem=="2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz ! ");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir işlem giriniz ! ");
                }
            }
        }
    }
}
