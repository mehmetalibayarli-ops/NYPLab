namespace NYPLab_2026_11_17;

class Program
{
    static void Main(string[] args)
    {
        //Association, Aggregation, Composition
        
        //Association
        //is-a -> ilişkisi vardır, bu şudur
        
        //Aggregation, Composition
        //has-a ilişkisi vardır,
        //aggregation'da daha genel composition'da daha güçlü bir ilişkisi vardır(daha must)
        
        //Bilgisayar Sistemi

        Bilgisayar pc1 = new Bilgisayar("MSI", "Intel i7", 8);
        //Tek bir nesne oluşturduk ama iki parametreyi işlemci class'ına gönderdik
        //İşlemci class'ını bilgisayar class'ı içinde oluşturduk
        //Miras almadan güçlü bir ilişki şeklidir (Composition)
        //Clean code destekler


        try
        {
            Araba araba1 = new Araba("Toyota", "2JZ", 745);


            araba1.BilgileriGetir();
            araba1.Calistir();
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine("Argument Null Exception");
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine("Argument Out Of Range Exception");
            Console.WriteLine(exception.Message);
        }
        catch (Exception exception)
        {
            Console.WriteLine("Unknown Exception");
            Console.WriteLine(exception.Message);
        }
        finally{Console.WriteLine("Program çalıştı.");}


    }
}