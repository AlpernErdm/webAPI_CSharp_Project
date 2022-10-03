using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seyir.TarihApi.Services
{
    public class DataOperationTeam
    {
        public GetTeamResult GetTeam(string team1)
        {
            var result1 = new GetTeamResult();
            //Şehirleri array şeklinde listeledim.
            var teams = new string[] { "Fenerbahce", "Galatasaray", "Besıktas", "Gaziantepspor", "Trabzonspor", "Adana Demir SPor", "Konyaspor", "Başakşehir",
                "Kayserispor", "Antalyaspor", "Giresunspor", "Alanyaspor", "Karagümrük", "İstansulspor", "Kasımpaşa", "Sivasspor", "Ümraniyespor", "Ankaragücü"
                };
            //Girdiğimiz şehir Türkiye'de ise True döndürüen fonk. yazdım.
            if (teams.Contains(team1) == true)
            {

                result1.Team = "1";
                result1.Description = "Aradığınız takım Türkiye Süper Liginde yer almaktadır.";
                result1.Status = Status.SUCCESS;
                return result1;
            }
            //Girdiğimiz şehir Türkiye'de değil ise False döndürüen fonk. yazdım.
            else
            {
                result1.Team = "-1";
                result1.Description = "Aradığınız takım Türkiye Süper Liginde yer almamaktadır.";
                result1.Status = Status.FAIL;
                return result1;
            }
        }
        public enum Status1
        {
            FAIL = 0,
            SUCCESS = 1
        }
    }
    public class GetTeamResult
    {
        public string Team { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
    }
}

