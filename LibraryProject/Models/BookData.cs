namespace LibraryProject.Models
{
    public static class BookData
    {
        public static List<Book> Books { get; set; } = new List<Book>()
        {
            new Book(){Title="Kırmızı",AuthorId=1,PublishDate=new DateTime(2002,12,12),Id=1,Genre="Komedi",CopiesAvailable=10000,ISBN="123AF"},
            new Book(){Title="Gökyüzü",AuthorId=2,PublishDate=new DateTime(2003,10,06),Id=2,Genre="Romantik",CopiesAvailable=10000,ISBN="154KL"},
            new Book(){Title="Karanlık",AuthorId=3,PublishDate=new DateTime(2001,09,09),Id=3,Genre="Dram",CopiesAvailable=10000,ISBN="845UH"},
            new Book(){Title="Huysuzlar",AuthorId=4,PublishDate=new DateTime(1996,01,07),Id=4,Genre="Polisiye",CopiesAvailable=10000,ISBN="198SB"},
            new Book(){Title="Gökkuşağı",AuthorId=5,PublishDate=new DateTime(2004,10,20),Id=5,Genre="Bilim Kurgu",CopiesAvailable=10000,ISBN="952POF"},
            new Book(){Title="3 ADAM",AuthorId=6,PublishDate=new DateTime(2006,11,19),Id=6,Genre="Aşk",CopiesAvailable=10000,ISBN="KAJ56"},
            new Book(){Title="Kod Adı 1",AuthorId=7,PublishDate=new DateTime(2000,01,08),Id=7,Genre="Korku",CopiesAvailable=10000,ISBN="AF234"},
            new Book(){Title="Siyah",AuthorId=8,PublishDate=new DateTime(2009,08,11),Id=8,Genre="Komedi",CopiesAvailable=10000,ISBN="154LK"},
        };
        public static List<AuthorName> AuthorNames = new List<AuthorName>()
        {
            new AuthorName(){Id=11,Name="ÖMER SEYFETTİN"},
            new AuthorName(){Id=12,Name="NAZIM HİKMET"},
            new AuthorName(){Id=13,Name="AYŞE KULİN"},
            new AuthorName(){Id=14,Name="OĞUZ ATAY"},
            new AuthorName(){Id=15,Name="Mehmet Akif Ersoy"},
            new AuthorName(){Id=1,Name="HAhmet HAYDAR"},
            new AuthorName(){Id=2,Name="Hasan SARI"},
            new AuthorName(){Id=3,Name="Ali KARANLIK"},
            new AuthorName(){Id=4,Name="Mehmet ATAY"},
            new AuthorName(){Id=5,Name="Recep TÜRK"},
            new AuthorName(){Id=6,Name="Hüseyin KÖMÜR"},
            new AuthorName(){Id=7,Name="Ayşe ASLAN"},
            new AuthorName(){Id=8,Name="Fatma KIRMIZI"},
        };
    }
}// BookData adında Static bir sınıf oluşturduk ve Database olarak kullanamk için içine bilgileri tanımladık
