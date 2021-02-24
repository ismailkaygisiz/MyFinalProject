using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün bulunabilir";
        public static string ProductNameAlreadyExists = "Aynı isme sahip başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklemesi başarısız oldu";
    }
}