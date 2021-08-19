using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace uygulama.Entity
{
    public partial class IhaleBilgileri
    {
        [Key]
        public int IhaleID { get; set; }
        public int KategoriID { get; set; }
  
        public string IhaleDurum { get; set; }
        public decimal BaslangicFiyat { get; set; }
        public int IhaleBaslangicT { get; set; }
        public int IhaleBitisT { get; set; }
       
        public int? OnaylananTeklifID { get; set; }
        public string IhaleDetayBilgi { get; set; }

        public string IhaleUrunIsmi { get; set; }

      public string Image { get; set; }


    }
}