using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün adı geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir katogoryde en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde ürün vardır.";
        public static string CategoryLimitExceded = "Kategory limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered="Kayıyt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string AccessTokenCreated = "";

        public static string UnitPriceInvalid = "";
        public static string PasswordError = "parola hatası"; 
        public static string UserAlreadyExists = ""; 
    }
}
