using NYPLab_Proje.Enums;
using NYPLab_Proje.Models;


namespace NYPLab_Proje;

class Program
{
    static void Main(string[] args)
    {
        List<Cihaz> cihazlar = new List<Cihaz>();
        cihazlar.Add(new Cihaz("1", "Salon Lambası", CihazTuru.Lamba));
        cihazlar.Add(new Cihaz("2", "Oturma Odası Kliması", CihazTuru.Klima));

        try
        {
            while (true)
            {
                Console.WriteLine("---====AKILLI EV SİSTEMİ====---");
                Console.WriteLine("1- Cihazları Listele");
                Console.WriteLine("2- Cihaz Ekle");
                Console.WriteLine("3- Cihaz Aç");
                Console.WriteLine("4- Cihaz Kapat");
                Console.WriteLine("0- Çıkış Yap");
                Console.Write("\nLütfen yapmak istediğiniz işlemi giriniz: ");

                int secim;
                while (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.WriteLine("HATA: Geçersiz Giriş");
                    Console.Write("Lütfen geçerli bir işlem giriniz: ");
                }

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("=====================================");
                        foreach (var cihaz in cihazlar)
                        {
                            cihaz.BilgileriGoster();
                        }

                        break;
                    case 2:
                        Console.Write("Eklemek istediğiniz cihazın kimliğini giriniz: ");
                        string kimlik = Console.ReadLine();

                        bool kimlikVar = false;
                        foreach (var cihaz in cihazlar)
                        {
                            if (cihaz.Kimlik == kimlik)
                            {
                                kimlikVar = true;
                                break;
                            }
                        }

                        if (kimlikVar)
                        {
                            Console.WriteLine("HATA: Aynı kimlikte cihaz mevcut.");
                            break;
                        }

                        Console.Write("Eklemek istediğiniz cihazın adını giriniz: ");
                        string ad = Console.ReadLine();

                        Console.Write("Eklemek istediğiniz cihazın türünü seçiniz: ");
                        Console.WriteLine();
                        foreach (CihazTuru tur in Enum.GetValues(typeof(CihazTuru)))
                        {
                            Console.WriteLine($"{(int)tur} - {tur}");
                        }

                        int turSecim;
                        while (!int.TryParse(Console.ReadLine(), out turSecim))
                        {
                            Console.Write("Geçersiz tür! Listeden bir numara seçiniz: ");
                        }

                        CihazTuru secilenTur = (CihazTuru)turSecim;
                        cihazlar.Add(new Cihaz(kimlik, ad, secilenTur));
                        break;

                    case 3:
                    {
                        Console.WriteLine("Açmak istediğiniz cihazın kimliğini giriniz: ");
                        string tempKimlik = Console.ReadLine();
                        bool bulundu = false;

                        foreach (var cihaz in cihazlar)
                        {
                            if (cihaz.Kimlik == tempKimlik)
                            {
                                cihaz.Ac();
                                bulundu = true;
                                break;
                            }
                        }

                        if (!bulundu)
                            Console.WriteLine("HATA: Mevcut olmayan cihaz !");
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("Kapatmak istediğiniz cihazın kimliğini giriniz: ");
                        string tempKimlik = Console.ReadLine();
                        bool bulundu = false;

                        foreach (var cihaz in cihazlar)
                        {
                            if (cihaz.Kimlik == tempKimlik)
                            {
                                cihaz.Kapat();
                                bulundu = true;
                                break;
                            }
                        }

                        if (!bulundu)
                            Console.WriteLine("HATA: Mevcut olmayan cihaz !");
                        break;
                    }

                    case 0:
                    {
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    }
                    default:
                        Console.WriteLine("HATA: Geçersiz işlem numarası.");
                        break;
                }


            }
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
        
    }
}