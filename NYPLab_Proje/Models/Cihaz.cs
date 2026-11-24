namespace NYPLab_Proje.Models;
using NYPLab_Proje.Enums;

public class Cihaz
{
    public string Kimlik { get; private set; }
    public string Ad { get; private set; }
    public bool AcikMi { get; private set; }
    public CihazTuru CihazTuru { get; private set; }

    public Cihaz(string kimlik, string ad, CihazTuru cihazTuru)
    {
        if (string.IsNullOrEmpty(kimlik))
            throw new ArgumentException("Cihaz kimliği boş olamaz");
        if (string.IsNullOrEmpty(ad))
            throw new ArgumentException("Cihaz adı boş olamaz");
        
        Kimlik = kimlik.Trim();
        Ad = ad.Trim();
        CihazTuru = cihazTuru;
        AcikMi = false;
    }

    public void Ac()
    {
        if(AcikMi)
        {
            Console.WriteLine($"[{Kimlik}] {Ad} cihazı halihazırda açık..");
            return;
        }
        AcikMi = true;
        Console.WriteLine($"[{Kimlik}] {Ad} cihazı açıldı.");
    }
    
    public void Kapat()
    {
        if(!AcikMi)
        {
            Console.WriteLine($"[{Kimlik}] {Ad} cihazı halihazırda kapalı.");
            return;
        }
        AcikMi = false;
        Console.WriteLine($"[{Kimlik}] {Ad} cihazı kapatıldı.");
    }

    public void BilgileriGoster()
    {
        Console.WriteLine($"Cihaz Kimliği: {Kimlik}");
        Console.WriteLine($"Cihaz Adı: {Ad}");
        Console.WriteLine($"Cihaz Turu: {CihazTuru}");
        Console.WriteLine($"Cihaz Açık mı:  {AcikMi}");
        Console.WriteLine("=====================================");
    }
}