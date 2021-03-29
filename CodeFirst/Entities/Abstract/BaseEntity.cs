using System;

namespace BasicDatabaseWithCodeFirst.Entities.Abstract
{
    public abstract class BaseEntity
    {
        //Her class'da sürekli olarak kullanacagim propertyleri BaseEntity classında kullanarak diğer classlara kalıtacağım.
        public int Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get; set; }
        private DateTime _updateDate = DateTime.Now;
        public DateTime? UpdateDate { get; set; }//Burada ? kullanmamın sebebi herhangi bir kayıdın oluşturulduğu zaman UpdateDate'i olmaz. Bu sebepten dolayı nullable olarak işaretledim.

        public DateTime? DeleteDate { get; set; }//Burada ? kullanmamın sebebi herhangi bir kayıdın oluşturulduğu zaman DeleteDate'i olmaz. Bu sebepten dolayı nullable olarak işaretledim.

    }
}
