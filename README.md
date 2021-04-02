## İçindekiler
>-[DatabaseFirst](https://github.com/MesutGzl/DataAccessRepo/tree/master/DatabaseFirst) => Hazır olan Database'i projemize ekleyip Linq methodları ve Aggregate Fonksiyon örnekleri.

>-[CodeFirst](https://github.com/MesutGzl/DataAccessRepo/tree/master/CodeFirst) => CodeFirst kullanarak basit bir database oluşturma.

>-[CodeFirst_2](https://github.com/MesutGzl/DataAccessRepo/tree/master/CodeFirst_2) => CodeFirst yaklaşımı ile CRUD işlemlerini içeren bir örnek

>-[EagerLoadingvsLazyLoading](https://github.com/MesutGzl/DataAccessRepo/tree/master/LazyLoadingvsEagerLoading) => İki farklı yöntemin örnek üzerinden açıklaması


DatabaseFirst örneğini incelemek için Northwind sample database'ini kullanmanız gerekmektedir.

# ORM(Object Relational Mapping)
  ORM, veri tabanı ile çalışırken tercih edilen mimarisel yaklaşımdır. ORM mimaris, veri tabanı ve uygulamada ihtiyaç duyulan varlığın her iki tarafta da bulunmasını isteyen bir prensibi vardır. Örnek vermek gerekirse Veri tabanımızda Products  isimli bir tablomuz var ise uygulama tarafında da gerekli CRUD işlemlerinin yürütülmesi için Application(uygulama) tarafında da aynı varlık ve tüm özelliklerinin bulunduğu bir Products.cs isminde bir class'a sahip olmamız gereklidir. 

![image](https://user-images.githubusercontent.com/71979276/113429724-ac259180-93e1-11eb-921b-b8694e81ad16.png)


# Entity Framework
Entity Framework ORM(Object Relational Mapping) araçlarından biridir. ORM nedir dersek: İlişkisel veritabanı ile nesneye yönelik programlama(OOP) arasında bir köprü görevi gören araçtır. Bu köprü, ilişkisel veritabanındaki bilgilerimizi yönetmek için nesne modellerimizi kullandığımız bir yapıdır. Kısaca veritabanına bizim nesnelerimizi bağlayan ve bizim için veri alışverişini yapan Microsoft tarafından geliştirilmiş bir framework’tür.

![image](https://user-images.githubusercontent.com/71979276/113428930-5ac8d280-93e0-11eb-959e-fc273d459672.png)

ORM prensibini uygulamamızda bize yardımcı olmak için Entity Framework bize 3 farklı yaklaşım sunar.

## Database First
Hali hazırda olan bir veri tabanının yansımasını uygulamya ekler. Veri tabanında bulunan varlıkları yani tabloların birer kopyasını alır ve uygulama tarafında bunları sınıflara (class) dönüştürür. Çok pratik ve basit olmasının yanında çok büyük verilerin olduğu databaselerde uygulama hantallaşır ve uygulama içerisinde yapılacak bir değişiklik sonucunda bu değişkliği veri tabanı tarafındaki varlıklar üzerinde de yapmamız gerekir.

## Code First
Database First yaklaşımının tam tersi gibi düşünülebilinir. Yani veri tabanı developer tarafından OOP ve SOLID prensiplerine uyularak oluşturulur. Code First yapısında "Class" yapıları veri tabanında karşılığı "Table"dur. "Property" ise "Column" yapısına denk gelir. Daha sonra migration işlemi yapılır ve sonucunda oluşturulan bu sınıflar veri tabanına göç ettirilir. Böylelikle veri tabanı yazdığımız kodlar karşılığında kendi kendine oluşturulur. 

## Model First
Kod yazmadan ya da  database ile ilgilenmeden, tamamen model üzerinden veritabanı oluşturmak için kullanılan yaklaşımdır. Entity user interfacesi üzerinden modellediğiniz verilerinizi generate ettiğinizde hem database tarafında hem de kod tarafında otomatik olarak oluşurlar. Ne kadar basit gözükse de çok az kullanılır.


## Eager Loading
Kullanacağımız nesneleri, nesnenin ihtiyaç anından çok önce yaratır ve bekletir. Eager loading Linq sorgusu çalıştırıldığında verilerin tamanını yükler ve havızada tutar. Lazy loadingde Products'tan Supplier firma isimlerini kolayca yapabilmiştik. Burada aynı sorguyu yapmak için Manuel olarak sorgumuza bazı eklemeler yapmak zorundayız.

## Lazy Loading
Bir nesne örneğinin ihtiyaç duyulacağı ana kadar alınmaması ve bekletilmesi prensibi ile çalışır. Bu yöntem ile veriler sorguya bağlı olarak çekilir. Veri setinin içindeki tüm dataları yüklemek yerine kullanılacağı an tekrar sorgu atar ve veriyi çeker.

[Konu ile ilgili Gitbook Sayfam](https://mesut-guzel.gitbook.io/dataaccess/)
