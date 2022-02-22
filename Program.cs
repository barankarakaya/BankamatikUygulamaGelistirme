using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikUygulamaGelistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;
            while (true)
            {
                Console.WriteLine("Lütfen Kullanici Adinizi Giriniz :");
                string kullanici_adi = Console.ReadLine();
                Console.WriteLine("Lütfen Şifrenizi Giriniz");
                string sifre = Console.ReadLine();

                if (kullanici_adi=="baran"&&sifre=="1453")
                {
                    Console.Clear();
                    int bakiye = 1000;
                    int vergi = 3;

                    Console.WriteLine("Atm 'Hoşgeldiniz!");
                    Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi seçiniz");
                    Console.WriteLine("1-Bakiye Sorgulama");
                    Console.WriteLine("2-Para Çekme");
                    Console.WriteLine("3-Para Yatırma");
                    Console.WriteLine("4-IBAN'a para yatırma");
                    Console.WriteLine("5-Fatura Yatırma");
                    Console.WriteLine("6-Şifre Değiştirme");
                    Console.WriteLine("7-Çıkış Yapma");
                    string secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                            Console.WriteLine("Bakiyeniz :" + bakiye);
                            break;
                        case "2":
                            Console.WriteLine("Lütfen Çekmek İstediğiniz tutarı giriniz");
                            int Cekilcek_tutar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yeni Bakiyeniz :" + (bakiye - Cekilcek_tutar));
                            int kalan = (bakiye - Cekilcek_tutar) - vergi;
                            if (Cekilcek_tutar > (bakiye - vergi) && Cekilcek_tutar < bakiye)
                            {
                                Console.WriteLine("Lütfen " + vergi + "TL değerindeki vergiyi de hesaplayınız.");
                            }
                            else if (Cekilcek_tutar >= 1000)
                            {
                                Console.WriteLine("Bakiyenizden fazla para çekemezsiniz !");
                            }
                            else if (Cekilcek_tutar < 5)
                            {
                                Console.WriteLine("Sadece Kağıt Para İle İşlem Yapabilirsiniz.");
                            }
                            else
                            {
                                Console.WriteLine("Çekilen vergi Ücreti " + vergi + "TL");
                                Console.WriteLine("Kalan para :" + kalan);
                            }
                            break;
                        case "3":
                            Console.WriteLine("Lütfen yatırmak İstediğiniz tutarı giriniz");
                            int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                            int toplam = bakiye + yatirilacak_tutar;
                            if (yatirilacak_tutar > 5)
                            {
                                Console.WriteLine("Toplam tutar :" + (toplam - vergi));
                                Console.WriteLine("Çekilen Vergi tutarı " + vergi + "TL");
                            }
                            else if (yatirilacak_tutar < 5)
                            {
                                Console.WriteLine("Sadece Kağıt Para İle İşlem Yapabilirsiniz");
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir tutar giriniz");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Lütfen para yatırmak istediğiniz hesabın İBAN numarasını yazınız");
                            string iban = Console.ReadLine();
                            Console.WriteLine(iban + "Numaralı Karta Para Yatırıyorsunuz. Emin misiniz ?");
                            Console.WriteLine("Evet ise :7 Hayır İse 8 'e basınız.");
                            string sonuc = Console.ReadLine();
                            switch (sonuc)
                            {
                                case "7":
                                    Console.WriteLine("Yatırmak İstediğiniz tutarı giriniz");
                                    int yatirilacal_tutar2 = Convert.ToInt32(Console.ReadLine());
                                    int vergi2 = (bakiye - yatirilacal_tutar2) - vergi;
                                    if (yatirilacal_tutar2 > 1000)
                                    {
                                        Console.WriteLine("Lütfen hesabınızda bulunan parayı aşmayacak şekilde bir tutar girin");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hesabınızda Kalan Para :" + vergi2);
                                    }
                                    break;
                                case "8":
                                    Console.WriteLine("Çıkış Yapılıyor...!");
                                    break;
                            }
                            break;
                        case "5":
                            int yatirilacak_fatura = 100;
                            Console.WriteLine("Faturanız  :" + yatirilacak_fatura);
                            Console.WriteLine("Lütfen Madeni Para Kullanmayınız");
                            Console.WriteLine("Parayı Hazneye Yerleştiriniz");

                            int yatirma = Convert.ToInt32(Console.ReadLine());
                            int bozukPara = yatirma - yatirilacak_fatura;
                            if (yatirilacak_fatura <= 100)
                            {
                                Console.WriteLine("Yatırdıgınız Miktar Faturayı Ödemeye yetmiyor :(");
                            }
                            else
                            {
                                Console.WriteLine("İşlem Tamamlanmıştır. Para Üstünüzü Alınız." + bozukPara);
                            }
                            break;
                        case "6":
                            int sifre2 = 1453;
                            Console.WriteLine("Lütfen Değiştirmek İstediğiniz sifreyi giriniz");
                            int yeni_sifre = Convert.ToInt32(Console.ReadLine());
                            if (yeni_sifre < 1000)
                            {
                                Console.WriteLine("Lütfen 4 Haneli Bir sifre giriniz");
                            }
                            else if (yeni_sifre > 9999)
                            {
                                Console.WriteLine("Lütfen 4 Haneli Bir Şifre Girin.");
                            }
                            else
                            {
                                Console.WriteLine("Yeni Şifreniz " + sifre + "'den" + sifre2 + "'a Değiştirilmiştir");
                            }
                            break;
                        case "7":
                            Console.WriteLine("Çıkış Yapılıyor... Enis Bank İyi günler diler. :)");
                            break;
                        default:
                            Console.WriteLine("Lütfen Geçerli Bir Sayi Giriniz");
                            Console.WriteLine("Bu Sayi , 1, 2, 3, 4 sayiları olabilir Orn.");
                             
                            break;
                            if (true)
                            {
                                if (hak < 0)
                                {
                                    hak -= 1;
                                }
                                if (hak == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Kullanici adı veya sifreniz yanlış girdiniz");
                                }
                                if (hak == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Kullanıcı adı veya sifrenizi yanlıs girdiniz");
                                }
                                if (hak == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Hesabınız 1 saat  erişime kapatılmıştır.");
                                }
                                Console.WriteLine(hak + "Hakkınız Kaldı");
                            }
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
