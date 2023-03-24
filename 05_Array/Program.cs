// string[] orang = { "Budi", "Siti", "Ani" };

// for (int i = 0; i < orang.Length; i++)
// {
//     int Nomor = i + 1;
//     Console.WriteLine("Orang ke-" + Nomor + ": " + orang[i]);
// }



// string[] nama = new string[3];

// Console.WriteLine("Masukkan 3 nama: ");

// nama[0] = Console.ReadLine();
// nama[1] = Console.ReadLine();
// nama[2] = Console.ReadLine();

// Console.WriteLine("Daftar nama yang Anda masukkan: ");

// Array.Sort(nama);

// for (int i = 0; i < nama.Length; i++)
// {
//     Console.WriteLine(nama[i]);
// }



// string[] nama = new string[3];

// for (int i = 0; i < nama.Length; i++)
// {
//     Console.Write("Nama ke-" + (i + 1) + ": ");
//     nama[i] = Console.ReadLine();
// }

// Console.WriteLine("Daftar nama yang Anda masukkan: ");

// for (int i = 0; i < nama.Length; i++)
// {
//     Console.WriteLine(nama[i]);
// }



// List<string> peserta = new List<string>();

// Console.WriteLine("Masukkan nama peserta : ");

// // peserta.Add(Console.ReadLine());
// // peserta.Add(Console.ReadLine());
// // peserta.Add(Console.ReadLine());

// peserta.Add("Budi");
// peserta.Add("Siti");
// peserta.Add("Ani");

// Console.WriteLine("Daftar nama peserta: ");

// for (int i = 0; i < peserta.Count; i++)
// {
//     Console.WriteLine(peserta[i]);
// }

// peserta.Remove("Siti");
// peserta.RemoveAt(1);

// Console.WriteLine("Daftar nama peserta: ");

// for (int i = 0; i < peserta.Count; i++)
// {
//     Console.WriteLine(peserta[i]);
// }



Console.Write("Masukkan Jumlah Peserta: ");

int jumlah = Convert.ToInt32(Console.ReadLine());

string[] peserta = new string[jumlah];

for (int i = 0; i < peserta.Length; i++)
{
    Console.Write("Nama ke-" + (i + 1) + ": ");
    peserta[i] = Console.ReadLine();
}

Console.WriteLine("Daftar nama peserta: ");

Array.Sort(peserta);

for (int i = 0; i < peserta.Length; i++)
{
    Console.WriteLine(peserta[i]);
}
