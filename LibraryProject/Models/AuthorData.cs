namespace LibraryProject.Models
{
    public static class AuthorData
    {
        public static List<Author> Authors = new List<Author>()
        {
            new Author(){Name="Ahmet",SurName="HAYDAR", Id=1, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Hasan",SurName="SARI", Id=2, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Ali",SurName="KARANLIK", Id=3, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Mehmet",SurName="ATAY", Id=4, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Recep",SurName="TÜRK", Id=5, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Hüseyin",SurName="KÖMÜR", Id=6, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Ayşe",SurName="ASLAN", Id=7, DateOfBorn=new DateTime(1982,08,22)},
            new Author(){Name="Fatma",SurName="KIRMIZI", Id=8, DateOfBorn=new DateTime(1982,08,22)},
        };
    }
}
// AuthorData adında Static bir sınıf oluşturduk ve Database olarak kullanamk için içine bilgileri tanımladık