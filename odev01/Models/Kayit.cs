//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace odev01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kayit
    {
        public int kayitId { get; set; }
        public int kayitDosId { get; set; }
        public int kayitKulId { get; set; }
    
        public virtual Dosya Dosya { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
