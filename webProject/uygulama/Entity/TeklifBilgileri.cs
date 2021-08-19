using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace uygulama.Entity
{
    public class TeklifBilgileri
    {
        [Key]
        public int TeklifID { get; set; }
        public int KullanıcıID { get; set; }
        public int IhaleID { get; set; }
        public decimal Teklif { get; set; }

    }
}