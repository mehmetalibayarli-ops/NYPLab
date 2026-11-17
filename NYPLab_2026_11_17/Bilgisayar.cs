namespace NYPLab_2026_11_17;

public class Bilgisayar
{
    public string Marka { get; set; }

    private Islemci islemci;
    

    public Bilgisayar(string marka, string islemciModeli, int cekirdekSayisi)
    {
        Marka=marka;
        islemci = new Islemci(islemciModeli, cekirdekSayisi); //Composition
    }
    
    public void Ac()
    {
        Console.WriteLine($"{Marka} bilgisayar açılıyor.");
        islemci.Calistir(); //Kendi içindeki nesnenin davranışını kullandı
        //Bir çeşit encapsulation
    }

    public void BilgilerGoster()
    {   
        Console.WriteLine("=================================");
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"İşlemci modeli: {islemci.Model}");
        Console.WriteLine($"İşlemci çekirdek sayısı: {islemci.CekirdekSayisi}");
        Console.WriteLine("=================================");
    }
    
}