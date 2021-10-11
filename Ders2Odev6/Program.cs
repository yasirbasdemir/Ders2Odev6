using System;

namespace Ders2Odev6
{     /* Ödev konusu : Herhangi bir e-ticaret sistemine giriniz.
        Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. 
        Siz de Urun (Product) isimli bir class oluşturup, 
        oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.
        Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.
        */
    class Urun
    {
        
        public string name { get; set; }
        public string price { get; set; }
        public string stock { get; set; }
        //classlarımızı oluşturdum.
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.name ="Kulaklık";
            urun1.price = "89 Türk lirası";
            urun1.stock = "23 adet stok bulunmaktadır.";

            Urun urun2 = new Urun();
            urun2.name = "Mouse";
            urun2.price = "72 Türk lirası";
            urun2.stock = "14 adet stok bulunmaktadır.";

            Urun urun3 = new Urun();
            urun3.name = "Klavye";
            urun3.price = "135 Türk lirası";
            urun3.stock = "7 adet stok bulunmaktadır.";
            //ürünlerimizin girişini yaptım.

            Urun[] urun = new Urun[] {urun1,urun2,urun3 }; // ürünlerin listelenmelerini hazırladım.
            //For ile listeleme:
            for (int i = 0; i < urun.Length; i++)
            {
                Console.WriteLine("Ürün ismi : " + urun[i].name +", "+"Ürün fiyatı : " + urun[i].price + ", " + "Ürün stoğu : " + urun[i].stock);
            }
            //Foreach ile listeleme:
            foreach (var item in urun)
            {
                Console.WriteLine("Ürün ismi : " +item.name+", " + "Ürün fiyatı : " + item.price + ", " + "Ürün stoğu : " + ", " + item.stock);
            }
            //While ile listeleme:
            int k = 0;
            while (k < urun.Length)
            {
                Console.WriteLine("Ürün ismi : " + urun[k].name + ", " + "Ürün fiyatı : " + urun[k].price + ", " + "Ürün stoğu : " + urun[k].stock);
                k++;
            }
            
        }
    }
}
