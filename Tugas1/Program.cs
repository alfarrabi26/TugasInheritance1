using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Tugas1
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //inheritance
            Console.WriteLine("Inheritance");
            Perahu perahu = new Perahu();
            Pesawat pesawat = new Pesawat();

            perahu.Melaju();
            perahu.Warna = "Hijau";
            perahu.Kecepatan = 30;
            perahu.JumlahRoda = 0;
            Console.WriteLine("Warna Perahu :{0} ", perahu.Warna);
            Console.WriteLine("Kecepatan Perahu :{0} ", perahu.Kecepatan);
            Console.WriteLine("Jumlah roda Perahu :{0} ", perahu.JumlahRoda);
            Console.WriteLine("---------------------");

            pesawat.Melaju();
            Console.WriteLine("Warna Pesawat :{0} ", pesawat.Warna);
            Console.WriteLine("Kecepatan Pesawat :{0} ", pesawat.Kecepatan);
            Console.WriteLine("Jumlah roda Pesawat :{0} ", pesawat.JumlahRoda);

            //Console.ReadKey();
        }
    }

    class Program : NewBaseType
    {
    }
}