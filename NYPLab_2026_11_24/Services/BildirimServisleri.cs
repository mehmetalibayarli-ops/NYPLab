namespace NYPLab_2026_11_24;

public class EmailServisi:IBildirimServisi,ILogable
{
    public  void Gonder(string text)
        => Console.WriteLine($"[E-Mail]: {text}");
    
    public void LogYaz(string text)
        => Console.WriteLine($"E-Mail Logu : {text}");
}

public class SmsServisi:IBildirimServisi
{
    public  void Gonder(string text)
        => Console.WriteLine($"[SMS]: {text}");
}

class MobilBildirimServisi:IBildirimServisi
{
    public void Gonder(string text)
        => Console.WriteLine($"[Mobil Bildirim]: {text}");
}

