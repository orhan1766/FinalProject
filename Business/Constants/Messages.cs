using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi gecersiz.";
        public static string MaintenanceTime="Sistem bakimda";
        public static string ProductListed= "Ürünler listelendi";
        public static string UnitPriceInvalid;
        public static string ProductCountOfCategoryError="Bu Kategorideki urun sayisi 10 ve daha fazla olamaz";
        public static string ProductNameAlreadyExists="Bu isimde zaten baska bir urun var";
        public static string CategoryLimitExceded="Kategori limiti asildigi icin yeni urun eklenemiyor";
    }
}
