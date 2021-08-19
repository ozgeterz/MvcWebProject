using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace uygulama.Models
{
    public class Register
    {
      

        [Required]
        [DisplayName("Ad")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyad")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
     
        [Required]
        [DisplayName("E-posta Adresi")]
        [EmailAddress(ErrorMessage = "E-posta adresinizi düzgün giriniz.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }


    }
}
