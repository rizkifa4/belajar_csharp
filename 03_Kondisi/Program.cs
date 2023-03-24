using System;

// Console.WriteLine("Sebutkan ibu kota Indonesia");

// Console.WriteLine("1. Jakarta");
// Console.WriteLine("2. Bogor");
// Console.WriteLine("3. Bandung");
// Console.WriteLine("4. Surabaya");

// Console.Write("Jawaban Anda: ");
// int jawaban = Convert.ToInt32(Console.ReadLine());

// if (jawaban == 1)
// {
//     Console.WriteLine("Jawaban Anda benar");
// }
// else
// {
//     Console.WriteLine("Jawaban Anda salah");
// }



// Console.WriteLine("Harga ubi per kilogram adalah Rp. 8.000");

// int uang = Convert.ToInt32(Console.ReadLine());

// if (uang == 8000)
// {
//     Console.WriteLine("Ini ubi kamu");
// }
// else if (uang < 8000)
// {
//     Console.WriteLine("Uang kamu kurang");
// }
// else
// {
//     int kembalian = uang - 8000;
//     Console.WriteLine("Ini ubi kamu dan kembalian Rp. " + kembalian);
// }



// Console.WriteLine("Untuk menjadi seorang web developer, keahlian yang harus dimiliki adalah:");

// Console.WriteLine("1. HTML");
// Console.WriteLine("2. CSS");
// Console.WriteLine("3. Javascript");

// Console.Write("Apakah kamu sudah bisa HTML? (1 = Ya, 2 = Tidak): ");
// int skilHtml = Convert.ToInt32(Console.ReadLine());

// Console.Write("Apakah kamu sudah bisa CSS? (1 = Ya, 2 = Tidak): ");
// int skilCss = Convert.ToInt32(Console.ReadLine());

// Console.Write("Apakah kamu sudah bisa Javascript? (1 = Ya, 2 = Tidak): ");
// int skilJs = Convert.ToInt32(Console.ReadLine());

// if (skilHtml == 1 && skilCss == 1 && skilJs == 1)
// {
//     Console.WriteLine("Selamat, kamu sudah bisa menjadi web developer");
// }
// else
// {
//     Console.WriteLine("Maaf, kamu belum bisa menjadi web developer");
// }



// Console.WriteLine("Untuk membuat aplikasi multiplatform, salah satu framework yang bisa digunakan adalah:");

// Console.WriteLine("1. Flutter");
// Console.WriteLine("2. React Native");

// Console.Write("Pilih salah satu framework: ");
// int pilihan = Convert.ToInt32(Console.ReadLine());

// if (pilihan == 1 || pilihan == 2)
// {
//     Console.WriteLine("Selamat, kamu sudah bisa membuat aplikasi multiplatform");
// }
// else
// {
//     Console.WriteLine("Maaf, kamu belum bisa membuat aplikasi multiplatform");
// }



Console.Write("Masukkan angka antara 1 sampai 3: ");
int angka = Convert.ToInt32(Console.ReadLine());

switch (angka)
{
    case 1:
        Console.WriteLine("Satu");
        break;
    case 2:
        Console.WriteLine("Dua");
        break;
    case 3:
        Console.WriteLine("Tiga");
        break;
    default:
        Console.WriteLine("Angka yang kamu masukkan salah");
        break;
}