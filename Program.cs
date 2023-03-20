using System;
using System.Diagnostics;

namespace CalculatorConsoleApp
{
    //membuat class
    class program
    {
        //fungsi main program
        static void Main(string[] args)
        {
            //Membuat judul console 
            Console.Title = "Aplikasi Calculator";

            //membuat daftar isi menu 
            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine();
            Console.WriteLine(" 1.Penambahan \n 2.Pengurangan \n 3.Perkalian \n 4.Pembagian ");
            Console.WriteLine("======================================");
            Console.WriteLine();
            //Input sebuah menu
            Console.WriteLine("Pilih Menu : ");    
            string s = Console.ReadLine();
            int n = int.Parse(s);
            Console.WriteLine();

            //nilai default variabel a dan b
            int a, b;

            //fungsi untuk proses yang sesuai dengan nilai inputan yg di input
            switch (n)
            {
                case 1:
                    Console.WriteLine("input nilai A : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Penambahan "+ a +" + " + b + " = "+ penambahan(a,b));
                    break;

                case 2:
                    Console.WriteLine("input nilai A : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}",  a, b, pengurangan(a, b));
                    break;

                case 3:
                    Console.WriteLine("input nilai A : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}",a, b, perkalian(a, b));
                    break;

                case 4:
                    Console.WriteLine("input nilai A : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input nilai B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b,  pembagian(a, b));
                    break;

                 //fungsi apabila inputan menu tidak sesuai dengan daftar menu
                default:
                    Console.WriteLine("menu tidak tersedia");
                    break;
            }

            //pesan untuk mengakhiri program
            Console.WriteLine();
            Console.WriteLine("\nTekan apa aja dah buat keluar");
            Console.ReadKey(); 

        }


        //membuat fungsi rumus perhitungan
        static int penambahan(int a,int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a,int b) 
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}