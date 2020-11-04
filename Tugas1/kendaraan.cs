using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Tugas1
{
    class Kendaraan
    {
        private int _jumlahRoda;
        private int _kecepatan;
        private String _warna;
         
 
        public int JumlahRoda
        {
            get { return _jumlahRoda; }
            set { _jumlahRoda = value; }
        }
 
        public int Kecepatan
        {
            get { return _kecepatan; }
            set { _kecepatan = value; }
        }
 
        public String Warna
        {
            get { return _warna; }
            set { _warna = value; }
        }
 
        public virtual void Mengerem()
        {
            Console.WriteLine("Kendaraan Mengerem .. !!!");
        }
 
        public void Melaju()
        {
            Console.WriteLine("Kendaraan Melaju .. !!!");
        }
         
    }
}