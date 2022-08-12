using System;

namespace example8
{
    class Program
    {
        static void Main(string[] args)
        {
            var sınav = new Sınav();
            Console.WriteLine("vize notunu girin: ");
            sınav.Vize = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("final notunu girin: ");
            sınav.Final = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("total de puanınız: "+sınav.CalculateNot(sınav.Vize,sınav.Final));


            
        }
    }
}
