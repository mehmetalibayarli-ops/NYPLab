namespace NYPLab_2026_11_24.Services;

public class SiparisServisi
{
    private IBildirimServisi bildirimServisi;

    public SiparisServisi(IBildirimServisi bildirimServisi)
    {
        this.bildirimServisi = bildirimServisi;
    }

    public void SiparisOlustur(string urunAdi)
    {
        Console.WriteLine($"{urunAdi} siparişi oluşturuldu");
        bildirimServisi.Gonder("Siparişiniz başarıyla oluşturuldu.");
        
    }
}