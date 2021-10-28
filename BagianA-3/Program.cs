using System;

namespace BagianA_3
{
    //Bagian A-3
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan kata: ");
            string kataAsli = Console.ReadLine();

            int PanjangKarakterKata = kataAsli.Length;
            if (PanjangKarakterKata > 200)
            {
                Console.WriteLine("Maaf. Kamu sudah melebihi batas karakter!");
                Console.ReadKey();
            }
            else
            {
                kataAsli = kataAsli.Replace(" ", "");
                string result = kataAsli;

                for (int i = 0; i < result.Length; i++)
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[i] == result[j] && i != j)
                        {
                            result = result.Remove(j, 1);
                        }
                    }
                }

                int jumlahKarakter = result.Length;

                Console.WriteLine();
                Console.WriteLine("Panjang karakter yang unik: ");
                Console.WriteLine(jumlahKarakter);
                Console.ReadLine();
            }
        }
    }
}
