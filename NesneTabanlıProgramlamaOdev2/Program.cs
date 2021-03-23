using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanlıProgramlamaOdev2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Satır sayısı giriniz:");
            byte satir = byte.Parse(Console.ReadLine());

         

            string[,] ogrenciler = new string[satir + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "Harf Notu";



            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {



                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {

                    switch (j)
                    {
             
                        case 0:
                            Console.WriteLine("Öğrenci adını giriniz:");
                            break;
                        case 1:
                            Console.WriteLine("Öğrenci soyadını giriniz:");
                            break;
                        case 2:
                            Console.Write("Vize notunu giriniz: ");
                            int vize = Int32.Parse(Console.ReadLine());
                            Console.Write("Final notunu giriniz: ");
                            int final = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(vize * 0.4 + final * 0.6);
                            int ort = Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            break;


                    }

                    ogrenciler[i, j] = Console.ReadLine();

                }
            }
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }

                Console.WriteLine();
            }

            


        }
    }
}
