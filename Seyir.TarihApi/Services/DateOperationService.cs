using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Seyir.TarihApi.Services
{
    public class  DataOperationService

    {
        public GetDayResult GetDay(string textDate)
        {
            var result = new GetDayResult();
            //text date formatını datetıme formatına cevırmek
            if (!string.IsNullOrEmpty(textDate))
            {
                DateTime.TryParse(textDate, out DateTime date);
                if (date.Year != 1)
                {
                    // datetıme formatı sayesınde tarıhın gununu almak
                    var day = date.DayOfWeek.ToString();
                    // degıkenı return etmek
                    result.Status = Status.SUCCESS;
                    result.Day = day;
                    result.Description = $"{textDate} tarihinin hesaplanan günü {day}";

                    return result;
                }
            }
            result.Day = "-1";
            result.Description = "İşlem başarısız oldu.";
            result.Status = Status.FAIL;
            return result;
        }
    }

    public enum Status
    {
        FAIL=0,
        SUCCESS=1
    }

    public class GetDayResult
    {
        public string Day           {get;set;}
        public Status Status        {get;set;}
        public string Description { get; set; }
    }
}
