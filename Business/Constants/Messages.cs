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
        public static string ParkNameInvalid = "Park ismi Geçersiz.";
        public static string ParkListed = "Parklar Listelendi";
        public static string ParkNameAlreadyExists = "Bu isimde zaten başka bir ürün var";

        public static string AuthorizationDenied = "Yetkiniz Bulunmamaktadır.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Kullanıcı tokenı oluşturuldu.";
    }
}
