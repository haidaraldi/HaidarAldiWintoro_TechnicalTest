using System;

namespace BagianA_2
{
    //Bagian A-2
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan kata: ");
            string kataManipulasi = Console.ReadLine();

            int PanjangKarakterKata = kataManipulasi.Length;
            if(PanjangKarakterKata > 100)
            {
                Console.WriteLine("Maaf. Kamu sudah melebihi batas karakter!");
                Console.ReadKey();
            }
            else
            {
                kataManipulasi = kataManipulasi.Replace(" ", "");
                string result = "";
                string kataAsli = kataManipulasi;

                for (int i = 0; i < kataAsli.Length; i++)
                {
                    for (int j = 0; j < kataManipulasi.Length; j++)
                    {
                        if (kataAsli[i] == kataManipulasi[j])
                        {
                            result += kataManipulasi[j];
                            kataManipulasi = kataManipulasi.Remove(j, 1);

                            j--;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Sort berdasarkan posisi: ");
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
