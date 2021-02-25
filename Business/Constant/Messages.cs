using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    // statik yapıları newlemiyoruz, newlemeden kullanılabilir
    public static class Messages
    {

        // public static stringler büyük hafle pascalcase yazılır
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid= "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürünler eklenemedi. Bir kategoride en fazla 15 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten farklı bir ürün var";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
