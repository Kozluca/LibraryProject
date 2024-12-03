using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }

        [Display(Name = " Kitabın Adı")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [MaxLength(50, ErrorMessage = "50 Karakterden uzun olamaz")]
        public string Title { get; set; }

        [Display(Name = "kitabın Türü")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [MaxLength(40, ErrorMessage = "40 Karakterden uzun olamaz")]
        public string Genre { get; set; }

        [Display(Name = " Yazar Adı")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [Display(Name = " Kitabın Basım Tarihi")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [Display(Name = " Kitabın Kopya Sayısı ")]

        public int CopiesAvailable { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [Display(Name = "Kitabın Seri numarası ")]
        [MaxLength(20, ErrorMessage = "20 Karakterden uzun olamaz")]
        public string ISBN { get; set; }
    }
}// BookViewModel adında sunıf oluşturduk ve bu sınıfta Book sınıfından daha farklı özellikler kullanmak istiyoruz
