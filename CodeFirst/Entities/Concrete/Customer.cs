using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System.ComponentModel.DataAnnotations;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Customer : BaseEntity
    {
        ////Databasemizde Category adında bir tablo açıp içerisindeki sütunları belirledik.
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
        public int PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Fax { get; set; }

    }
}
