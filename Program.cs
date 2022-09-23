// See https://aka.ms/new-console-template for more information
using System;

namespace tipdonusumleri
{

    class Program
    {

        static void Main(String [] args)
        
        {
            try 
            {
               Console.WriteLine("Bir sayı giriniz:");
               int sayi= Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Girmiş olduğunuz sayi:" +sayi);

            }
            catch(Exception ex)
            {

       Console.WriteLine("Hata:" +ex.Message.ToString());

            }
            try
            {
          int a= int.Parse("-200000000");


            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cok buyuk veya kucuk bir deger girdiniz:");
                Console.WriteLine(ex);

            }
            finally {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}