using CodeFirst_2.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_2.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public override int Id { get; set; }
        //Database'de Product adında bir tablo açıp içerisindeki sütunları belirledik.
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        
    }
}
