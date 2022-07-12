using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOdev1.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required, Display(Name = "Adınız")]
        public string Ad { get; set; }
        [Required, Display(Name = "Soyadınız")]
        public string Soyad { get; set; }
        [Required, Display(Name = "Kullanıcı Adı")]
        public string  KullaniciAdi { get; set; }

        [Required(ErrorMessage ="Bu alanı boş bırakmazsınız")]
        [Display(Name ="Email"),EmailAddress(ErrorMessage ="format yanlış")]
        public string Email { get; set; }
        [Phone,Required,Display(Name ="Telefon No")]
        public string Telefon { get; set; }
        [Required]
        [Display(Name = "Şifrenizi Giriniz"), DataType(DataType.Password)]
        public string Sifre { get; set; }
        [Compare("Sifre")]
        [Display(Name ="Şifrenizi Tekrar Giriniz"),DataType(DataType.Password)]
        public string SifreTekrar { get; set; }

    }
}