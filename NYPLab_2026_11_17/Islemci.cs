namespace NYPLab_2026_11_17;

public class Islemci
{
    public string Model { get; set; }
    
    public int CekirdekSayisi { get; set; }

    public Islemci(string model, int cekirdekSayisi)
    {
        Model = model;
        CekirdekSayisi = cekirdekSayisi;
    }

    public void Calistir()
    {
        Console.WriteLine($"{Model} işlemci çalıştı.");
    }
}