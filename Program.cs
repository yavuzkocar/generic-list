using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilistesi= new List<int>{};
            sayilistesi.Add(23);
            sayilistesi.Add(10);
            sayilistesi.Add(4);
            sayilistesi.Add(5);
            sayilistesi.Add(92);
            sayilistesi.Add(34);
            List<string> renklistesi= new List<string>{};
            renklistesi.Add("kırmızı");
            renklistesi.Add("mavi");
            renklistesi.Add("turuncu");
            renklistesi.Add("sarı");
            renklistesi.Add("yeşil");

            //Count ---> listenin eleman sayısını getirir
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayilistesi.Count);
            

            //foreach ve list.ForEach ile elemanlara erişim
            foreach (var sayi in sayilistesi)
            Console.WriteLine(sayi);

            foreach (var renk in renklistesi)
            Console.WriteLine(renk);

            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));
            
            //Listeden eleman çıkarma
            sayilistesi.Remove(4);
            renklistesi.Remove("yeşil"); 

            sayilistesi.RemoveAt(0); //ilk elemanı çıkarır -indeksi 0 olan eleman-
            renklistesi.RemoveAt(1); //-indeksi 1 olan elemanı çıkarır-

            //liste içerisinde arama
            if(sayilistesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");
            // elemanı verip indexi bulma
            Console.WriteLine(renklistesi.BinarySearch("sarı"));

            // diziyi list e çevirme
            string[] hayvanlar= {"kedi","köpek","kuş"};
            List<string> hayvanlistesi= new List<string>(hayvanlar);

            //listeyi nasıl temizlerim
            hayvanlistesi.Clear();

            //list içerisinde nesne tutma




        }
    }
    public class kullanıcılar{
        string isim;
        string soyisim;
        int yaş;
    }//bu class ile alakalı kısayol ile bir şeyler yapıldı bu dersin devamında son 6 dk bununla alakalı git bak.
    
}

