using NYPLab_2026_11_24.Services;

namespace NYPLab_2026_11_24;
// SRP: Bir sınıfın bir sorumluluğu olmalı
// O/C: Yeni davranışları açık, sürekli değişime kapalı.
// DIP: Üst sınıflar doğrudan somut sınıflara bağlı olmamalı
// LSP: Alt sınıflar üst sınıf yerine kullanıldığında programın beklenilen davranışı bozulmamalı.
// ISP: Bir sınıf kullanmadığı methodları implement etmek zorun bırakılmamalı.

class Program
{
    static void Main(string[] args)
    {
        IBildirimServisi sms = new SmsServisi();
        IBildirimServisi email = new EmailServisi();
        IBildirimServisi mobil = new MobilBildirimServisi();
        
        SiparisServisi s1 = new SiparisServisi(sms);
        SiparisServisi s2 = new SiparisServisi(email);
        SiparisServisi s3 = new SiparisServisi(mobil);
        
        s1.SiparisOlustur("Laptop");
        Console.WriteLine("===================================");
        s2.SiparisOlustur("Telefon");
        Console.WriteLine("===================================");
        s3.SiparisOlustur("Çanta");
        

    }
}