using BasicDatabaseWithCodeFirst.Entities.Abstract;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Shipper : BaseEntity
    {
        //Databasemizde Shipper adında bir tablo açıp içerisindeki sütunları belirledik.
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
