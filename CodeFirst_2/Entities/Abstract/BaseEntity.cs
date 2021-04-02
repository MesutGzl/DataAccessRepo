using CodeFirst_2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_2.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public abstract int  Id { get; set; }
        private DateTime _createDate = DateTime.Now; //Burada yeni eklenen ürünün kayıt tarihinin değiştirilmemesi için kapsülleme yaptık.

        public DateTime CreateDate
        {
            get => _createDate;
            set => _createDate = value;
        }

        public DateTime? UpdateDate { get; set; }   //Yeni oluşturulan product'un UpdateDate ve DeleteDate bilgileri olmaz. Bu sebepten dolayı "?" kullanarak nullable yani boş geçilebilir şekilde işaretledim.
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
