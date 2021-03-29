using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System.ComponentModel.DataAnnotations;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    //Databasemizde Category adında bir tablo açıp içerisindeki sütunları belirledik.
    //Required komutunu bu sütunun boş geçilemez ve doldurulması zorunlu kılmak için kullanıyoruz.
    public class Category : BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        public string Picture { get; set; }

    }
}
