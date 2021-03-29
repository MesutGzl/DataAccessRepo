using BasicDatabaseWithCodeFirst.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Employee : BaseEntity
    {
        ////Databasemizde Employee adında bir tablo açıp içerisindeki sütunları belirledik.
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string HomePhone { get; set; }
        [Required]
        public string Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public string ReportsTo { get; set; }


    }
}
