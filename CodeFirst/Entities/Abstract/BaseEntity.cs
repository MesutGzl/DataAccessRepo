using System;

namespace BasicDatabaseWithCodeFirst.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get; set; }
        private DateTime _updateDate = DateTime.Now;
        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

    }
}
