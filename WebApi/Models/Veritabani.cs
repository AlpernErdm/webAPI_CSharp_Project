using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public static class Veritabani
        

    {
        private static Dictionary<string, Davetiyemodel> _liste;
        static Veritabani()
        {
            _liste = new Dictionary<string, Davetiyemodel>();

            _liste.Add("Alperen", new Davetiyemodel
            {
                Ad = "Alperen",
                Eposta="alpernerdm@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Enes", new Davetiyemodel
            {
                Ad = "Alperen",
                Eposta="eness@gmail.com",
                KatilmaDurumu = true
            });


            _liste.Add("Alperen", new Davetiyemodel
            {
                Ad = "Ahmet",
                Eposta="ahmet@gmail.com",
                KatilmaDurumu = true
            });
        }
    }
    }
