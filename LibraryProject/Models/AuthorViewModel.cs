using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Yazarın Adı")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [MaxLength(20, ErrorMessage = "30 Karakterden uzun olamaz")]
        public string Name { get; set; }

        [Display(Name = "Yazarın SoyAdı")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [MaxLength(20, ErrorMessage = "30 Karakterden uzun olamaz")]
        public string SurName { get; set; }

        [Display(Name = "Yazarın Doğum Tarihi")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public DateTime DateOfBorn { get; set; }
    }
}
// AuthorViewModel adında sunıf oluşturduk ve bu sınıfta Author sınıfından daha farklı özellikler kullanmak istiyoruz