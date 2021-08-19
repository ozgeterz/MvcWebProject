using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace uygulama.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password{ get; set; }

        [DisplayName("Beni Hatırla")]
        public bool Hatirla { get; set; }
     
    }
}