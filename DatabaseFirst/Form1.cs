using DatabaseFirst.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ApplicationDbContext db = new ApplicationDbContext();
        private void btnToList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.ToList();
            //ToList()  Bu method bir koşul olmaksızın tüm değerleri listelemek için kullanıyoruz. Verileri RAM'in Heap alanına çıkartıp oradan UI'a getirir.
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            //Where() Bu methodu veri tabanında bulunan veriler üzerinde filtreleme yapmak için kullanılır. 
            //Örneğin veri tabanında Stokta bulunan adetleri 30 ve üzeri olan ürünleri listeledik.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 30).ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Select() Veri tabanından gelen veri kümesinin içerisinde bulunan sütunları filtrelemek için kullanılır. 
            //Örneğin veri tabanında Stokta bulunan adetleri 30 ve üzerinde olan ürünlerin ID numarası, ürün ismi ve fiyat sütunları ile listelenmesini istedik
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 30)
                                                  .Select(x => new
                                                  {   x.ProductID,
                                                      x.ProductName,
                                                      x.UnitPrice
                                                  }).ToList();
        }

        private void btnOrderByDesc_Click(object sender, EventArgs e)
        {
            //OrderByDescending() Bu method veri tabanından gelen veri kümesnin belirtilen sütunundaki verilerin çoktan aza  doğru sıralanmış halde listelememizi sağlar.
            //Örneğin Veri tabanındaki ürünlerden fiyatı 50 den büyük olan ürünlerin id,ürün adi, fiyati ve stok adeti bilgilerini isteyip stoktaki adet miktarımım çoktan aza doğru sıralanmış halde karşımıza getirilmesini sağladık.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 50)
                                      .OrderByDescending(x => x.UnitsInStock)
                                      .Select(x => new
                                      {
                                          x.ProductID,
                                          x.ProductName,
                                          x.UnitPrice,
                                          x.UnitsInStock
                                      }).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            //OrderBy Bu method OrderByDescending'e benzer şekilde çalışır. Tek farkı sıralamayı azdan çoka doğru sıralamasını yapar.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 50)
                          .OrderBy(x => x.UnitsInStock)
                          .Select(x => new
                          {
                              x.ProductID,
                              x.ProductName,
                              x.UnitPrice,
                              x.UnitsInStock
                          }).ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            //GroupBy() Sorgu sonucu dönen verinin tarafımızca verilen isim atında gruplanmasını sağlar.
            //Örnek olarak hangi kategoride kaç adet ürün stoğumuz var sorgusu 
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName)
                                                  .Select(x => new
                                                  {   KategoriAdi = x.Key,
                                                      ToplamStok = x.Sum(z => z.UnitsInStock)
                                                  }).ToList();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //First() methodu yaptığımız sorgu sonucunda bize dönen veri kümesindeki ilk elemanı getirir.
            Product product = db.Products.First(x => x.UnitPrice > 20);
            MessageBox.Show($"Fiyatı 20 den büyük olan ilk ürün : {product.ProductName}");

            //Eğer yaptığımız sorgu sonucunda karşımıza bir ürün çıkmasaydı uygulamamız hata alıp kapanacaktı. Bu durumda Try Catch blokları kullanarak uygulamanın durmasını engelleyebiliriz.

            try
            {
                Product product1 = db.Products.First(x => x.UnitPrice > 1000);
                MessageBox.Show($"Fiyatı 1000 den büyük olan ilk ürün : {product1.ProductName}");
            }
            catch (Exception)
            {

                MessageBox.Show("Aradığınız kriterde ürün bulunmmaktadır.");
            }
            //Birim fiyatı 100 den fazla olan ürün bulunmadığı için catch bloğu içerisindeki MessageBox çalışacaktır.
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            //Bu method First() ile aynı şekilde çalışmaktadır. Tek farkı karşılık olarak bir değer bulamaz ise yani null ise hata verip programı durdurmaz. Karşımıza değer olarak null getirir. Bu durumdaki kontrolü de if blokları ile yapabiliriz.

            Product product = db.Products.FirstOrDefault(x => x.ProductID > 5);
            if (product != null)
            {
                MessageBox.Show($"Aradaığınız ürünün adı {product.ProductName}");
            }
            else
            {
                MessageBox.Show("Aradığınız ürün bulunmamaktadır.");
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            //Skip() methodu sorgu sonucunda dönen veri grubundan istediğimiz kadar satırı atlatmamıza yardıcı olur.
            //Örneğin Ürünlerimizi birim fiyatlarını azdan çoka doğru sıralarken ilk 5 ürünü atlayıp öyle listeliyoruz.
            dataGridView1.DataSource = db.Products.OrderBy(x => x.UnitPrice)
                                      .Skip(5)
                                      .Select(x => new
                                      { x.ProductID,
                                        x.ProductName,
                                        x.UnitPrice,
                                      }).ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Contains() methodu koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol eder.
            //Örnek olarak ülke olarak USA olarak kayıtlı çalışanlarımın adı soyadı ve ülke bilgilerini listeledik
            dataGridView1.DataSource = db.Employees.Where(x => x.Country.Contains("USA"))
                                                   .Select(x=> new
                                                   {
                                                       x.FirstName,
                                                       x.LastName,
                                                       x.Country
                                                   }).ToList();
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            //StarWith() methodu içerisine parametere olarak verilen harf ile bir kelimenin başlayıp başlamadığını kontrol eder.
            //İsminin baş harfi R ile başlayan çalışanlarımın listesi
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.StartsWith("r")).ToList();
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            //EndWith() methodu içerisine parametere olarak verilen harf ile bir kelimenin başlayıp başlamadığını kontrol eder.
            //Soyadının son harfi G ile biten çalışanlarımın listesi
            dataGridView1.DataSource = db.Employees.Where(x => x.LastName.EndsWith("g")).ToList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Find() verilen parametrenin karşılığının veri tabanında olup olmadığını kontrol eder. Bu yöntem Id sütunu kontolü yapmak için birebirdir.
            //Ürün id'si 15 olan ürünü bulup listelemesini istedik
            Product product = db.Products.Find(15);
            if (product != null)
            {
                MessageBox.Show($"Aradığınız ürün {product.ProductName}");
            }
            else
            {
                MessageBox.Show("Aradığınız ürün bulunmamaktadır.");
            }
        }
    }
}
