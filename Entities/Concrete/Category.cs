using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category: IEntity
    {
        //Çıplak Class Klamasın yani interface implema-entasyonu yapmamız bizim genel olarak yararımızadır.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
