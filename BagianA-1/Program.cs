using System;

namespace BagianA_1
{
    //Bagian A-1
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka untuk berhitung: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (angka > 9)
            {
                Console.WriteLine("Apa?");
            }
            else
            {
                for (int i = 1; i <= angka; i++)
                {
                    for (int j = 1; j <= angka; j++)
                    {
                        if (j == angka)
                        {
                            Console.Write("hop! ");
                        }
                        else
                        {
                            Console.Write(j + " ");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
