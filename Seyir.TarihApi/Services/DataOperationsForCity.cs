using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seyir.TarihApi.Services
{
    public class DataOperationsForCity
    {
        public GetCityResult GetCity(string textcity)
            {
            var result = new GetCityResult();
            //Şehirleri array şeklinde listeledim.
            var cities = new string[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
                "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı",
                "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", 
                "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu",
                "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin",
                "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
                "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman",
                "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
           //Girdiğimiz şehir Türkiye'de ise True döndürüen fonk. yazdım.
            if (cities.Contains(textcity)==true)
            {

                result.City = "1";
                result.Description = "Aradığınız şehir Türkiye'dedir.";
                result.Status = Status.SUCCESS;
                return result;
            }
            //Girdiğimiz şehir Türkiye'de değil ise False döndürüen fonk. yazdım.
            else
            { 
            result.City = "-1";
            result.Description = "Aradığınız şehir Türkiye'de değil.";
            result.Status = Status.FAIL;
                return result;
            }
        }
        public enum Status1
        {
            FAIL = 0,
            SUCCESS = 1
        }

    }
    public class GetCityResult
    {
        public string City { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
    }
}

