using BasicDatabaseWithCodeFirst.Entities.Abstract;


namespace BasicDatabaseWithCodeFirst.Entities.Concrete
{
    public class Shipper : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
