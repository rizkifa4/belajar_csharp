using System;

// Console.Write("Masukkan angka yang akan dihitungnya:");
// int hitung = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= hitung; i++)
// {
//     double result = Math.Pow(2, i);
//     Console.WriteLine(result);
// }



// Random rnd = new Random();
// int angka = rnd.Next(1, 10);

// Console.WriteLine("Saya telah memilih sebuah bilangan bulat secara acak antara 1 s/d 10. Silakan tebak ya!");
// Console.Write("Tebakan Anda: ");
// int tebakan = Convert.ToInt32(Console.ReadLine());

// if (tebakan == angka)
// {
//     Console.WriteLine("Yeeee... Bilangan tebakan Anda BENAR :-)");
// }
// else
// {
//     Console.WriteLine("Wuuuuu... Bilangan tebakan Anda SALAH :-(");
//     Console.WriteLine("Bilangan yang saya pilih adalah " + angka);
// }



// Random rnd = new Random();

// int roll = 0;
// int count = 0;

// Console.WriteLine("Tekan tombol apapun untuk melempar dadu");

// while (roll != 6)
// {
//     Console.ReadKey();
//     roll = rnd.Next(1, 7);
//     count++;
//     Console.WriteLine("Roll ke-" + count + ": " + roll);
// }

// Console.WriteLine("Jumlah roll: " + count);



Random rnd = new Random();

int roll01 = 0;
int roll02 = 1;
int count = 0;

Console.WriteLine("Tekan tombol apapun untuk melempar dadu");

while (roll01 != roll02)
{
    Console.ReadKey();
    roll01 = rnd.Next(1, 7);
    roll02 = rnd.Next(1, 7);
    count++;
    Console.WriteLine("Roll ke-" + count + ": " + roll01 + " dan " + roll02);
}

Console.WriteLine("Jumlah roll: " + count);