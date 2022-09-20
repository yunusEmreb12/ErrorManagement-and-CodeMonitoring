using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try-Catch-Finally ve Mantıksal Hatalar
            try
            {
                Console.WriteLine("Bir sayi giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayı :" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamalandı :");
            }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-20000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir deger girdiniz :");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil:");
                Console.WriteLine(ex);
            }
             catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ve büyük bir değer girdiniz:");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
