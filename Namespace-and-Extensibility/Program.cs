using Namespace_and_Extensibility.Classes.MatematikIslemleri;

namespace UygulamaCalistirici
{
    class Program
    {
        static void Main()
        {
            Hesaplama hesap = new Hesaplama();

            int toplam = hesap.Topla(15, 5);
            int carpim = hesap.Carp(6, 7);

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Çarpım: " + carpim);
        }
    }
}
