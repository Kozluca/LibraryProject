namespace LibraryProject.Models
{
    public class Book
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        public int CopiesAvailable { get; set; }
        public string ISBN { get; set; }
    }
}
// Book sınıfı oluşturduk ve içine propertyleri tanımadık
