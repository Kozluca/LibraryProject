
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HamitDeneme.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()                          //List sayfası için  oluşturduk
        {
            ViewBag.BookCount = BookData.Books.Count;       // Listedeki yazar miktarını saydırdık
            var books = BookData.Books;

            return View(books);
        }
        public IActionResult Create()                            //Create sayfası için  oluşturduk
        {
            ViewBag.AuthorNames = new SelectList(BookData.AuthorNames, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookViewModel book)                 //Create sayfası için oluşturduk BookViewModel den author tanımladık(override)
        {
            if (ModelState.IsValid)                                      //if ile eğer bilgiler geçerli ise komutu oluştruduk
            {   
                Book newbook = new Book()                                //newbook adında Liste oluştuduk 
                {
                    AuthorId = book.AuthorId,
                    CopiesAvailable = book.CopiesAvailable,
                    Genre = book.Genre,                                       //bilgileri yazdırdık
                    Id = BookData.Books.Max(b => b.Id) + 1,
                    ISBN = book.ISBN,
                    PublishDate = book.PublishDate,
                    Title = book.Title,
                };
                BookData.Books.Add(newbook);                             //BookData.Books a  newbook u ekledik

                TempData["Mesaj"] = "Kitap başarıyla eklendi.";          //TempData ile Mesaj Tanımladık
                return RedirectToAction("List");                         // Liste Döndük
            }
            ViewBag.AuthorNames = new SelectList(BookData.AuthorNames, "Id", "Name");       //AthorNames adında Selectlist oluşturduk 
            return View();
        }
        public IActionResult Edit(int id)                                       //Edit sayfası için  oluşturduk int Id değeri tanımladık (override)
        {
            Book? book = BookData.Books.FirstOrDefault(b => b.Id == id);        // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar
            if (book == null)
            {
                return NotFound();
            }

            Book vm = new Book()                                             // Book dan vm adında yeni liste oluşturduk
            {
                Title = book.Title,
                Genre = book.Genre,
                CopiesAvailable = book.CopiesAvailable,                    //Değerleri atadık
                ISBN = book.ISBN,
                Id = BookData.Books.Max(b => b.Id) + 1,
                PublishDate = book.PublishDate,
                AuthorId = book.AuthorId,

            };
            TempData["Mesaj"] = " Kitap başarıyla Düzenlendi.";
            return View(vm); 
        }
        [HttpPost]
        public ActionResult Edit(Book vm)                                           //Edit sayfası için  oluşturduk Book dan vm tanımladık (override)
        {
            Book book = BookData.Books.FirstOrDefault(b => b.Id == vm.Id);           // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar
            if (book == null)
            {
                return NotFound();               //book null ise  notfound döndürdük
            }
            if (ModelState.IsValid)     // Değerler geçerliyse
            {
                book.ISBN = vm.ISBN;
                book.Title = vm.Title;              //değerleri atadık
                book.Genre = vm.Genre;
                book.CopiesAvailable = vm.CopiesAvailable;
                book.AuthorId = vm.AuthorId;
                book.PublishDate = vm.PublishDate;
                book.Id = vm.Id;
                return RedirectToAction("List");       // liste döndük
            }
            return View(vm);
        }

        public IActionResult Details(int id)
        {
            Book? book = BookData.Books.FirstOrDefault(a => a.Id == id);

            if (book == null)                            //author null ise 
                return NotFound();                       // notfound döndürdük

            DetailsViewModel vm = new DetailsViewModel()      // BookViewModel den vm adında yeni liste oluşturduk
            {
                Title = book.Title,
                Genre = book.Genre,
                PublishDate = book.PublishDate,          //değerleri atadık
                Id = book.Id,
                CopiesAvailable = book.CopiesAvailable,
                ISBN = book.ISBN,
                AuthorId = book.AuthorId,
                AuthorName = AuthorData.Authors.FirstOrDefault(x => x.Id == book.AuthorId).Name,        //AuthorName için AuthorData.Authors daki Id'yi referenas aldık id deki Name'i yazdırdık
                AuthorSurName = AuthorData.Authors.FirstOrDefault(x => x.Id == book.AuthorId).SurName   //AuthorSurName için AuthorData.Authors daki Id'yi referenas aldık id deki SurName'i yazdırdık
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Delete(int id)                      //Delete sayfası için  oluşturduk int Id değeri tanımladık
        {
            Book book = BookData.Books.FirstOrDefault(b => b.Id == id);     // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar
            if (book == null)                                               //book null ise
            {
                return NotFound();                                          // notfound döndürdük
            }
            BookData.Books.Remove(book);                                    // BookData.Books dan Book u sildik
            TempData["Mesaj"] = " Kitap başarıyla Silindi.";
            return RedirectToAction("List");                                // List e Döndük

        }
        public IActionResult DeleteConfirm(int id)                          //Delete sayfası için oluşturduk int Id değeri tanımladık
        {
            Book book = BookData.Books.FirstOrDefault(b => b.Id == id);      // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar
            if (book == null)                                                //book null ise
                return NotFound();                                           // notfound döndürdük
            ViewBag.Message = "Silme işlemi Başarı ile gerçekleştirildi";    //Mesaj Tanıımladık
            return View(book);
        }
    }
}
