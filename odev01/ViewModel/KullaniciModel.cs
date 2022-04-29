using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odev01.ViewModel
{
    public class KullaniciModel
    {

        public int kulId { get; set; }
        public string kulAdSoyad { get; set; }
        public string kulMail { get; set; }
        public string kulSifre { get; set; }
        public int kulDogumTarihi { get; set; }
    }
}