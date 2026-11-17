namespace NYPLab_2026_11_17;

public class Motor
{
    public string Model { get; set; }
    public int BeygirGucu { get; set; }

    public Motor(string model, int beygirGucu)
    {
        if(string.IsNullOrEmpty(model))
            throw new ArgumentNullException(nameof(model),"Model boş olamaz.");
        if (beygirGucu <= 0)
            throw new ArgumentOutOfRangeException(nameof(beygirGucu), "Beygir gücü sıfırdan büyük olmalı");
        Model = model.Trim();
        BeygirGucu = beygirGucu;
        
    }

    public void Calistir()
    {
        Console.WriteLine($"{Model} motoru ateşlendi.");
    }
}