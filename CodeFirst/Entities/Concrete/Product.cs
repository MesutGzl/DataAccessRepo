using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System.ComponentModel.DataAnnotations;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Product : BaseEntity
    {
        [Required]
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        [Required]
        public short QuantityPerUnit { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short UnitInStock { get; set; }
        [Required]
        public int UnitsOnOrder { get; set; }
        [Required]
        public string ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

    }
}
