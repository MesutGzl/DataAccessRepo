## İçindekiler
>-[DatabaseFirst](https://github.com/MesutGzl/DataAccessRepo/tree/master/DatabaseFirst) => Hazır olan Database'i projemize ekleyip Linq methodları ve Aggregate Fonksiyon örnekleri.

>-[CodeFirst](https://github.com/MesutGzl/DataAccessRepo/tree/master/CodeFirst) => CodeFirst kullanarak basit bir database oluşturma.

>-[CodeFirst_2](https://github.com/MesutGzl/DataAccessRepo/tree/master/CodeFirst_2) => CodeFirst yaklaşımı ile CRUD işlemlerini içeren bir örnek


DatabaseFirst örneğini incelemek için nortwind sample database'ini code first yaklaşımı ile yansımasını projeye eklemeniz gerekmektedir.

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

[Gitbook Sayfam](https://app.gitbook.com/@mesut-guzel/s/dataaccess/)
