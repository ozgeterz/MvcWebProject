using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace uygulama.Entity
{

    public class KategoriBilgileri
    {
        [Key]

        public int KategoriID { get; set; }
        public string KategoriIsmi { get; set; }
    }
}