using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System.ComponentModel.DataAnnotations;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Supplier : BaseEntity
    {
        ////Databasemizde Supplier adında bir tablo açıp içerisindeki sütunları belirledik.
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Fax { get; set; }
        public string HomePage { get; set; }

    }
}
