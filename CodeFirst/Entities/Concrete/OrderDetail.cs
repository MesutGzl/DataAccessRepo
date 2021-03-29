using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System.ComponentModel.DataAnnotations;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        //Databasemizde OrderDetail adında bir tablo açıp içerisindeki sütunları belirledik.
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }//Order classımızın içerisinde OrderID'yi aldık.
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }//Product classımızın içerisinde ProductID'yi aldık.
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
        public decimal Discount { get; set; }

    }
}
