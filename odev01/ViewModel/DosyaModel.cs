using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odev01.ViewModel
{
    public class DosyaModel
    {
        public int dosyaId { get; set; }
        public string dosyaAdı { get; set; }
        public string dosyaTuru { get; set; }
        public string dosyaIcerigi { get; set; }
    }
}