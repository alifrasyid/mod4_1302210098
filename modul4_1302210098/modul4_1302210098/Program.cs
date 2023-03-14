using System;

public class KodeBuah
{
    public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka}
    public static string getKodeBuah(NamaBuah buah)
    {
        string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kodebuah[(int)buah];
    }
}

public class PosisiKarakterGame
{
    enum state { Berdiri, Jongkok, Tengkurap, Terbang}
    state posisi = state.Berdiri;
    string perintah = "w";

    public void ChangState()
    {
        Console.WriteLine(posisi);
        while (perintah == "w" || perintah == "s" || perintah == "x")
        {
            Console.Write("Masukkan Perintah: ");
            perintah = Console.ReadLine();
            if (posisi == state.Berdiri)
            {
                if(perintah == "w")
                {
                    posisi = state.Terbang;
                    Console.WriteLine(posisi);
                    Console.WriteLine("posisi take off");
                }else if(perintah == "s")
                {
                    posisi = state.Jongkok;
                    Console.WriteLine(posisi);
                }
            }else if (posisi == state.Terbang)
            {
                if (perintah == "x")
                {
                    posisi = state.Jongkok;
                    Console.WriteLine(posisi);
                    Console.WriteLine("posisi landing");
                }
                else if (perintah == "s")
                {
                    posisi = state.Berdiri;
                    Console.WriteLine(posisi);
                }
            }
            else if (posisi == state.Jongkok)
            {
                if (perintah == "w")
                {
                    posisi = state.Berdiri;
                    Console.WriteLine(posisi);
                }
                else if (perintah == "s")
                {
                    posisi = state.Tengkurap;
                    Console.WriteLine(posisi);
                }
            }
            else if (posisi == state.Tengkurap)
            {
                if (perintah == "w")
                {
                    posisi = state.Jongkok;
                    Console.WriteLine(posisi);
                }
            }
        }
    }
}
class MainClass
{
    static void Main()
    {
        KodeBuah.NamaBuah buah = KodeBuah.NamaBuah.Kurma;
        string kodebuah = KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Kurma);
        Console.WriteLine("Kode buah untuk buah " + buah + " adalah " + kodebuah);

        PosisiKarakterGame pkg = new PosisiKarakterGame();
        Console.WriteLine("Ketetntuan Perintah: w,s,x");
        pkg.ChangState();
    }
    
}
