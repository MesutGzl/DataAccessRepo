using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Order : BaseEntity
    {
        ////Databasemizde Order adında bir tablo açıp içerisindeki sütunları belirledik.
        public int CustomerID { get; set; } 
        public virtual Customer Customer { get; set; } //Customer classımızın içerisinde CustomerID'yi aldık.
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; } //Employee classımızın içerisinde EmployeeID'yi aldık.
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }

        public int ShipperID { get; set; }
        public virtual Shipper Shipper { get; set; }//Shipper classımızın içerisinde ShipperID'yi aldık.
        [Required]
        public string Freight { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipAddress { get; set; }
        [Required]
        public string ShipCity { get; set; }
        [Required]
        public string ShipRegion { get; set; }
        [Required]
        public string ShipPostalCode { get; set; }
        [Required]
        public string ShipCountry { get; set; }


    }
}
