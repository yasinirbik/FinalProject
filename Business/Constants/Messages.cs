using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler liselendi.";
        public  static string ProductCountOfCategpryError = "Bir Kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimle zaten başka bir ürün var dolayısyla bu isimle ürünü kaydedemeyiz";
        public  static string CategoryLimitExceded ="En Fazla 15 Kategori bulunabilir, Ürün ekleyebilmek için.";
    }
}
