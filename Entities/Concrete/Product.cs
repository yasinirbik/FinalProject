using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product: IEntity
    //Publiic yazdık başa çünkü bu class'a diğer katmanlarda ulaşabilsin istiyoruz
    //Yazmazsak , default'u interanl'dır bu da yalnızca entity katmanı içindekiler erişebilir manasına gelir.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
