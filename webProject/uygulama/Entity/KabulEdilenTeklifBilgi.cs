using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace uygulama.Entity
{
    public class KabulEdilenTeklifBilgi
    {
        [Key]
        public int OnaylananTeklifID { get; set; }
        public int TeklifID { get; set; }
    }
}