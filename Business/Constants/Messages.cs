using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{

    // static verdik çünkü tekrar newlememek için
    public static class Messages
    {
        public static string ParkDetailListed = "Park Detayları Listelendi !";
        public static string ParkAdded = "Park Eklendi.";
        public static string ProductNameInvalid = "Park ismi Geçersiz.";

        public static string ParkListed = "Parklar Listelendi";
        public static string UnitPriceInvalid = "Ürün fiyatı 0 dan küçük olamaz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori sayısı 15 olduğunda yeni ürün eklenemez";
        public static string AuthorizationDenied = "Yetkiniz Bulunmamaktadır.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Kullanıcı tokenı oluşturuldu.";
    }
}
