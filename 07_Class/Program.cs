using System;

// namespace bljrClass
// {
//     class Kucing
//     {
//         public string nama;
//         public string warna;
//         public int umur;
//         public string makananFavorit;
//         public int stokMakanan;

//         public float berat;
//         public float beratMakan = 0.15f;

//         public void Makan()
//         {
//             if (stokMakanan > 0)
//             {
//                 Console.WriteLine(nama + " lagi makan " + makananFavorit);
//                 stokMakanan--;
//                 berat += beratMakan;
//             }
//             else
//             {
//                 Console.WriteLine(nama + " mau makan " + makananFavorit);
//                 Console.WriteLine("tapi stok makanan habis");
//             }
//         }

//         public void UlangTahun()
//         {
//             umur++;
//             Console.WriteLine(nama + " sedang ulang tahun, umurnya sekarang " + umur + " tahun");
//             Console.WriteLine("Budi minta hadiah untuk ulang tahunnya yaitu " + makananFavorit + " sebanyak 10");
//             stokMakanan += 10;
//             Console.WriteLine("Budi mau makan " + makananFavorit + " sebanyak 10");
//             stokMakanan -= 10;
//             berat += beratMakan * 10;
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             Kucing kucing1 = new Kucing();
//             kucing1.nama = "Budi";
//             kucing1.warna = "Abu-abu";
//             kucing1.umur = 3;
//             kucing1.makananFavorit = "Whiskas";
//             kucing1.stokMakanan = 1;
//             kucing1.berat = 3f;

//             kucing1.Makan();
//             Console.WriteLine(kucing1.nama + " beratnya " + kucing1.berat);
//             Console.WriteLine("Stok makanan " + kucing1.nama + " sekarang " + kucing1.stokMakanan);
//             kucing1.UlangTahun();
//             Console.WriteLine(kucing1.nama + " beratnya " + kucing1.berat);
//             Console.WriteLine("Stok makanan " + kucing1.nama + " sekarang " + kucing1.stokMakanan);
//         }
//     }
// }


namespace bljrClass
{
    class Kucing
    {
        public string nama;
        public string warna;
        public int umur;
        public string makananFavorit;
        public int stokMakanan;

        public float berat;
        public float beratMakan = 0.15f;

        public static int jumlahKucing;

        public Kucing(string _nama, string _warna, int _umur, string _makananFavorit, int _stokMakanan, float _berat)
        {
            nama = _nama;
            warna = _warna;
            umur = _umur;
            makananFavorit = _makananFavorit;
            stokMakanan = _stokMakanan;
            berat = _berat;
        }

        public void Makan()
        {
            if (stokMakanan > 0)
            {
                Console.WriteLine(nama + " lagi makan " + makananFavorit);
                stokMakanan--;
                berat += beratMakan;
            }
            else
            {
                Console.WriteLine(nama + " mau makan " + makananFavorit);
                Console.WriteLine("tapi stok makanan habis");
            }
        }

        public void UlangTahun()
        {
            umur++;
            Console.WriteLine(nama + " sedang ulang tahun, umurnya sekarang " + umur + " tahun");
            Console.WriteLine(nama + " minta hadiah untuk ulang tahunnya yaitu " + makananFavorit + " sebanyak 10");
            stokMakanan += 10;
            Console.WriteLine(nama + " mau makan " + makananFavorit + " sebanyak 10");
            stokMakanan -= 10;
            berat += beratMakan * 10;
        }
    }

    class Program
    {
        static void Main()
        {
            Kucing kucing1 = new Kucing("Budi", "Abu-abu", 3, "Whiskas", 1, 3f);
            Kucing kucing2 = new Kucing("Siti", "Putih", 2, "Tuna Kaleng", 2, 2.5f);

            kucing1.Makan();
            Console.WriteLine(kucing1.nama + " beratnya " + kucing1.berat);
            Console.WriteLine("Stok makanan " + kucing1.nama + " sekarang " + kucing1.stokMakanan);
            kucing1.UlangTahun();
            Console.WriteLine(kucing1.nama + " beratnya " + kucing1.berat);
            Console.WriteLine("Stok makanan " + kucing1.nama + " sekarang " + kucing1.stokMakanan);

            kucing2.Makan();
            Console.WriteLine(kucing2.nama + " beratnya " + kucing2.berat);
            Console.WriteLine("Stok makanan " + kucing2.nama + " sekarang " + kucing2.stokMakanan);

            Console.WriteLine("Jumlah kucing sekarang " + Kucing.jumlahKucing);

        }
    }
}