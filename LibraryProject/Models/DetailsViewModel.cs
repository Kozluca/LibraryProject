namespace LibraryProject.Models
{
    public class DetailsViewModel
    {
        public string Title { get; set; }

        public string Genre { get; set; }

        public int AuthorId { get; set; }

        public DateTime PublishDate { get; set; }

        public int CopiesAvailable { get; set; }

        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurName { get; set; }
        public int Id { get; set; }
    }
}// Kitap detaylarını göstermek için DetailsViewModel adında sınıf oluşturduk ve propertylerini yazdık
