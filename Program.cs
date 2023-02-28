
using System.Collections;

internal class Program
{
    private static List<int> Main(string[] args)
    {
        ArrayList liste = new ArrayList();
        liste.Add("Ayşe");
        liste.Add('d');
        liste.Add(3);
        liste.Add(true);

        Console.WriteLine(liste[2]);

        string[] renkler = {"kırmızı","beyaz","mavi"};
        List<int> sayılar = new List<int> {3,4,5,2}

        //add range dizi ekleme
        liste.AddRange(renkler);
        liste.AddRange(sayılar);

        foreach(var item in liste)
            Console.WriteLine(item);

            //sort sıralama liste.sort
            //liste.binarysearch , sıralı dizide aranan degern index ini verir

        //reverse <----- ---->
        liste.Reverse();
        foreach(var item in liste)
            Console.WriteLine(item);
;    }
}