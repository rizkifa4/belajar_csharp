using System;

// namespace Method
// {
//     class Program
//     {
//         static void Main()
//         {
//             // budi();

//             // hitung(10, 20);
//             // hitung(20, 30);
//             // hitung(30, 40);
//             // hitung(40, 50);
//             // hitung(50, 60);

//             int hasil = hitung(5, 7);
//             Console.WriteLine("Hasilnya adalah " + hasil);
//             if (hasil % 2 == 0)
//             {
//                 Console.WriteLine("Hasilnya adalah bilangan genap");
//             }
//             else
//             {
//                 Console.WriteLine("Hasilnya adalah bilangan ganjil");
//             }
//         }

//         // static void budi()
//         // {
//         //     Random rnd = new Random();

//         //     string name = "Budi X-" + rnd.Next(1000, 9999).ToString();
//         //     int age = rnd.Next(1, 100);

//         //     Console.WriteLine("Halo, nama saya " + name);
//         //     Console.WriteLine("Saya berumur " + age + " tahun");
//         // }



//         // static void hitung(int a, int b)
//         // {
//         //     int hasil = a * b;
//         //     Console.WriteLine("Hasilnya adalah " + hasil);
//         // }



//         static int hitung(int a, int b)
//         {
//             int hasil = a * b;
//             return hasil;
//         }
//     }
// }


namespace gatahu
{
    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Masukkan suatu kalimat: ");

            string kalimat = Console.ReadLine();

            int jumlahKata = hitungKata(kalimat);

            Console.WriteLine("Jumlah kata dalam kalimat tersebut adalah " + jumlahKata);
        }

        static int hitungKata(string kalimat)
        {
            int jumlahKata = kalimat.Split(' ').Length;
            return jumlahKata;
        }
    }
}