namespace NYPLab_2026_11_17;

public class Araba
{
    public string Marka { get; set; }
    private Motor motor;

    public Araba(string marka,string motorModel,int beygirGucu)
    {
        if(string.IsNullOrEmpty(motorModel))
            throw new ArgumentNullException(nameof(motorModel),"Model boş olamaz.");
        Marka = marka.Trim();
        motor = new Motor(motorModel, beygirGucu);
    }

    public void Calistir()
    {
        Console.WriteLine($"[{Marka}] marka araba çalıştırıldı.");
        motor.Calistir();
    }

    public void BilgileriGetir()
    {
        Console.WriteLine("==========================");
        Console.WriteLine($"Marka : {Marka}");
        Console.WriteLine($"Motor Modeli :  {motor.Model}");
        Console.WriteLine($"Beygir gücü : {motor.BeygirGucu} HP");
        Console.WriteLine("==========================");
    }
}