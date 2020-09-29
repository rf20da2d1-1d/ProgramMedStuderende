using System;

namespace ProgramMedStudent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Studerende s = new Studerende();
            Console.WriteLine($"Studerende navn={s.Navn} alder={s.Alder} karakter={s.Karakter}");
            
            s.Navn = "peter";
            s.Alder = 23;
            s.Karakter = 7;
            Console.WriteLine($"Studerende navn={s.Navn} alder={s.Alder} karakter={s.Karakter}");
            
            
            Studerende s2 = s;
            s2.Alder = 34;

            Console.WriteLine($"Studerende navn={s.Navn} alder={s.Alder} karakter={s.Karakter}");
            Console.WriteLine($"Studerende navn={s2.Navn} alder={s2.Alder} karakter={s2.Karakter}");


            Studerende s3 = new Studerende("Jakob", 21, 10);
            Console.WriteLine($"Studerende navn={s3.Navn} alder={s3.Alder} karakter={s3.Karakter}");


        }
    }
}
