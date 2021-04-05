using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingvsEagerLoading
{
    class Program
    {
        /*Lazy Loading
          Bir nesne örneğinin ihtiyaç duyulacağı ana kadar alınmaması ve bekletilmesi prensibi ile çalışır. Bu yöntem ile veriler sorguya bağlı olarak çekilir. Veri setinin içindeki tüm dataları yüklemek yerine kullanılacağı an tekrar sorgu atar ve veriyi çeker. 
        */
        static void Main(string[] args)
        {
            NorthwindEntities nt = new NorthwindEntities();
            //var category = nt.Categories.Find(1);
            //var products = category.Products;
            //foreach (var product in products)
            //
            //   Console.WriteLine(product.ProductName);
            //   Console.WriteLine(product.Supplier.CompanyName);
            //   Console.ReadKey();
            // }//Yukarıdaki yaptığımız sorguda Databasemizde 100 Ürün olduğunu varsayarsak bu her bir ürünün toptancısı için 1 sorgu gönderecektir. Yani toplamda SQL'e 100 sorgu gönderilmiş olacaktır.




            /*Eager Loading
             * Kullanacağımız nesneleri, nesnenin ihtiyaç anından çok önce yaratır ve bekletir. Eager loading Linq sorgusu çalıştırıldığında verilerin tamanını yükler ve havızada tutar. Lazy loadingde Products'tan Supplier firma isimlerini kolayca yapabilmiştik. Burada aynı sorguyu yapmak için Manuel olarak sorgumuza bazı eklemeler yapmak zorundayız.*/
 
       
            var category = nt.Categories.Include("Products").Include("Products.Supplier").FirstOrDefault(x => x.CategoryID == 1);
            var products = nt.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);//Categories tablosundan Products'e tablosuna ait bilgileri görüntülemek için manuel olarak Products tablomuzu sorguya ekledik.
                Console.WriteLine(product.Supplier.CompanyName);//Products'lerin Supplier bilgisine erişmek için Products.Supplier sorgumuza ekledik.
                Console.ReadKey();
            }
            //Yukarıda yaptığımız sorguda Lazy Loading gibi 100 adet sorgu yerine yalnızca tek 1 sorgu SQL tarafına gönderilmiştir.
                        
            //Yukarıda yaptığımız örneğe göre, Lazy Loading birbiriyle ilişkili olan entitylerden verileri ihtiyaç olduça çeker. Bu yaptığımız sorguya göre performans açısından yarar sağlayabilir. Fakat Eager Loadinge göre veritabanına daha fazla bağlanıp sorgu atar. 
        }
    }
}











