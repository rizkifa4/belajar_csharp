using System;

// Console.WriteLine("Siapa Nama Kamu?");
// string nama = Console.ReadLine();

// Console.WriteLine("Halo " + nama + ", Selamat Belajar C#");



// double angka1 = 10;
// double angka2 = 20;

// Console.WriteLine("Angka 1 = " + angka1);
// Console.WriteLine("Angka 2 = " + angka2);
// Console.WriteLine("Hasil Penjumlahan = " + (angka1 + angka2));

// double angka3;
// Console.WriteLine("Masukkan Angka ke-3");
// angka3 = Convert.ToDouble(Console.ReadLine());

// double angka4;
// Console.WriteLine("Masukkan Angka ke-4");
// angka4 = Convert.ToDouble(Console.ReadLine());

// double hasil = angka3 * angka4;

// Console.WriteLine("Hasil Penjumlahan = " + hasil);
// Console.WriteLine("Hasil Penjumlahan = " + (angka3 * angka4));



double angka1, angka2, angka3, angka4;

Console.WriteLine("Masukkan Angka ke-1");
angka1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Masukkan Angka ke-2");
angka2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Masukkan Angka ke-3");
angka3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Masukkan Angka ke-4");
angka4 = Convert.ToDouble(Console.ReadLine());

double rata = (angka1 + angka2 + angka3 + angka4) / 4;

Console.WriteLine("Rata-rata = " + rata);

Console.ReadKey();